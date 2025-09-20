using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Installment : BaseEntity<ContractId>
{
    [Description("NUMPARC")]
    public int NumeroParcela { get; set; }

    /// <summary>
    /// TIPPARC - numeric(2,0) - not null
    /// </summary>
    [Description("TIPPARC")]
    public TipoParcela TipoParcela { get; set; }

    /// <summary>
    /// SITPARC - numeric(2,0) - not null
    /// </summary>
    [Description("SITPARC")]
    public SituacaoParcela SituacaoParcela { get; set; }

    /// <summary>
    /// DATVCTOPARC - datetime - not null
    /// </summary>
    [Description("DATVCTOPARC")]
    public DateTime DataVencimentoParcela { get; set; }

    /// <summary>
    /// VLRPRINCPARC - numeric(19,6) - not null
    /// </summary>
    [Description("VLRPRINCPARC")]
    public decimal ValorPrincipalParcela { get; set; }

    /// <summary>
    /// VLRMULTAPARC - numeric(19,6) - not null
    /// </summary>
    [Description("VLRMULTAPARC")]
    public decimal ValorMultaParcela { get; set; }

    /// <summary>
    /// VLRCPPARC - numeric(19,6) - not null
    /// </summary>
    [Description("VLRCPPARC")]
    public decimal ValorCpParcela { get; set; }

    /// <summary>
    /// VLRMORAPARC - numeric(19,6) - not null
    /// </summary>
    [Description("VLRMORAPARC")]
    public decimal ValorMoraParcela { get; set; }

    /// <summary>
    /// CODPARC - numeric(10,0) - not null
    /// </summary>
    [Description("CODPARC")]
    public long CodigoParcela { get; set; }

    /// <summary>
    /// NUMDOCPARC - numeric(12,0) - not null
    /// </summary>
    [Description("NUMDOCPARC")]
    public long NumeroDocParcela { get; set; }

    /// <summary>
    /// TIPCADPARC - char(1) - not null
    /// </summary>
    [Description("TIPCADPARC")]
    public TipoCadastroParcela TipoCadastroParcela { get; set; }

    /// <summary>
    /// VLRDESPPARC - numeric(19,6) - not null
    /// </summary>
    [Description("VLRDESPPARC")]
    public decimal ValorDespesaParcela { get; set; }

    /// <summary>
    /// DATREMARQ - datetime
    /// </summary>
    [Description("DATREMARQ")]
    public DateTime DataRemessa { get; set; }

    /// <summary>
    /// NUMLOTPARC - numeric(12,0) - not null
    /// </summary>
    [Description("NUMLOTPARC")]
    public long NumeroLoteParcela { get; set; }

    /// <summary>
    /// DATCHEGBODERPARC - datetime - not null
    /// </summary>
    [Description("DATCHEGBODERPARC")]
    public DateTime DataDirecionamento { get; set; }

    /// <summary>
    /// CODINDFIN - numeric(3,0) - not null
    /// </summary>
    [Description("CODINDFIN")]
    public int CodigoIndiceFinanceiro { get; set; }

    /// <summary>
    /// FASCOBRDIV - numeric(5,0) - not null
    /// </summary>
    [Description("FASCOBRDIV")]
    public int ReguaParcela { get; set; }

    /// <summary>
    /// SITBOLPARC - char(1) - not null
    /// </summary>
    [Description("SITBOLPARC")]
    public SituacaoBoletoParcela SituacaoBoletoParcela { get; set; }

    /// <summary>
    /// SITBLOQPARC - char(1) - not null
    /// </summary>
    [Description("SITBLOQPARC")]
    public SituacaoParcelaBloqueada SituacaoParcelaBloqueada { get; set; }

    /// <summary>
    /// PERCVENCPARC - numeric(9,6) - not null
    /// </summary>
    [Description("PERCVENCPARC")]
    public decimal PercentualVencimentoParcela { get; set; }

    /// <summary>
    /// DATVCTORGPARC - datetime
    /// </summary>
    [Description("DATVCTORGPARC")]
    public DateTime? DataEnquadramento { get; set; }

    /// <summary>
    /// SITFORVCTOPARC - char(1) - not null
    /// </summary>
    [Description("SITFORVCTOPARC")]
    public SituacaoCalculoVencimento SituacaoCalculoVencimento { get; set; }

    /// <summary>
    /// TIPBXPARC - char(2)
    /// </summary>
    [Description("TIPBXPARC")]
    public TipoBaixaParcela TipoBaixa { get; set; }

    /// <summary>
    /// DATBXPARC - datetime
    /// </summary>
    [Description("DATBXPARC")]
    public DateTime? DataBaixa { get; set; }

    /// <summary>
    /// DATPGTOPARC - datetime
    /// </summary>
    [Description("DATPGTOPARC")]
    public DateTime? DataPagamento { get; set; }

    /// <summary>
    /// DATDEVPARC - datetime
    /// </summary>
    [Description("DATDEVPARC")]
    public DateTime? DataDevolucao { get; set; }

    /// <summary>
    /// SLDPARC - money
    /// </summary>
    [Description("SLDPARC")]
    public decimal SaldoParcela { get; set; }

    /// <summary>
    /// TIPMOEDAPARC - varchar(50)
    /// </summary>
    [Description("TIPMOEDAPARC")]
    public string? TipoMoeda
    {
        get
        {
            return _tipoMoeda;
        }
        set
        {
            _tipoMoeda = Strings.Left(value, 50);
        }
    }
    private string? _tipoMoeda;

    /// <summary>
    /// TIPAPPLPARC  - varchar(5)
    /// </summary>
    [Description("TIPAPPLPARC")]
    public string? TipoAplicacaoParcela
    {
        get
        {
            return _tipoAplicacaoParcela;
        }
        set
        {
            _tipoAplicacaoParcela = Strings.Left(value, 5);
        }
    }
    private string? _tipoAplicacaoParcela;

    /// <summary>
    /// DATATUALREG - datetime
    /// </summary>
    [Description("DATATUALREG")]
    public DateTime DataAtualizacaoRegistro { get; set; }

    /// <summary>
    /// DATCADPARC - datetime
    /// </summary>
    [Description("DATCADPARC")]
    public DateTime DataCadastro { get; set; }

    /// <summary>
    /// NUMPARCORIGINAL  - NUMERIC(3, 0)
    /// </summary>
    /// <value></value>
    [Description("NUMPARCORIGINAL")]
    public int? NumeroParcelaOriginal { get; set; }

    /// <summary>
    /// DATNOTIFPARC
    /// </summary>
    [Description("DATNOTIFPARC")]
    public DateTime? DataNotificacaoParcela { get; set; }

    /// <summary>
    /// CODFASCONTBPARC
    /// </summary>
    [Description("CODFASCONTBPARC")]
    public string? CodigoFaseContratoParcela { get; set; }

    /// <summary>
    /// SITCONTRAJUIZ
    /// </summary>
    [Description("SITCONTRAJUIZ")]
    public string? SituacaoContratoAjuizado { get; set; }

    /// <summary>
    /// SCOREDIVCOBR
    /// </summary>
    [Description("SCOREDIVCOBR")]
    public long ScoreDivida { get; set; }

    /// <summary>
    /// REGTIMESTAMP - datetime
    /// </summary>
    [Description("REGTIMESTAMP")]
    public DateTime DataHoraRegistro { get; set; }

    /// <summary>
    /// REGCKTRANSF - char(1)
    /// </summary>
    [Description("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }
}
