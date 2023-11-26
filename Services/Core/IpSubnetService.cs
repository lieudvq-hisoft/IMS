using AutoMapper;
using CloudinaryDotNet.Actions;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Data.Utils.Tree;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Services.Utilities;
using System;
using System.Text.RegularExpressions;
using static Data.Utils.Tree.TreeExtensions;

namespace Services.Core;
public interface IIpSubnetService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel);
    Task<ResultModel> GetIpRange(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> CreateIpRange(IpRangeCreateModel model);
    Task<ResultModel> GetIpSubnet(int subnetId);
    Task<ResultModel> Delete(int subnetId);
    Task<ResultModel> GetIpAddress(int ipSubnetId, PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel);
}

public class IpSubnetService : IIpSubnetService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private const int SUBNET_MAX_SIZE = 256;
    private const int PREFIX_LENGTH_MAX = 32;

    public IpSubnetService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipSubnets = _dbContext.IpSubnets.Include(x => x.SubNets)
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, ipSubnets.Count());

            ipSubnets = ipSubnets.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            ipSubnets = ipSubnets.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<IpSubnetModel>>(ipSubnets.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetIpRange(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipSubnets = _dbContext.IpSubnets.Include(x => x.SubNets).Include(x => x.ParentNetwork)
                .Where(x => x.ParentNetworkId == null && searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, ipSubnets.Count());

            ipSubnets = ipSubnets.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            ipSubnets = ipSubnets.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);


            paging.Data = _mapper.Map<List<IpSubnetModel>>(ipSubnets.Where(x => x.ParentNetworkId == null).ToList());

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

    public async Task<ResultModel> GetIpAddress(int subnetId, PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var allSubnets = _dbContext.IpSubnets.Include(x => x.ParentNetwork).Include(x => x.SubNets).ThenInclude(x => x.IpAddresses).Include(x => x.IpAddresses).ToList();

            var rootSubnet = GetSubnetTree(subnetId, allSubnets);
            var ipAddressesQuery = GetAllIpAddress(rootSubnet)
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, ipAddressesQuery.Count());

            ipAddressesQuery = ipAddressesQuery.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            ipAddressesQuery = ipAddressesQuery.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<IpAddressModel>>(ipAddressesQuery.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private ITree<IpSubnet> GetSubnetTree(int subnetId, List<IpSubnet> subnets)
    {
        ITree<IpSubnet> virtualRootNode = subnets.ToTree((parent, child) => child.ParentNetworkId == parent.Id);
        ITree<IpSubnet> rootLevelSubnetWithSubTree = virtualRootNode.GetAllChildren().FirstOrDefault(x => x.Data.Id == subnetId);

        if (rootLevelSubnetWithSubTree == null)
        {
            throw new Exception(IpSubnetErrorMessage.NOT_EXISTED);
        }

        return rootLevelSubnetWithSubTree;
    }

    private List<IpAddress> GetAllIpAddress(ITree<IpSubnet> subnet)
    {
        List<ITree<IpSubnet>> childSubnets = subnet.GetAllChildren().ToList();
        var ipAddresses = subnet.Data.IpAddresses.ToList();
        foreach (var ipSubnet in childSubnets.Select(x => x.Data))
        {
            ipAddresses.AddRange(ipSubnet.IpAddresses);
        }

        return ipAddresses;
    }

    public async Task<ResultModel> GetIpSubnet(int subnetId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var subnet = _dbContext.IpSubnets.Include(x => x.ParentNetwork).Include(x => x.SubNets).ThenInclude(x => x.SubNets).FirstOrDefault(x => x.Id == subnetId);
            if (subnet == null)
            {
                result.ErrorMessage = IpSubnetErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<List<IpSubnetModel>>(subnet.SubNets);
                result.Succeed = true;
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
            using var transaction = _dbContext.Database.BeginTransaction();
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
                    Note = model.Note,
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
                        IpPurpose purpose = IpPurpose.Host;
                        if (t == 0)
                        {
                            purpose = IpPurpose.Network;
                        }
                        if (t == 255)
                        {
                            purpose = IpPurpose.Broadcast;
                        }
                        ips.Add(new IpAddress
                        {
                            Address = $"{ipRange.FirstOctet}.{ipRange.SecondOctet}.{ipRange.ThirdOctet + i}.{t}",
                            IsReserved = purpose != IpPurpose.Host,
                            Purpose = purpose,
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
                    if (!IpSubnetBelongToParent(octets, parentSubnet) || !ValidPrefixLengthAndOctets(octets, models[i].PrefixLength))
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
                        result.ErrorMessage = IpSubnetErrorMessage.OVERLAPPED;
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
                        Note = model.Note,
                        ParentNetworkId = parentSubnet.Id
                    };
                    _dbContext.IpSubnets.Add(ipSubnet);
                    _dbContext.SaveChanges();

                    foreach (var ip in ips)
                    {
                        int fourthOctet = GetIPv4Octets(ip.Address)[3];
                        IpPurpose purpose = IpPurpose.Host;
                        if (fourthOctet == 0 || fourthOctet == octets[3])
                        {
                            purpose = IpPurpose.Network;
                        }
                        if (fourthOctet == 255 || fourthOctet == octets[3] + numberOfIps - 1)
                        {
                            purpose = IpPurpose.Broadcast;
                        }
                        ip.IsReserved = purpose != IpPurpose.Host;
                        ip.Purpose = purpose;
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

    private bool ValidPrefixLengthAndOctets(List<int> subnetOctet, int prefixLength)
    {
        bool validPrefixLengthAndOctets = true;
        if (prefixLength <= 24 && subnetOctet[3] != 0)
        {
            validPrefixLengthAndOctets = false;
        }

        return validPrefixLengthAndOctets;
    }

    private List<IpAddress> ExtractSubnetIpAddresses(double numberOfIps, List<int> octets, List<IpAddress> parentIps)
    {
        double subnetIncremental = numberOfIps / SUBNET_MAX_SIZE;
        double ipTaken = 0;
        var ips = new List<IpAddress>();

        if (subnetIncremental == 0)
        {
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
        }
        else
        {
            for (int i = 0; i < subnetIncremental; i++)
            {
                for (int t = 0; t < SUBNET_MAX_SIZE && ipTaken < numberOfIps; t++)
                {
                    ipTaken++;
                    var address = $"{octets[0]}.{octets[1]}.{octets[2] + i}.{t}";
                    var ip = parentIps.FirstOrDefault(x => x.Address.Trim() == address.Trim());
                    if (ip != null)
                    {
                        ips.Add(ip);
                        parentIps.Remove(ip);
                    }
                }
            }
        }

        return ips;
    }

    public async Task<ResultModel> SuggestAdditionalIps(int requestHostId, int quantity)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHost = _dbContext.RequestHosts?.Include(x => x.ServerAllocation)?.ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress).ThenInclude(x => x.IpSubnet).FirstOrDefault(x => x.Id == requestHostId && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }

            var masterSubnet = requestHost?.ServerAllocation?.IpAssignments?.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.IpAddress?.IpSubnet;
            if (masterSubnet == null)
            {
                result.ErrorMessage = "Server allocation must have master ip before assign more";
            }
            else
            {
                var allSubnets = _dbContext.IpSubnets.Include(x => x.ParentNetwork).Include(x => x.SubNets).ThenInclude(x => x.IpAddresses).Include(x => x.IpAddresses).ToList();

                var rootSubnet = GetSubnetTree(masterSubnet.Id, allSubnets);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool IsAvailableIpAddress(int ipAddressId, ResultModel result)
    {
        bool isAvailableIpAddress = true;
        var ipAddress = _dbContext.IpAddresses.Include(x => x.IpAssignments)
                .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                .FirstOrDefault(x => x.Id == ipAddressId);
        if (ipAddress == null)
        {
            isAvailableIpAddress = false;
            result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
        }
        else
        {
            if (ipAddress.IsReserved || ipAddress.Blocked)
            {
                isAvailableIpAddress = false;
                result.ErrorMessage = IpAddressErrorMessage.UNASSIGNABLE;
            }

            if (ipAddress.IpAssignments.Any() || ipAddress.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
            {
                isAvailableIpAddress = false;
                result.ErrorMessage = IpAddressErrorMessage.UNAVAILABLE;
            }
        }

        return isAvailableIpAddress;
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
