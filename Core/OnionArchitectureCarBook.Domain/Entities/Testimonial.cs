using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class Testimonial : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }

    public Testimonial()
    {
        Name = string.Empty;
        Title = string.Empty;
        Comment = string.Empty;
        ImageUrl = string.Empty;
    }
}
