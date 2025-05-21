namespace OnionArchitectureCarBook.Application.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    Task<int> SaveAsync();
}
