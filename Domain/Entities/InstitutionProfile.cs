namespace Domain.Entities;

public class InstitutionProfile : BaseEntity<int>
{
    public TipoProcesso ProcessType { get; set; }
    public string Name { get; set; } = string.Empty;
    public string DefaultDirectory { get; set; } = string.Empty;

    public ICollection<ProcessingRoutine> Routines { get; set; } = [];
}
