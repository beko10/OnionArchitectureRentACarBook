namespace OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;

public class CreateServiceCommandDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string IconUrl { get; set; } = string.Empty;
} 