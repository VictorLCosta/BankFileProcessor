namespace Domain.Entities;

public class ProcessingRoutine : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}