namespace Domain.Entities;

internal class Email : BaseEntity<ContractId>
{
    /// <summary>
    /// DCREMAIL - varchar(300) - not null
    /// </summary>
    private string? _descricaoEmail;
    public string? DescricaoEmail
    {
        get => _descricaoEmail;
        set => _descricaoEmail = value?.ToLower().Trim();
    }

    /// <summary>
    /// TIPOEMAIL - char(1)
    /// </summary>
    public TipoEmail TipoEmail { get; set; }

    /// <summary>
    /// CODUSERIDCAD - varchar(10)
    /// </summary>
    private string? _codigoUsuarioCadastro;
    public string? CodigoUsuarioCadastro
    {
        get => _codigoUsuarioCadastro;
        set => _codigoUsuarioCadastro = value?.Substring(0, Math.Min(10, value.Length));
    }

    /// <summary>
    /// DATCADEMAIL - datetime
    /// </summary>
    public DateTime DataCadastroEmail { get; set; }

    /// <summary>
    /// CODUSERIDALT - varchar(10)
    /// </summary>
    private string? _codigoUsuarioAlteracao;
    public string? CodigoUsuarioAlteracao
    {
        get => _codigoUsuarioAlteracao;
        set => _codigoUsuarioAlteracao = value?[..Math.Min(10, value.Length)];
    }

    /// <summary>
    /// DATALTEMAIL - datetime
    /// </summary>
    public DateTime? DataEmailAlterado { get; set; }

    /// <summary>
    /// OBSMAIL - varchar(35)
    /// </summary>
    public string? Observacao { get; set; }

    /// <summary>
    /// STAEMAIL - char(1)
    /// </summary>
    public StatusEmail Status { get; set; }

    /// <summary>
    /// CODCPFCNPJ - numeric(14,0)
    /// </summary>
    public long CpfCnpj { get; set; }

    /// <summary>
    /// CODUSERCANC - varchar(10)
    /// </summary>
    private string? _codigoUsuarioCancelar;
    public string? CodigoUsuarioCancelar
    {
        get => _codigoUsuarioCancelar;
        set => _codigoUsuarioCancelar = value?.Substring(0, Math.Min(10, value.Length));
    }

    /// <summary>
    /// DATCANCEMAIL
    /// </summary>
    public DateTime? DataEmailCancelado { get; set; }

    /// <summary>
    /// SITMAILPRINC
    /// </summary>
    public string? EmailPrincipal { get; set; }

    /// <summary>
    /// DATREMARQ - datetime
    /// </summary>
    public DateTime DataRemessaArquivo { get; set; }

    /// <summary>
    /// REGTIMESTAMP - datetime
    /// </summary>
    public DateTime DataHoraRegistro { get; set; }

    /// <summary>
    /// REGCKTRANSF - char(1)
    /// </summary>
    public string? RegistroTransferido { get; set; }

    /// <summary>
    /// STAHIGEMAIL - char(1)
    /// </summary>
    public StatusHigienizado? Higienizado { get; set; }

    /// <summary>
    /// ORGEMAILCLI - varchar(3)
    /// </summary>
    public OrigemEmail OrigemEmailCliente { get; set; }

    /// <summary>
    /// SITROBOT - char(1)
    /// </summary>
    public string? SitRobot { get; set; }

    /// <summary>
    /// CODCHAVEBANCO - varchar(50)
    /// </summary>
    public string? CodigoChaveBanco { get; set; }
}
