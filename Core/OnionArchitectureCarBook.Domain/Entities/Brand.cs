using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class Brand:BaseEntity
{
    public string Name { get; set; }
    public List<Car> Cars { get; set; }

    public Brand()
    {
        Name = string.Empty;
        Cars = [];
    }
}
