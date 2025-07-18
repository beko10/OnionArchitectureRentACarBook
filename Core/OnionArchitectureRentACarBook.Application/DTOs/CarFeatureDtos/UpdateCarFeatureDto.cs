namespace OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDtos;

public class UpdateCarFeatureDto
{
    public string Id { get; set; } = string.Empty;
    public bool Available { get; set; }
    public string CarId { get; set; } = string.Empty;
    public string FeatureId { get; set; } = string.Empty;
}
