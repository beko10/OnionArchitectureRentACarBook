using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public sealed class Pricing : BaseEntity
{
    public string Name { get; set; }

    public List<CarPricing> CarPricings { get; set; }

    public Pricing()
    {
        Name = string.Empty;
        CarPricings = [];
    }
}
