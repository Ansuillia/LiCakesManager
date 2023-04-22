using LiCakes.Domain.Models;
using LiCakes.Infra.Data.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LiCakes.Infra.Data.Context
{
    public class SQLServerContextFactory : IContextFactory
  {
    private readonly IOptions<ConnectionSettings> _connectionOptions;

    public SQLServerContextFactory(IOptions<ConnectionSettings> connectionOptions)
    {
      _connectionOptions = connectionOptions;
    }

    public IDatabaseContext DbContext => new LiCakesDbContext(GetDataContext().Options);

    private DbContextOptionsBuilder<LiCakesDbContext> GetDataContext()
    {
      ValidateDefaultConnection();

      var sqlConnectionBuilder = new SqlConnectionStringBuilder(_connectionOptions.Value.DefaultConnection);

      var contextOptionsBuilder = new DbContextOptionsBuilder<LiCakesDbContext>();

      contextOptionsBuilder.UseSqlServer(sqlConnectionBuilder.ConnectionString);

      return contextOptionsBuilder;
    }

    private void ValidateDefaultConnection()
    {
      if (string.IsNullOrEmpty(_connectionOptions.Value.DefaultConnection))
      {
        throw new ArgumentNullException(nameof(_connectionOptions.Value.DefaultConnection));
      }
    }
  }
}
