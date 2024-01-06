using Dapper_Demo.Entities;
using Dapper_Demo.Repositories;

namespace Dapper_Demo.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Users> InsertAsync(Users user)
        {
            var result = await _unitOfWork.UserRepository.InsertAsync(user);
            return result;
        }

        public async Task<Users> GetAsync(int id)
        {
            var result = await _unitOfWork.UserRepository.GetAsync(id);
            return result;
        }

        public async Task<List<Users>> GetAllAsync()
        {
            var result = await _unitOfWork.UserRepository.GetAllAsync();
            return result;
        }

        public async Task<Users> UpdateAsync(int id)
        {
            var result = await _unitOfWork.UserRepository.UpdateAsync(id);
            return result;
        }

        public async Task<Users> DeleteAsync(int id)
        {
            var result = await _unitOfWork.UserRepository.DeleteAsync(id);
            return result;
        }

    }
}
