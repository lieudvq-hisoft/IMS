using Data.DataAccess;
using Data.Model;
using Data.Models;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IServerService
{

}

public class ServerService : IServerService
{
    private readonly AppDbContext _dbContext;

    public ServerService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResultModel> CreateServer(ServerCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
