namespace OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;

public class ContactQueryDto
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime SendDate { get; set; }
}
