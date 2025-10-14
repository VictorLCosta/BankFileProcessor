namespace Domain.Common;

public abstract class BaseEntity : BaseEntity<Guid>
{
    protected BaseEntity() => Id = Guid.NewGuid();
}

public abstract class BaseEntity<TId>
{
    public TId Id { get; protected init; } = default!;

    private DateTime? _createdAt = DateTime.UtcNow;

    [Column("REGTIMESTAMP")]
    public DateTime? CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value ?? DateTime.UtcNow;
    }

    [Column("MODTIMESTAMP")]
    public DateTime? LastModified { get; set; }
}
