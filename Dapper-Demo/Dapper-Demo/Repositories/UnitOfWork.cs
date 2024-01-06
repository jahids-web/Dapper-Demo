using Dapper_Demo.DbContexts;

namespace Dapper_Demo.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IUserRepository _userRepository;
        private readonly IDapperContext _dapperContext;

        public UnitOfWork(IUserRepository userRepository, IDapperContext dapperContext ) 
        {
            _userRepository = userRepository;
            _dapperContext = dapperContext;
        }

        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_dapperContext);
    }
}
