using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Phone : BaseChargeEntity
{
    public long Numero { get; set; }

    /// <summary>
    /// [CODTELCOBR] [int] NOT NULL
    /// </summary>
    [Column("CODTELCOBR")]
    public TipoTelefone Codigo { get; set; }

    /// <summary>
    /// [SITPRIORTELCOBR] [smallint] NOT NULL
    /// </summary>
    [Column("SITPRIORTELCOBR")]
    public short Prioridade { get; set; }

    /// <summary>
    /// [OBSTELCOBR] [varchar](100) NULL,
    /// </summary>
    [Column("OBSTELCOBR")]
    public string? Observacao { get; set; }

    /// <summary>
    /// [STATELCOBR] [char](1) NOT NULL
    /// </summary>
    [Column("STATELCOBR")]
    public StatusTelefone Status { get; set; }

    /// <summary>
    /// [SITBLOQSMS] [char](1) NOT NULL
    /// </summary>
    [Column("SITBLOQSMS")]
    public string BloqueioSms { get; set; } = null!;

    /// <summary>
    /// [USERCADTELCOBR] [varchar](10) NULL
    /// </summary>
    [Column("USERCADTELCOBR")]
    public string? UsuarioCadastrou
    {
        get
        {
            return _usuarioCadastrou;
        }
        set
        {
            _usuarioCadastrou = Strings.Left(value, 10);
        }
    }
    private string? _usuarioCadastrou;

    /// <summary>
    /// [USERALTERTELCOBR] [varchar](10) NULL
    /// </summary>
    [Column("USERALTERTELCOBR")]
    public string? UsuarioAlterou
    {
        get
        {
            return _usuarioAlterou;
        }
        set
        {
            _usuarioAlterou = Strings.Left(value, 10);
        }
    }
    private string? _usuarioAlterou;

    /// <summary>
    /// [USERCANCTELCOBR] [varchar](10) NULL
    /// </summary>
    [Column("USERCANCTELCOBR")]
    public string? UsuarioCancelou
    {
        get => _usuarioCancelou;
        set => _usuarioCancelou = Strings.Left(value, 10);
    }
    private string? _usuarioCancelou;

    /// <summary>
    /// [DATCANCTELCOBR] [datetime] NULL
    /// </summary>
    [Column("DATCANCTELCOBR")]
    public DateTime? DataHoraCancelamento { get; set; }

    /// <summary>
    /// [DATCADTELCOBR] [datetime] NULL
    /// </summary>
    [Column("DATCADTELCOBR")]
    public DateTime? DataHoraCadastro { get; set; }

    /// <summary>
    /// [CODCPFCNPJCLI] [numeric](14, 0) NOT NULL
    /// </summary>
    [Column("CODCPFCNPJCLI")]
    public long CpfCnpjCliente { get; set; }

    /// <summary>
    /// [DATREMARQ] [datetime] NULL
    /// </summary>
    [Column("DATREMARQ")]
    public DateTime? DataRemessa { get; set; }

    /// <summary>
    /// [STAHIGTELCOBR] [char](1) NULL
    /// </summary>
    [Column("STAHIGTELCOBR")]
    public StatusHigienizado Higienizado { get; set; }

    /// <summary>
    /// [NUMTELORIGINAL] [varchar](20) NULL
    /// </summary>
    [Column("NUMTELORIGINAL")]
    public string? NumeroOriginal { get; set; }

    /// <summary>
    /// [CODAREA] [varchar](10) NULL
    /// </summary>
    [Column("CODAREA")]
    public string? CodigoArea { get; set; }

    /// <summary>
    /// [CODORGTEL] [varchar](50) NULL
    /// </summary>
    [Column("CODORGTEL")]
    public OrigemEmail Origem { get; set; }

    /// <summary>
    /// [SCORETELCOBR] [int] NULL
    /// </summary>
    [Column("SCORETELCOBR")]
    public int? Score { get; set; }

    /// <summary>
    /// CODCHAVEBANCO - varchar(50)
    /// </summary>
    [Column("CODCHAVEBANCO")]
    public string? CodigoChaveBanco { get; set; }

    /// <summary>
    /// CODEMPPESQ - int
    /// </summary>
    [Column("CODEMPPESQ")]
    public int? CodigoFornecedorPesq { get; set; }
}
