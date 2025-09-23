namespace Domain.Entities;

public class Debt : BaseEntity<ContractId>
{

    [Column("CODFILIAL")]
    public int CodigoFilial { get; set; }

    [Column("DATCHEGBODERDIV")]
    public DateTime DataDirecionamentoContrato { get; set; }

    [Column("DATDEVDIV")]
    public DateTime? DataDevolucaoDivida { get; set; }

    [Column("CODINDFIN")]
    public CodigoIndiceFinanceiro CodigoIndiceFinanceiro { get; set; }

    [Column("NUMPARCPLANODIV")]
    public int NumParcPlanoDivida { get; set; }

    [Column("VLRSALDHISTPLDIV")]
    public decimal ValorSaldoDivida { get; set; }

    [Column("VLRCPDIARIADIV")]
    public decimal ValorDiaria { get; set; }

    [Column("TAXFINCONTRDIV")]
    public decimal TaxaFinanciamentoContrato { get; set; }

    [Column("CODAGENCIADIV")]
    public string? CodigoAgencia { get; set; }

    [Column("STAFASECOBRDIV")]
    public string FaseDivida { get; set; } = string.Empty;

    private string? _nomeConcAgenDiv;
    [Column("NOMCONCAGENDIV")]
    public string? NomeConcAgenDiv
    {
        get => _nomeConcAgenDiv;
        set => _nomeConcAgenDiv = value?.Substring(0, Math.Min(35, value.Length));
    }

    [Column("NUMCARTCOBDIV")]
    public long NumeroCarteiraCobranca { get; set; }

    private string? _codigoProduto;
    [Column("CODPRODCONTRDIV")]
    public string? CodigoProduto
    {
        get => _codigoProduto;
        set => _codigoProduto = value?.Substring(0, Math.Min(10, value.Length));
    }

    private string? _descricaoProduto;
    [Column("DCRPRODCONTRDIV")]
    public string? DescricaoProduto
    {
        get => _descricaoProduto;
        set => _descricaoProduto = value?.Substring(0, Math.Min(40, value.Length));
    }

    private string? _descricaoSeguroProtecao;
    [Column("DCRSEGPROTDIV")]
    public string? DescricaoSeguroProtecao
    {
        get => _descricaoSeguroProtecao;
        set => _descricaoSeguroProtecao = value?.Substring(0, Math.Min(35, value.Length));
    }

    private string? _infComplDivida;
    [Column("INFCOMPLDIV")]
    public string? InfComplDivida
    {
        get => _infComplDivida;
        set => _infComplDivida = value?[..Math.Min(250, value.Length)];
    }

    [Column("SITDIVCOB")]
    public SituacaoDividaCobranca SituacaoDividaCobranca { get; set; }

    [Column("SITCONTRDIVADV")]
    public SituacaoContratoAdversa SituacaoContratoAdversa { get; set; }

    [Column("SITCOBDIV")]
    public OrigemCobrancaDivida OrigemCobrancaDivida { get; set; }

    [Column("CODCAMPANHA")]
    public int CodigoCampanha { get; set; }

    [Column("CODSCRIPTCOB")]
    public int? CodigoScriptCobranca { get; set; }

    [Column("CODUSERID")]
    public string? CodigoUsuario { get; set; }

    [Column("DATULTCOBDIV")]
    public DateTime? DataUltimaCobranca { get; set; }

    [Column("DATAGENCOBR")]
    public DateTime? DataAgendamentoCobranca { get; set; }

    [Column("SITACERTDIV")]
    public string? SituacaoAcertoDivida { get; set; } = string.Empty;

    [Column("DATCADDIV")]
    public DateTime DataCadastroDivida { get; set; }

    [Column("DATREMARQ")]
    public DateTime DataRemessa { get; set; }

    [Column("DATATUALREG")]
    public DateTime? DataAtualizacaoRegistro { get; set; }

    [Column("SITREFCONTRDIV")]
    public string? SitReferenciaContrato { get; set; } = string.Empty;

    [Column("TIPCONTR")]
    public string? TipoContrato { get; set; }

    [Column("DATCONTRDIV")]
    public DateTime? DatContrDivida { get; set; }

    [Column("DATENQRDIV")]
    public DateTime? DataEnquadramento { get; set; }

    [Column("TIPCOBRDIV")]
    public string? TipoCobranca { get; set; }

    [Column("DATPERFCOBRDIV")]
    public DateTime? DataPerformance { get; set; }

    [Column("FASCOBRDIV")]
    public int ReguaCobranca { get; set; }

    [Column("SITCONTRDIVTERC")]
    public string? SitContratoDividaTerceiro { get; set; }

    [Column("SITBLOQAJUIZ")]
    public string? SituacaoBloqueioAjuizamento { get; set; }

    [Column("CODCLASSPDDDIV")]
    public string CodigoClassificacaoPdd { get; set; } = string.Empty;

    [Column("CODCARTCOBR")]
    public string? CodigoCarteiraCobranca { get; set; }

    [Column("VLRRISCOCONTRDIV")]
    public decimal? ValorRiscoContrato { get; set; }

    [Column("VLRPERCPLPG")]
    public decimal? ValorPercentualPlanoPag { get; set; }

    [Column("CODINSTRCOBR")]
    public long? CodigoInstrucaoCobranca { get; set; }

    [Column("CODAREACOBRDIV")]
    public int? CodigoAreaCobranca { get; set; }

    [Column("CODFASECOBRDIV")]
    public int? CodigoFaseCobranca { get; set; }

    private string? _tipoOperacaoContrato;
    [Column("TIPOPRCONTRDIV")]
    public string? TipoOperacaoContrato
    {
        get => _tipoOperacaoContrato;
        set => _tipoOperacaoContrato = value?[..Math.Min(50, value.Length)];
    }

    [Column("CODMOTIVINAD")]
    public short? CodigoMotivoInadimplencia { get; set; }

    private string? _tipoOperacaoCobranca;
    [Column("TIPOPRCOBR")]
    public string? TipoOperacaoCobranca
    {
        get => _tipoOperacaoCobranca;
        set => _tipoOperacaoCobranca = value?[..Math.Min(15, value.Length)];
    }

    [Column("CODDIALING")]
    public long? CodigoDialing { get; set; }

    [Column("TIPVINCCONTRDIV")]
    public string? TipoVinculoContrato { get; set; }

    [Column("NUMCONTRDIVVINC")]
    public string? NumeroContratoVinculado { get; set; }

    [Column("QTDVINCCONTRDIV")]
    public short? QuantidadeContratoVinculado { get; set; }

    [Column("STATELHIGCONTRDIV")]
    public string? StatusTelefoneHigienizado { get; set; }

    [Column("NUMCONTRCOBDIV")]
    public long NumeroContratoCobranca { get; set; }

    [Column("TIPODIVIDA")]
    public char TipoDivida { get; set; }

    [Column("CODESTRATEG")]
    public int? CodigoEstrategia { get; set; }

    [Column("SCOREDIVCOBR")]
    public long? ScoreDivida { get; set; }

    [Column("SITINFBXPASTABCO")]
    public string? SitInfoBaixaPastaBanco { get; set; }

    [Column("CODEMPRECOLG")]
    public CodigoColigada? CodigoColigada { get; set; }

    [Column("SITRECLSAC")]
    public string? SituacaoReclamacaoSac { get; set; }

    [Column("SCORECONTR")]
    public string? ScoreContratante { get; set; }

    [Column("REGTIMESTAMP")]
    public DateTime DataHoraRegistro { get; set; }

    [Column("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }
}