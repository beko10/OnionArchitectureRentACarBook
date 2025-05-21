using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

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
