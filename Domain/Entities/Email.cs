namespace Domain.Entities;

public class Email : BaseChargeEntity
{
    /// <summary>
    /// DCREMAIL - varchar(300) - not null
    /// </summary>
    [Column("DCREMAIL")]
    public string? DescricaoEmail
    {
        get => _descricaoEmail;
        set => _descricaoEmail = value?.ToLower().Trim();
    }
    private string? _descricaoEmail;

    /// <summary>
    /// TIPOEMAIL - char(1)
    /// </summary>
    [Column("TIPOEMAIL")]
    public TipoEmail TipoEmail { get; set; }

    /// <summary>
    /// CODUSERIDCAD - varchar(10)
    /// </summary>
    [Column("CODUSERIDCAD")]
    public string? CodigoUsuarioCadastro
    {
        get => _codigoUsuarioCadastro;
        set => _codigoUsuarioCadastro = value?[..Math.Min(10, value.Length)];
    }
    private string? _codigoUsuarioCadastro;

    /// <summary>
    /// DATCADEMAIL - datetime
    /// </summary>
    [Column("DATCADEMAIL")]
    public DateTime DataCadastroEmail { get; set; }

    /// <summary>
    /// CODUSERIDALT - varchar(10)
    /// </summary>
    [Column("CODUSERIDALT")]
    public string? CodigoUsuarioAlteracao
    {
        get => _codigoUsuarioAlteracao;
        set => _codigoUsuarioAlteracao = value?[..Math.Min(10, value.Length)];
    }
    private string? _codigoUsuarioAlteracao;

    /// <summary>
    /// DATALTEMAIL - datetime
    /// </summary>
    [Column("DATALTEMAIL")]
    public DateTime? DataEmailAlterado { get; set; }

    /// <summary>
    /// OBSMAIL - varchar(35)
    /// </summary>
    [Column("OBSMAIL")]
    public string? Observacao { get; set; }

    /// <summary>
    /// STAEMAIL - char(1)
    /// </summary>
    [Column("STAEMAIL")]
    public StatusEmail Status { get; set; }

    /// <summary>
    /// CODCPFCNPJ - numeric(14,0)
    /// </summary>
    [Column("CODCPFCNPJ")]
    public long CpfCnpj { get; set; }

    /// <summary>
    /// CODUSERCANC - varchar(10)
    /// </summary>
    [Column("CODUSERCANC")]
    public string? CodigoUsuarioCancelar
    {
        get => _codigoUsuarioCancelar;
        set => _codigoUsuarioCancelar = value?.Substring(0, Math.Min(10, value.Length));
    }
    private string? _codigoUsuarioCancelar;

    /// <summary>
    /// DATCANCEMAIL
    /// </summary>
    [Column("DATCANCEMAIL")]
    public DateTime? DataEmailCancelado { get; set; }

    /// <summary>
    /// SITMAILPRINC
    /// </summary>
    [Column("SITMAILPRINC")]
    public string? EmailPrincipal { get; set; }

    /// <summary>
    /// DATREMARQ - datetime
    /// </summary>
    [Column("DATREMARQ")]
    public DateTime DataRemessaArquivo { get; set; }

    /// <summary>
    /// REGCKTRANSF - char(1)
    /// </summary>
    [Column("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }

    /// <summary>
    /// STAHIGEMAIL - char(1)
    /// </summary>
    [Column("STAHIGEMAIL")]
    public StatusHigienizado? Higienizado { get; set; }

    /// <summary>
    /// ORGEMAILCLI - varchar(3)
    /// </summary>
    [Column("ORGEMAILCLI")]
    public OrigemEmail OrigemEmailCliente { get; set; }

    /// <summary>
    /// SITROBOT - char(1)
    /// </summary>
    [Column("SITROBOT")]
    public string? SitRobot { get; set; }

    /// <summary>
    /// CODCHAVEBANCO - varchar(50)
    /// </summary>
    [Column("CODCHAVEBANCO")]
    public string? CodigoChaveBanco { get; set; }
}
