using System.Data;

namespace Dapper_Demo.DbContexts
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
