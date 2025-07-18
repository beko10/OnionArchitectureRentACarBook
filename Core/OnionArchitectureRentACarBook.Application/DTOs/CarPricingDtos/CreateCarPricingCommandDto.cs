namespace OnionArchitectureRentACarBook.Application.DTOs.CarPricingDtos;

public class CreateCarPricingCommandDto
{
    public decimal Amount { get; set; } 
    public string CarId { get; set; } = string.Empty;
    public string PricingId { get; set; } = string.Empty;
}
