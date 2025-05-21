using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class CarPricing : BaseEntity
{
    public decimal Amount { get; set; }
    public string CarId { get; set; }
    public Car Car { get; set; }
    public string PricingId { get; set; }
    public Pricing Pricing { get; set; }

    public CarPricing()
    {
        CarId = string.Empty;
        PricingId = string.Empty;
        Pricing = default!;
        Car = default!;
    }

}
