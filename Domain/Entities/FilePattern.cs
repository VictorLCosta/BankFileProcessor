namespace Domain.Entities;

public class FilePattern : BaseEntity<int>
{
    [Column("INFORARQUIVO")]
    public string? FileNamePattern { get; set; }

    [Column("EXTARQUIVO")]
    public FileExtension[] AllowedFileExtensions { get; set; } = [];
}
