using OnionArchitectureCarBook.Domain.Common;

namespace OnionArchitectureCarBook.Domain.Entities;

public class Feature:BaseEntity
{
    public string Name { get; set; }

    public List<CarFeature> CarFeatures { get; set; }

    public Feature()
    {
        Name = string.Empty;
        CarFeatures = [];
    }
}
