namespace Domain.Common;

public abstract class BaseChargeEntity
{
    private DateTime _dataHoraRegistro { get; set; } = DateTime.Now;

    [Column("CODEMPRESA")]
    public int CodigoEmpresa { get; set; }

    [Column("NUMCONTRDIV")]
    public string NumeroContrato { get; set; } = null!;

    [Column("REGTIMESTAMP")]
    public DateTime? DataHoraRegistro 
    { 
        get => _dataHoraRegistro; 
        set => _dataHoraRegistro = value ?? DateTime.Now; 
    }
}