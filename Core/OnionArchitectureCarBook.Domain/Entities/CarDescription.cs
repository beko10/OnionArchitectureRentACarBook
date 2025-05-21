using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class CarDescription:BaseEntity
{
    public string Details { get; set; }

    public string CarId { get; set; }
    public Car Car { get; set; }

    public CarDescription()
    {
        Details = string.Empty;
        CarId = string.Empty;
        CarId = default!;
    }
}
