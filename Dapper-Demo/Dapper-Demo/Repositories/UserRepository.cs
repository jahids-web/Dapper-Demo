using Dapper;
using Dapper_Demo.DbContexts;
using Dapper_Demo.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace Dapper_Demo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDapperContext _context;

        public UserRepository(IDapperContext context) 
        { 
            _context = context;
        }

        public Task<Users> InsertAsync(Users user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Users>> GetAllAsync()
        {
            using var connection = new SqlConnection(_context.GetConnectionString("DefaultConnection"));
            var result = await connection.QueryAsync<Users>("select * from Users");
            return result;
        }

        public Task<Users> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Users> UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
