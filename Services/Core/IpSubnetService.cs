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
            if (int.Parse(octets[3]) != 0)
            {
                result.ErrorMessage = IpSubnetErrorMessage.IP_RANGE_FOURTH_OCTET;
            }
            else
            {
                var ipRange = new IpSubnet
                {
                    FirstOctet = int.Parse(octets[0]),
                    SecondOctet = int.Parse(octets[1]),
                    ThirdOctet = int.Parse(octets[2]),
                    FourthOctet = int.Parse(octets[3]),
                    SubnetMask = model.SubnetMask,
                    ParentNetworkId = null
                };
                _dbContext.IpSubnets.Add(ipRange);
                _dbContext.SaveChanges();

                double rangeSize = Math.Pow(2, 32 - model.SubnetMask);
                double subnetIncremental = rangeSize / 256;
                double ipCreated = 0;
                List<IpAddress> ips = new List<IpAddress>();
                for (int i = 0; i < subnetIncremental; i++)
                {
                    for (int t = 0; t < 256 && ipCreated < rangeSize; t++)
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
                transaction.Commit();
                result.Data = _mapper.Map<IpSubnetModel>(ipRange);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private static string[] GetIPv4Octets(string input)
    {
        string pattern = @"(\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);

        if (match.Success)
        {
            string[] octets = new string[4];
            for (int i = 1; i <= 4; i++)
            {
                octets[i - 1] = match.Groups[i].Value;
            }
            return octets;
        }
        else
        {
            return new string[0]; // Return an empty array if no match
        }
    }

    public async Task<ResultModel> Create(int ipSubnetId, List<IpSubnetCreateModel> models)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var ipRange = _dbContext.IpSubnets.Include(x => x.IpAddresses).FirstOrDefault(x => x.Id
             == ipSubnetId);
            if (ipRange == null)
            {
                result.ErrorMessage = IpSubnetErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else
            {
                if (models.Any(x => x.SubnetMask < ipRange.SubnetMask))
                {
                    result.ErrorMessage = IpSubnetErrorMessage.INVALID_RANGE;
                    validPrecondition = false;
                }

                bool belongToParent = models.Any(delegate (IpSubnetCreateModel x)
                {
                    var octets = GetIPv4Octets(x.IpAddresss);
                    return int.Parse(octets[0]) == ipRange.FirstOctet && int.Parse(octets[1]) == ipRange.SecondOctet && int.Parse(octets[3]) > ipRange.ThirdOctet;
                });
                //if (belongToParent)  
            }

            if (validPrecondition)
            {
                var ips = ipRange.IpAddresses;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
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
