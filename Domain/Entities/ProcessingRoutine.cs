namespace Domain.Entities;

public class ProcessingRoutine : BaseEntity<int>
{
    [Column("ARQDESC")]
    public string Name { get; set; } = string.Empty;

    [Column("STAPROC")]
    public bool IsActive { get; set; }

    [Column("SITSUPORTAPART")]
    public bool IsPartitioned { get; set; }

    [Column("QTDPARTES")]
    public int? TotalParts { get; set; }

    [Column("SITHEADER")]
    public bool HasHeader { get; set; }

    [Column("SITFOOTER")]
    public bool HasFooter { get; set; }

    public ICollection<FilePattern> FilePatterns { get; set; } = [];

    [Column("NUMPROC")]
    public int InstitutionProfileId { get; set; }
    public InstitutionProfile InstitutionProfile { get; set; } = null!;
}