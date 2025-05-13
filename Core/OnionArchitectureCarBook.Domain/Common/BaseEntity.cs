namespace OnionArchitectureCarBook.Domain.Common;

public abstract class BaseEntity
{
    public string Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;

    protected BaseEntity()
    {
        Id = Guid.NewGuid().ToString();
    }
}
