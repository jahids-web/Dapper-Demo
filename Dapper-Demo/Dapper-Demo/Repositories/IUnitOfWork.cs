namespace Dapper_Demo.Repositories
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }
    }
}
