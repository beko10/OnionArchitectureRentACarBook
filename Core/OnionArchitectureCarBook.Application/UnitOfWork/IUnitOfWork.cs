namespace OnionArchitectureRentACarBook.Application.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    Task<int> SaveAsync();
}
