namespace OnionArchitectureRentACarBook.Application.DTOs.CarPricingDto;

public class CarPricingQueryDto
{
    public string Id { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string CarId { get; set; } = string.Empty;
    public string PricingId { get; set; } = string.Empty;
}
