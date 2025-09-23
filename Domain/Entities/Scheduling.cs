namespace Domain.Entities;

public class Scheduling : BaseEntity<int>
{
    public TimeOnly StartTime { get; set; }
    public TimeOnly? EndTime { get; set; }

    public ProcessingRoutine ProcessingRoutine { get; set; } = null!;
}
