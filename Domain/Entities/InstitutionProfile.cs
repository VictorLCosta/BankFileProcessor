namespace Domain.Entities;

public class InstitutionProfile : BaseEntity<int>
{
    [Column("TIPPROC")]
    public TipoProcesso ProcessType { get; set; }

    [Column("DCRPROC")]
    public string Name { get; set; } = string.Empty;

    [Column("DCRDIR")]
    public string DefaultDirectory { get; set; } = string.Empty;

    public ICollection<ProcessingRoutine> Routines { get; set; } = [];
}
