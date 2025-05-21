using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class CarFeature:BaseEntity
{
    public bool Available { get; set; }

    public string CarId { get; set; }
    public Car Car { get; set; }
    public string FeatureId { get; set; }
    public Feature Feature { get; set; }

    public CarFeature()
    {
        CarId = string.Empty;
        FeatureId = string.Empty;
        Car = default!;
        Feature = default!;
    }
}
