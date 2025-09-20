using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Phone : BaseEntity<ContractId>
{
    public long Numero { get; set; }

    /// <summary>
    /// [CODTELCOBR] [int] NOT NULL
    /// </summary>
    public TipoTelefone Codigo { get; set; }

    /// <summary>
    /// [SITPRIORTELCOBR] [smallint] NOT NULL
    /// </summary>
    public short Prioridade { get; set; }

    /// <summary>
    /// [OBSTELCOBR] [varchar](100) NULL,
    /// </summary>
    public string? Observacao { get; set; }

    /// <summary>
    /// [STATELCOBR] [char](1) NOT NULL
    /// </summary>
    public StatusTelefone Status { get; set; }

    /// <summary>
    /// [SITBLOQSMS] [char](1) NOT NULL
    /// </summary>
    public string BloqueioSms { get; set; } = null!;

    /// <summary>
    /// [USERCADTELCOBR] [varchar](10) NULL
    /// </summary>
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
    public string? UsuarioCancelou
    {
        get => _usuarioCancelou;
        set => _usuarioCancelou = Strings.Left(value, 10);
    }
    private string? _usuarioCancelou;

    /// <summary>
    /// [DATCANCTELCOBR] [datetime] NULL
    /// </summary>
    public DateTime? DataHoraCancelamento { get; set; }

    /// <summary>
    /// [DATCADTELCOBR] [datetime] NULL
    /// </summary>
    public DateTime? DataHoraCadastro { get; set; }

    /// <summary>
    /// [CODCPFCNPJCLI] [numeric](14, 0) NOT NULL
    /// </summary>
    public long CpfCnpjCliente { get; set; }

    /// <summary>
    /// [DATREMARQ] [datetime] NULL
    /// </summary>
    public DateTime? DataRemessa { get; set; }

    /// <summary>
    /// [STAHIGTELCOBR] [char](1) NULL
    /// </summary>
    public StatusHigienizado Higienizado { get; set; }

    /// <summary>
    /// [NUMTELORIGINAL] [varchar](20) NULL
    /// </summary>
    public string? NumeroOriginal { get; set; }

    /// <summary>
    /// [REGTIMESTAMP] [datetime] NULL
    /// </summary>
    public DateTime? DataHoraRegistro { get; set; }

    /// <summary>
    /// [CODAREA] [varchar](10) NULL
    /// </summary>
    public string? CodigoArea { get; set; }

    /// <summary>
    /// [CODORGTEL] [varchar](50) NULL
    /// </summary>
    public OrigemEmail Origem { get; set; }

    /// <summary>
    /// [SCORETELCOBR] [int] NULL
    /// </summary>
    public int? Score { get; set; }

    /// <summary>
    /// CODCHAVEBANCO - varchar(50)
    /// </summary>
    public string? CodigoChaveBanco { get; set; }

    /// <summary>
    /// CODEMPPESQ - int
    /// </summary>
    public int? CodigoFornecedorPesq { get; set; }
}
