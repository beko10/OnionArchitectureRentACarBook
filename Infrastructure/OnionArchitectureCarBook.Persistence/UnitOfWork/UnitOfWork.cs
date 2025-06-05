using OnionArchitectureCarBook.Application.UnitOfWork;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

  
}
