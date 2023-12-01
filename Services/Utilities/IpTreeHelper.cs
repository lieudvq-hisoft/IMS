using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Utils.Tree;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Utils.Tree.TreeExtensions;

namespace Services.Utilities;
public interface IIpTreeHelper
{
    public ITree<IpSubnet> GetSubnetTree(int subnetId);
}

public class IpTreeHelper : IIpTreeHelper
{
    public ITree<IpSubnet> IpSubnetTree { get; private set; }

    private readonly IServiceScopeFactory _scopeFactory;

    public IpTreeHelper(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
        using (var scope = _scopeFactory.CreateScope())
        {
            var _dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var allSubnets = _dbContext.IpSubnets
                .Include(x => x.ParentNetwork)
                .Include(x => x.SubNets).ToList();

            IpSubnetTree = CreateSubnetTree(allSubnets);
        }
    }

    private ITree<IpSubnet> CreateSubnetTree(List<IpSubnet> subnets)
    {
        return subnets.ToTree((parent, child) => child.ParentNetworkId == parent.Id);
    }

    public ITree<IpSubnet> GetSubnetTree(int subnetId)
    {
        return IpSubnetTree.GetAllChildren().FirstOrDefault(x => x.Data.Id == subnetId);
    }
}
