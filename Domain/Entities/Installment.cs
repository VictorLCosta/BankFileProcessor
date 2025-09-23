using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Installment : BaseEntity<ContractId>
{
    [Column("NUMPARC")]
    public int NumeroParcela { get; set; }

    /// <summary>
    /// TIPPARC - numeric(2,0) - not null
    /// </summary>
    [Column("TIPPARC")]
    public TipoParcela TipoParcela { get; set; }

    /// <summary>
    /// SITPARC - numeric(2,0) - not null
    /// </summary>
    [Column("SITPARC")]
    public SituacaoParcela SituacaoParcela { get; set; }

    /// <summary>
    /// DATVCTOPARC - datetime - not null
    /// </summary>
    [Column("DATVCTOPARC")]
    public DateTime DataVencimentoParcela { get; set; }

    /// <summary>
    /// VLRPRINCPARC - numeric(19,6) - not null
    /// </summary>
    [Column("VLRPRINCPARC")]
    public decimal ValorPrincipalParcela { get; set; }

    /// <summary>
    /// VLRMULTAPARC - numeric(19,6) - not null
    /// </summary>
    [Column("VLRMULTAPARC")]
    public decimal ValorMultaParcela { get; set; }

    /// <summary>
    /// VLRCPPARC - numeric(19,6) - not null
    /// </summary>
    [Column("VLRCPPARC")]
    public decimal ValorCpParcela { get; set; }

    /// <summary>
    /// VLRMORAPARC - numeric(19,6) - not null
    /// </summary>
    [Column("VLRMORAPARC")]
    public decimal ValorMoraParcela { get; set; }

    /// <summary>
    /// CODPARC - numeric(10,0) - not null
    /// </summary>
    [Column("CODPARC")]
    public long CodigoParcela { get; set; }

    /// <summary>
    /// NUMDOCPARC - numeric(12,0) - not null
    /// </summary>
    [Column("NUMDOCPARC")]
    public long NumeroDocParcela { get; set; }

    /// <summary>
    /// TIPCADPARC - char(1) - not null
    /// </summary>
    [Column("TIPCADPARC")]
    public TipoCadastroParcela TipoCadastroParcela { get; set; }

    /// <summary>
    /// VLRDESPPARC - numeric(19,6) - not null
    /// </summary>
    [Column("VLRDESPPARC")]
    public decimal ValorDespesaParcela { get; set; }

    /// <summary>
    /// DATREMARQ - datetime
    /// </summary>
    [Column("DATREMARQ")]
    public DateTime DataRemessa { get; set; }

    /// <summary>
    /// NUMLOTPARC - numeric(12,0) - not null
    /// </summary>
    [Column("NUMLOTPARC")]
    public long NumeroLoteParcela { get; set; }

    /// <summary>
    /// DATCHEGBODERPARC - datetime - not null
    /// </summary>
    [Column("DATCHEGBODERPARC")]
    public DateTime DataDirecionamento { get; set; }

    /// <summary>
    /// CODINDFIN - numeric(3,0) - not null
    /// </summary>
    [Column("CODINDFIN")]
    public int CodigoIndiceFinanceiro { get; set; }

    /// <summary>
    /// FASCOBRDIV - numeric(5,0) - not null
    /// </summary>
    [Column("FASCOBRDIV")]
    public int ReguaParcela { get; set; }

    /// <summary>
    /// SITBOLPARC - char(1) - not null
    /// </summary>
    [Column("SITBOLPARC")]
    public SituacaoBoletoParcela SituacaoBoletoParcela { get; set; }

    /// <summary>
    /// SITBLOQPARC - char(1) - not null
    /// </summary>
    [Column("SITBLOQPARC")]
    public SituacaoParcelaBloqueada SituacaoParcelaBloqueada { get; set; }

    /// <summary>
    /// PERCVENCPARC - numeric(9,6) - not null
    /// </summary>
    [Column("PERCVENCPARC")]
    public decimal PercentualVencimentoParcela { get; set; }

    /// <summary>
    /// DATVCTORGPARC - datetime
    /// </summary>
    [Column("DATVCTORGPARC")]
    public DateTime? DataEnquadramento { get; set; }

    /// <summary>
    /// SITFORVCTOPARC - char(1) - not null
    /// </summary>
    [Column("SITFORVCTOPARC")]
    public SituacaoCalculoVencimento SituacaoCalculoVencimento { get; set; }

    /// <summary>
    /// TIPBXPARC - char(2)
    /// </summary>
    [Column("TIPBXPARC")]
    public TipoBaixaParcela TipoBaixa { get; set; }

    /// <summary>
    /// DATBXPARC - datetime
    /// </summary>
    [Column("DATBXPARC")]
    public DateTime? DataBaixa { get; set; }

    /// <summary>
    /// DATPGTOPARC - datetime
    /// </summary>
    [Column("DATPGTOPARC")]
    public DateTime? DataPagamento { get; set; }

    /// <summary>
    /// DATDEVPARC - datetime
    /// </summary>
    [Column("DATDEVPARC")]
    public DateTime? DataDevolucao { get; set; }

    /// <summary>
    /// SLDPARC - money
    /// </summary>
    [Column("SLDPARC")]
    public decimal SaldoParcela { get; set; }

    /// <summary>
    /// TIPMOEDAPARC - varchar(50)
    /// </summary>
    [Column("TIPMOEDAPARC")]
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
    [Column("TIPAPPLPARC")]
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
    [Column("DATATUALREG")]
    public DateTime DataAtualizacaoRegistro { get; set; }

    /// <summary>
    /// DATCADPARC - datetime
    /// </summary>
    [Column("DATCADPARC")]
    public DateTime DataCadastro { get; set; }

    /// <summary>
    /// NUMPARCORIGINAL  - NUMERIC(3, 0)
    /// </summary>
    /// <value></value>
    [Column("NUMPARCORIGINAL")]
    public int? NumeroParcelaOriginal { get; set; }

    /// <summary>
    /// DATNOTIFPARC
    /// </summary>
    [Column("DATNOTIFPARC")]
    public DateTime? DataNotificacaoParcela { get; set; }

    /// <summary>
    /// CODFASCONTBPARC
    /// </summary>
    [Column("CODFASCONTBPARC")]
    public string? CodigoFaseContratoParcela { get; set; }

    /// <summary>
    /// SITCONTRAJUIZ
    /// </summary>
    [Column("SITCONTRAJUIZ")]
    public string? SituacaoContratoAjuizado { get; set; }

    /// <summary>
    /// SCOREDIVCOBR
    /// </summary>
    [Column("SCOREDIVCOBR")]
    public long ScoreDivida { get; set; }

    /// <summary>
    /// REGTIMESTAMP - datetime
    /// </summary>
    [Column("REGTIMESTAMP")]
    public DateTime DataHoraRegistro { get; set; }

    /// <summary>
    /// REGCKTRANSF - char(1)
    /// </summary>
    [Column("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }
}
