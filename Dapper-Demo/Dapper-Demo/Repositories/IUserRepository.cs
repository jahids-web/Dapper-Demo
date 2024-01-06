using Dapper_Demo.Entities;

namespace Dapper_Demo.Repositories
{
    public interface IUserRepository
    {
        Task <Users> InsertAsync(Users user);
        Task<List<Users>> GetAllAsync();
        Task<Users> UpdateAsync(int id);
        Task<Users> DeleteAsync(int id);
        Task<Users> GetAsync(int id);

    }
}
