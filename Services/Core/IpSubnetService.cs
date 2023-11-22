using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;
using System;
using System.Text.RegularExpressions;

namespace Services.Core;
public interface IIpSubnetService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> CreateIpRange(IpRangeCreateModel model);
    Task<ResultModel> Delete(int subnetId);
}

public class IpSubnetService : IIpSubnetService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly TransactionHelper _transactionHelper;
    private const int SUBNET_MAX_SIZE = 256;
    private const int PREFIX_LENGTH_MAX = 32;

    public IpSubnetService(AppDbContext dbContext, IMapper mapper, TransactionHelper transactionHelper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _transactionHelper = transactionHelper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var IpSubnets = _dbContext.IpSubnets
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, IpSubnets.Count());

            IpSubnets = IpSubnets.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            IpSubnets = IpSubnets.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<IpSubnetModel>(IpSubnets).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetDetail(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipSubnet = _dbContext.IpSubnets.FirstOrDefault(x => x.Id == id);

            if (ipSubnet != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpSubnetModel>(ipSubnet);
            }
            else
            {
                result.ErrorMessage = IpSubnetErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> CreateIpRange(IpRangeCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _transactionHelper.GetTransaction();
            _dbContext.Database.UseTransaction(transaction.GetDbTransaction());
            var octets = GetIPv4Octets(model.IpAddresss);
            if (octets[3] != 0)
            {
                result.ErrorMessage = IpSubnetErrorMessage.IP_RANGE_FOURTH_OCTET;
            }
            else
            {
                var ipRange = new IpSubnet
                {
                    FirstOctet = octets[0],
                    SecondOctet = octets[1],
                    ThirdOctet = octets[2],
                    FourthOctet = octets[3],
                    PrefixLength = model.PrefixLength,
                    ParentNetworkId = null
                };
                _dbContext.IpSubnets.Add(ipRange);
                _dbContext.SaveChanges();

                double rangeSize = Math.Pow(2, PREFIX_LENGTH_MAX - model.PrefixLength);
                double subnetIncremental = rangeSize / SUBNET_MAX_SIZE;
                double ipCreated = 0;
                List<IpAddress> ips = new List<IpAddress>();
                for (int i = 0; i < subnetIncremental; i++)
                {
                    for (int t = 0; t < SUBNET_MAX_SIZE && ipCreated < rangeSize; t++)
                    {
                        ipCreated++;
                        ips.Add(new IpAddress
                        {
                            Address = $"{ipRange.FirstOctet}.{ipRange.SecondOctet}.{ipRange.ThirdOctet + i}.{t}",
                            IsReserved = (t == 0 || t == 255),
                            IpSubnetId = ipRange.Id
                        });
                    }
                }

                _dbContext.IpAddresses.AddRange(ips);
                _dbContext.SaveChanges();

                var createSubnetResult = await Create(ipRange.Id, model.IpSubnets);
                if (!createSubnetResult.Succeed)
                {
                    result.ErrorMessage = createSubnetResult.ErrorMessage;
                    transaction.Rollback();
                }
                else
                {
                    transaction.Commit();
                    result.Data = _mapper.Map<IpSubnetModel>(ipRange);
                    result.Succeed = true;
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private static List<int> GetIPv4Octets(string input)
    {
        string pattern = @"(\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);

        if (match.Success)
        {
            var octets = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                octets.Add(int.Parse(match.Groups[i].Value));
            }
            return octets;
        }
        else
        {
            throw new Exception("Invalid ipv4");
        }
    }

    public async Task<ResultModel> Create(int ipSubnetId, List<IpSubnetCreateModel> models)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var parentSubnet = _dbContext.IpSubnets.Include(x => x.IpAddresses).FirstOrDefault(x => x.Id
             == ipSubnetId);
            var subnetsOctets = new List<List<int>>();
            var subnetIps = new List<List<IpAddress>>();

            if (parentSubnet == null)
            {
                result.ErrorMessage = IpSubnetErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else
            {
                if (models.Any(x => x.PrefixLength < parentSubnet.PrefixLength))
                {
                    result.ErrorMessage = IpSubnetErrorMessage.INVALID_RANGE;
                    validPrecondition = false;
                }

                for (int i = 0; i < models.Count; i++)
                {
                    var octets = GetIPv4Octets(models[i].IpAddresss);
                    if (!IpSubnetBelongToParent(octets, parentSubnet))
                    {
                        result.ErrorMessage = IpSubnetErrorMessage.INVALID_RANGE;
                        validPrecondition = false;
                    }
                    else
                    {
                        subnetsOctets.Add(octets);
                    }
                }
            }

            if (validPrecondition)
            {
                var parentIps = parentSubnet.IpAddresses.ToList();
                for (int i = 0; i < models.Count; i++)
                {
                    double numberOfIps = Math.Pow(2, PREFIX_LENGTH_MAX - models[i].PrefixLength);
                    var ips = ExtractSubnetIpAddresses(numberOfIps, subnetsOctets[i], parentIps);

                    if (ips.Count != numberOfIps)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
                    }
                    else
                    {
                        subnetIps.Add(ips);
                    }
                }
            }

            if (validPrecondition)
            {
                for (int i = 0; i < models.Count; i++)
                {
                    var model = models[i];
                    var octets = subnetsOctets[i];
                    double numberOfIps = Math.Pow(2, PREFIX_LENGTH_MAX - model.PrefixLength);
                    var ips = subnetIps[i];
                    var ipSubnet = new IpSubnet
                    {
                        FirstOctet = octets[0],
                        SecondOctet = octets[1],
                        ThirdOctet = octets[2],
                        FourthOctet = octets[3],
                        PrefixLength = model.PrefixLength,
                        ParentNetworkId = parentSubnet.Id
                    };
                    _dbContext.IpSubnets.Add(ipSubnet);
                    _dbContext.SaveChanges();

                    foreach (var ip in ips)
                    {
                        int fourthOctet = GetIPv4Octets(ip.Address)[3];
                        ip.IsReserved = fourthOctet == 0 || fourthOctet == 255 || fourthOctet == octets[3] || fourthOctet == octets[3] + numberOfIps - 1;
                        ip.IpSubnetId = ipSubnet.Id;
                    }
                    _dbContext.SaveChanges();
                    result.Succeed = true;
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool IpSubnetBelongToParent(List<int> subnetOctet, IpSubnet parentSubnet)
    {
        double parentSubnetIncremental = Math.Pow(2, PREFIX_LENGTH_MAX - parentSubnet.PrefixLength) / SUBNET_MAX_SIZE;   
        return subnetOctet[0] == parentSubnet.FirstOctet && subnetOctet[1] == parentSubnet.SecondOctet && subnetOctet[2] >= parentSubnet.ThirdOctet && subnetOctet[2] < parentSubnet.ThirdOctet + parentSubnetIncremental;
    }

    private List<IpAddress> ExtractSubnetIpAddresses(double numberOfIps, List<int> octets, List<IpAddress> parentIps)
    {
        var ips = new List<IpAddress>();

        for (int t = octets[3]; t < octets[3] + numberOfIps; t++)
        {
            var address = $"{octets[0]}.{octets[1]}.{octets[2]}.{t}";
            var ip = parentIps.FirstOrDefault(x => x.Address.Trim() == address.Trim());
            if (ip != null)
            {
                ips.Add(ip);
                parentIps.Remove(ip);
            }
        }

        return ips;
    }

    public async Task<ResultModel> Delete(int subnetId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipSubnet = _dbContext.IpSubnets.Include(x => x.IpAddresses).FirstOrDefault(x => x.Id == subnetId);
            _dbContext.IpAddresses.RemoveRange(ipSubnet.IpAddresses);
            _dbContext.IpSubnets.Remove(ipSubnet);
            _dbContext.SaveChanges();
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
