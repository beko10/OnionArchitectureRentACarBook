namespace OnionArchitectureRentACarBook.Application.DTOs.CarDto;

public class UpdateCarCommandDto
{
    public string Id { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string CoverImageUrl { get; set; } = string.Empty;
    public int Km { get; set; }
    public string Transmission { get; set; } = string.Empty;
    public byte Seat { get; set; }
    public byte Luggage { get; set; }
    public string CarFuelType { get; set; } = string.Empty;
    public string BigImageUrl { get; set; } = string.Empty;
    public string BrandId { get; set; } = string.Empty;
}
