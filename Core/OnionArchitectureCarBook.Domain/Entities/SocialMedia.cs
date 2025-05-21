using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public sealed class SocialMedia : BaseEntity
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }

    public SocialMedia()
    {
        Name = string.Empty;
        Url = string.Empty;
        Icon = string.Empty;
    }
}
