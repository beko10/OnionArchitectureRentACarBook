using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class Service : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string IconUrl { get; set; }

    public Service()
    {
        Title = string.Empty;
        Description = string.Empty;
        IconUrl = string.Empty;
    }
}
