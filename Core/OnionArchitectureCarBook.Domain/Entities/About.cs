using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public sealed class About : BaseEntity 
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public About()
    {
        Title = string.Empty;
        Description = string.Empty;
        ImageUrl = string.Empty;
    }
}
