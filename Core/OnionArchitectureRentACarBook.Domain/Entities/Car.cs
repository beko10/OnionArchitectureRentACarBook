using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public sealed class Car:BaseEntity
{
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Km { get; set; }
    public string Transmission { get; set; }
    public byte Seat { get; set; }
    public byte Luggage { get; set; }
    public string CarFuelType { get; set; }
    public string BigImageUrl { get; set; }

    public string BrandId { get; set; }
    public Brand Brand { get; set; }

    public List<CarFeature> CarFeatures { get; set; }
    public List<CarDescription> CarDescriptions { get; set; }
    public List<CarPricing> CarPricings { get; set; }
    
    public Car()
    {
        Model = string.Empty;
        CoverImageUrl = string.Empty;
        Transmission = string.Empty;
        CarFuelType = string.Empty;
        BigImageUrl = string.Empty;
        Brand = default!;
        BrandId = string.Empty;
        CarFeatures = [];
        CarDescriptions = [];
        CarPricings = [];
    }
}
