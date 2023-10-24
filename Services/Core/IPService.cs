using Data.DataAccess;
using Data.Model;
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IIpService
{
    Task<ResultModel> AttempAssignIp(IDbContextTransaction transaction);
}

public class IpService: IIpService
{
    private readonly AppDbContext _dbContext;

    public IpService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResultModel> AttempAssignIp(IDbContextTransaction transaction)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
