using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class Category : BaseEntity
{
    public string Name { get; set; }
    public Category()
    {
        Name = string.Empty;
    }
}
