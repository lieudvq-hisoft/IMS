using Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Services.Core;
public class TransactionHelper
{
    private readonly AppDbContext _dbContext;

    public TransactionHelper(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IDbContextTransaction GetTransaction()
    {
        var connection = _dbContext.Database.GetDbConnection();
        var options = new DbContextOptionsBuilder<AppDbContext>().UseNpgsql(connection)
            .Options;
        var context = new AppDbContext(options);
        return context.Database.BeginTransaction();
    }
}
