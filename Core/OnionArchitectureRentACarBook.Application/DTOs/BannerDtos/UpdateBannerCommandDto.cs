namespace OnionArchitectureRentACarBook.Application.DTOs.BannerDtos;

public class UpdateBannerCommandDto
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string VideoUrl { get; set; } = string.Empty;
}
