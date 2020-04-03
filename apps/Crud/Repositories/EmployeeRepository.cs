using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Crud.Models;
using Dapper;
using Npgsql;

namespace Crud.Repositories {
  public class EmployeeRepository : IAsyncDisposable {
    private readonly DbConnection dbConnection;
    public EmployeeRepository() {
      this.dbConnection = new NpgsqlConnection($"Host=localhost; Port=5432; Database=postgres; Username=postgres; Password=example");
    }

    public async Task<IEnumerable<Employee>> GetAll() {
      var employees = await dbConnection.QueryAsync<Employee>("select * from employees");
      return employees;
    }

    public async ValueTask DisposeAsync() {
      await this.dbConnection.CloseAsync();
    }
  }
}
