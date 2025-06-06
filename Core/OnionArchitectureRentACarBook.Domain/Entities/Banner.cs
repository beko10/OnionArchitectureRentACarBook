using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public sealed class Banner : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string VideoUrl { get; set; }

    public Banner()
    {
        Title = string.Empty;
        Description = string.Empty;
        VideoUrl = string.Empty;
    }
}
