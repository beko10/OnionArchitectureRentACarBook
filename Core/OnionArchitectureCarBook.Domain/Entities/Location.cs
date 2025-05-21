using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public class Location:BaseEntity
{
    public string Name { get; set; }

    public Location()
    {
        Name = string.Empty;
    }
}
