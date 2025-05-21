using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class Contact : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime SendDate { get; set; }

    public Contact()
    {
        Name = string.Empty;
        Email = string.Empty;
        Subject = string.Empty;
        Message = string.Empty;
    }
}
