using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Data.Utils.Tree;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;
using System.Text.RegularExpressions;
using static Data.Utils.Tree.TreeExtensions;

namespace Services.Core;
public interface IIpSubnetService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel);
    Task<ResultModel> GetIpRange(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel);
    Task<ResultModel> GetIpAddress(int ipSubnetId, PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetIpSubnet(int subnetId);
    Task<ResultModel> GetNextAddress(int subnetId);
    Task<ResultModel> CreateIpRange(IpRangeCreateModel model);
    Task<ResultModel> Create(int ipSubnetId, List<IpSubnetCreateModel> models);
    Task<ResultModel> Delete(int subnetId);
    Task<ResultModel> SuggestAdditionalIps(SuggestAdditionalIpModel model);
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
            var subnetTree = CreateSubnetTree();
            var rootSubnet = GetSubnetTree(subnetId, subnetTree);
            var ipAddressesQuery = GetAllIpAddress(rootSubnet)
                .Where(delegate (IpAddress x)
                {
                    var matchAddress = searchModel.Address != null ? x.Address.Contains(searchModel.Address) : true;
                    var available = searchModel.IsAvailable != null ? x.IsAvailable() == searchModel.IsAvailable : true;
                    return matchAddress && available;
                })
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

    private ITree<IpSubnet> CreateSubnetTree()
    {
        var allSubnets = _dbContext.IpSubnets
            .Include(x => x.ParentNetwork)
            .Include(x => x.SubNets).ToList();

        return allSubnets.ToTree((parent, child) => child.ParentNetworkId == parent.Id);
    }

    private ITree<IpSubnet> GetSubnetTree(int subnetId, ITree<IpSubnet> subnetTree)
    {
        return subnetTree.GetAllChildren().FirstOrDefault(x => x.Data.Id == subnetId);
    }

    private List<IpAddress> GetAllIpAddress(ITree<IpSubnet> subnet)
    {
        List<ITree<IpSubnet>> childSubnets = subnet.GetAllChildren().ToList();
        var ipAddresses = new List<IpAddress>();
        if (subnet.Data != null)
        {
            var subnetIps = _dbContext.IpAddresses
                .Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                .Where(x => x.IpSubnetId == subnet.Data.Id)
                .ToList();
            ipAddresses.AddRange(subnetIps);
            foreach (var ipSubnet in childSubnets.Select(x => x.Data))
            {
                var childSubnetIps = _dbContext.IpAddresses
                    .Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                    .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                    .Where(x => x.IpSubnetId == ipSubnet.Id)
                    .ToList();
                ipAddresses.AddRange(childSubnetIps);
            }
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

    public async Task<ResultModel> GetNextAddress(int subnetId)
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
                var numberOfIp = Math.Pow(2, PREFIX_LENGTH_MAX - subnet.PrefixLength);
                var newFourthOctet = subnet.FourthOctet + numberOfIp;
                if (newFourthOctet > SUBNET_MAX_SIZE)
                {
                    result.ErrorMessage = "End of subnet";
                }
                else
                {
                    result.Data = $"{subnet.FirstOctet}.{subnet.SecondOctet}.{subnet.ThirdOctet}.{newFourthOctet}";
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

    public async Task<ResultModel> CreateIpRange(IpRangeCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

            using var transaction = _dbContext.Database.BeginTransaction();
            var octets = GetIPv4Octets(model.IpAddresss);
            var existedSubnet = _dbContext.IpSubnets.FirstOrDefault(x => x.FirstOctet == octets[0] && x.SecondOctet == octets[1] && x.ThirdOctet == octets[2]);
            if (existedSubnet != null)
            {
                result.ErrorMessage = "Subnet existed";
            }
            else if (octets[3] != 0)
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
        int subnetIncremental = (int)numberOfIps / SUBNET_MAX_SIZE;
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

    public async Task<ResultModel> SuggestAdditionalIps(SuggestAdditionalIpModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations?.Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress).ThenInclude(x => x.IpSubnet).FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else
            {
                var masterSubnet = serverAllocation?.IpAssignments?.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.IpAddress?.IpSubnet;
                if (masterSubnet == null)
                {
                    result.ErrorMessage = "Server allocation must have master ip before assign more";
                }
                else
                {
                    //var allSubnets = _dbContext.IpSubnets
                    //    .Include(x => x.ParentNetwork)
                    //    .Include(x => x.IpAddresses).ThenInclude(x => x.IpAssignments)
                    //    .Include(x => x.IpAddresses).ThenInclude(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                    //    .Include(x => x.SubNets).ThenInclude(x => x.IpAddresses).ThenInclude(x => x.IpAssignments)
                    //    .Include(x => x.SubNets).ThenInclude(x => x.IpAddresses).ThenInclude(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                    //    .ToList();

                    var subnetTree = CreateSubnetTree();
                    var rootSubnet = GetSubnetTree(masterSubnet.Id, subnetTree);
                    var additionalIps = new List<IpAddress>();
                    while (rootSubnet.Parent != null && additionalIps.Count() < model.Quantity)
                    {
                        var numberOfRequired = model.Quantity - additionalIps.Count();
                        var additionalIpIds = additionalIps.Select(x => x.Id);
                        var ipAddresses = GetAllIpAddress(rootSubnet)
                            .Where(x => !x.Blocked && !x.IsReserved && !x.IpAssignments.Any() && !x.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed))
                            .Where(x => !additionalIpIds.Contains(x.Id));
                        if (ipAddresses.Count() >= numberOfRequired)
                        {
                            additionalIps.AddRange(ipAddresses.Take(numberOfRequired));
                        }
                        else
                        {
                            additionalIps.AddRange(ipAddresses);
                            rootSubnet = rootSubnet.Parent;
                        }
                    }

                    if (additionalIps.Count() < model.Quantity)
                    {
                        var numberOfRequired = model.Quantity - additionalIps.Count();
                        var additionalIpIds = additionalIps.Select(x => x.Id);
                        var ipAddresses = _dbContext.IpAddresses
                            .Include(x => x.IpAssignments)
                            .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                            .Where(x => !x.Blocked && !x.IsReserved && !x.IpAssignments.Any() && !x.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed))
                            .Where(x => !additionalIpIds.Contains(x.Id));
                        if (ipAddresses.Count() < numberOfRequired)
                        {
                            result.ErrorMessage = IpAddressErrorMessage.NO_AVAILABLE;
                        }
                        else
                        {
                            additionalIps.AddRange(ipAddresses.Take(numberOfRequired));
                        }
                    }

                    if (additionalIps.Count() == model.Quantity)
                    {
                        var subnets = additionalIps.Select(x => x.IpSubnet).DistinctBy(x => x.Id);
                        result.Succeed = true;
                        result.Data = new SuggestAdditionalIpResultModel
                        {
                            IpSubnets = _mapper.Map<List<IpSubnetResultModel>>(subnets),
                            IpAddresses = _mapper.Map<List<IpAddressResultModel>>(additionalIps)
                        };
                    }
                }
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
