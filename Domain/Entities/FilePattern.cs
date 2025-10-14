namespace Domain.Entities;

public class FilePattern : BaseEntity<int>
{
    [Column("INFORARQUIVO")]
    public string? FileNamePattern { get; set; }

    [Column("EXTARQUIVO")]
    public FileExtension[] AllowedFileExtensions { get; set; } = [];

    [Column("CODROTINA")]
    public int CodigoRotina { get; set; }
    public ProcessingRoutine ProcessingRoutine { get; set; } = null!;
}
