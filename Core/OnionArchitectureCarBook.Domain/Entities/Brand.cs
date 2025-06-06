using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

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
