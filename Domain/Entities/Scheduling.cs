namespace Domain.Entities;

public class Scheduling : BaseEntity<int>
{
    [Column("HORAINIAGENDA")]
    public TimeOnly StartTime { get; set; }

    [Column("HORAFIMAGENDA")]
    public TimeOnly? EndTime { get; set; }

    [Column("PRIORIDADE")]
    public int Priority { get; set; }

    [Column("STAAGENDA")]
    public bool IsActive { get; set; }

    [Column("REPETIRPROCESSO")]
    public bool MustRepeat { get; set; }

    [Column("DATAULTVERIFICACAO")]
    public DateTime? LastVerificationDate { get; set; }

    [Column("CODREPETICAO")]
    public int RepetitionId { get; set; }
    public Repetition? Repetition { get; set; } = null!;

    public ICollection<ProcessingRoutine> ProcessingRoutines { get; set; } = [];
}
