namespace Domain.Entities;

public class Repetition : BaseEntity<int>
{
    [Column("NOMREPETICAO")]
    public string Name { get; set; } = string.Empty;

    [Column("DIASSEMANA")]
    public DayOfWeek[] DaysOfWeek { get; set; } = [];

    [Column("INTERVALO")]
    public TimeSpan? IntervalInSeconds { get; set; }
}
