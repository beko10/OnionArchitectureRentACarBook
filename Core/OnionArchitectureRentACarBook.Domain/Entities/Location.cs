using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public class Location:BaseEntity
{
    public string Name { get; set; }

    public Location()
    {
        Name = string.Empty;
    }
}
