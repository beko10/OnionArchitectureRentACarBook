using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public sealed class FooterAdress : BaseEntity
{
    public string Description { get; set; }
    public string Adress { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public FooterAdress()
    {
        Description = string.Empty;
        Adress = string.Empty;
        Phone = string.Empty;
        Email = string.Empty;
    }
}
