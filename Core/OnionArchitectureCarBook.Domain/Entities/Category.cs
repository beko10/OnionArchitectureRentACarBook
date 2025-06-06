using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public sealed class Category : BaseEntity
{
    public string Name { get; set; }
    public Category()
    {
        Name = string.Empty;
    }
}
