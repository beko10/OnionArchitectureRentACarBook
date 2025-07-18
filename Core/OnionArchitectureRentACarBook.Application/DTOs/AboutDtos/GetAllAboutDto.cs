namespace OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;

public class GetAllAboutDto
{
    public string Id { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}
