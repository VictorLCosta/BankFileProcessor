namespace Domain.Entities;

public class Debt : BaseEntity<ContractId>
{

    [Description("CODFILIAL")]
    public int CodigoFilial { get; set; }

    [Description("DATCHEGBODERDIV")]
    public DateTime DataDirecionamentoContrato { get; set; }

    [Description("DATDEVDIV")]
    public DateTime? DataDevolucaoDivida { get; set; }

    [Description("CODINDFIN")]
    public CodigoIndiceFinanceiro CodigoIndiceFinanceiro { get; set; }

    [Description("NUMPARCPLANODIV")]
    public int NumParcPlanoDivida { get; set; }

    [Description("VLRSALDHISTPLDIV")]
    public decimal ValorSaldoDivida { get; set; }

    [Description("VLRCPDIARIADIV")]
    public decimal ValorDiaria { get; set; }

    [Description("TAXFINCONTRDIV")]
    public decimal TaxaFinanciamentoContrato { get; set; }

    [Description("CODAGENCIADIV")]
    public string? CodigoAgencia { get; set; }

    [Description("STAFASECOBRDIV")]
    public string FaseDivida { get; set; } = string.Empty;

    private string? _nomeConcAgenDiv;
    [Description("NOMCONCAGENDIV")]
    public string? NomeConcAgenDiv
    {
        get => _nomeConcAgenDiv;
        set => _nomeConcAgenDiv = value?.Substring(0, Math.Min(35, value.Length));
    }

    [Description("NUMCARTCOBDIV")]
    public long NumeroCarteiraCobranca { get; set; }

    private string? _codigoProduto;
    [Description("CODPRODCONTRDIV")]
    public string? CodigoProduto
    {
        get => _codigoProduto;
        set => _codigoProduto = value?.Substring(0, Math.Min(10, value.Length));
    }

    private string? _descricaoProduto;
    [Description("DCRPRODCONTRDIV")]
    public string? DescricaoProduto
    {
        get => _descricaoProduto;
        set => _descricaoProduto = value?.Substring(0, Math.Min(40, value.Length));
    }

    private string? _descricaoSeguroProtecao;
    [Description("DCRSEGPROTDIV")]
    public string? DescricaoSeguroProtecao
    {
        get => _descricaoSeguroProtecao;
        set => _descricaoSeguroProtecao = value?.Substring(0, Math.Min(35, value.Length));
    }

    private string? _infComplDivida;
    [Description("INFCOMPLDIV")]
    public string? InfComplDivida
    {
        get => _infComplDivida;
        set => _infComplDivida = value?[..Math.Min(250, value.Length)];
    }

    [Description("SITDIVCOB")]
    public SituacaoDividaCobranca SituacaoDividaCobranca { get; set; }

    [Description("SITCONTRDIVADV")]
    public SituacaoContratoAdversa SituacaoContratoAdversa { get; set; }

    [Description("SITCOBDIV")]
    public OrigemCobrancaDivida OrigemCobrancaDivida { get; set; }

    [Description("CODCAMPANHA")]
    public int CodigoCampanha { get; set; }

    [Description("CODSCRIPTCOB")]
    public int? CodigoScriptCobranca { get; set; }

    [Description("CODUSERID")]
    public string? CodigoUsuario { get; set; }

    [Description("DATULTCOBDIV")]
    public DateTime? DataUltimaCobranca { get; set; }

    [Description("DATAGENCOBR")]
    public DateTime? DataAgendamentoCobranca { get; set; }

    [Description("SITACERTDIV")]
    public string? SituacaoAcertoDivida { get; set; } = string.Empty;

    [Description("DATCADDIV")]
    public DateTime DataCadastroDivida { get; set; }

    [Description("DATREMARQ")]
    public DateTime DataRemessa { get; set; }

    [Description("DATATUALREG")]
    public DateTime? DataAtualizacaoRegistro { get; set; }

    [Description("SITREFCONTRDIV")]
    public string? SitReferenciaContrato { get; set; } = string.Empty;

    [Description("TIPCONTR")]
    public string? TipoContrato { get; set; }

    [Description("DATCONTRDIV")]
    public DateTime? DatContrDivida { get; set; }

    [Description("DATENQRDIV")]
    public DateTime? DataEnquadramento { get; set; }

    [Description("TIPCOBRDIV")]
    public string? TipoCobranca { get; set; }

    [Description("DATPERFCOBRDIV")]
    public DateTime? DataPerformance { get; set; }

    [Description("FASCOBRDIV")]
    public int ReguaCobranca { get; set; }

    [Description("SITCONTRDIVTERC")]
    public string? SitContratoDividaTerceiro { get; set; }

    [Description("SITBLOQAJUIZ")]
    public string? SituacaoBloqueioAjuizamento { get; set; }

    [Description("CODCLASSPDDDIV")]
    public string CodigoClassificacaoPdd { get; set; } = string.Empty;

    [Description("CODCARTCOBR")]
    public string? CodigoCarteiraCobranca { get; set; }

    [Description("VLRRISCOCONTRDIV")]
    public decimal? ValorRiscoContrato { get; set; }

    [Description("VLRPERCPLPG")]
    public decimal? ValorPercentualPlanoPag { get; set; }

    [Description("CODINSTRCOBR")]
    public long? CodigoInstrucaoCobranca { get; set; }

    [Description("CODAREACOBRDIV")]
    public int? CodigoAreaCobranca { get; set; }

    [Description("CODFASECOBRDIV")]
    public int? CodigoFaseCobranca { get; set; }

    private string? _tipoOperacaoContrato;
    [Description("TIPOPRCONTRDIV")]
    public string? TipoOperacaoContrato
    {
        get => _tipoOperacaoContrato;
        set => _tipoOperacaoContrato = value?[..Math.Min(50, value.Length)];
    }

    [Description("CODMOTIVINAD")]
    public short? CodigoMotivoInadimplencia { get; set; }

    private string? _tipoOperacaoCobranca;
    [Description("TIPOPRCOBR")]
    public string? TipoOperacaoCobranca
    {
        get => _tipoOperacaoCobranca;
        set => _tipoOperacaoCobranca = value?[..Math.Min(15, value.Length)];
    }

    [Description("CODDIALING")]
    public long? CodigoDialing { get; set; }

    [Description("TIPVINCCONTRDIV")]
    public string? TipoVinculoContrato { get; set; }

    [Description("NUMCONTRDIVVINC")]
    public string? NumeroContratoVinculado { get; set; }

    [Description("QTDVINCCONTRDIV")]
    public short? QuantidadeContratoVinculado { get; set; }

    [Description("STATELHIGCONTRDIV")]
    public string? StatusTelefoneHigienizado { get; set; }

    [Description("NUMCONTRCOBDIV")]
    public long NumeroContratoCobranca { get; set; }

    [Description("TIPODIVIDA")]
    public char TipoDivida { get; set; }

    [Description("CODESTRATEG")]
    public int? CodigoEstrategia { get; set; }

    [Description("SCOREDIVCOBR")]
    public long? ScoreDivida { get; set; }

    [Description("SITINFBXPASTABCO")]
    public string? SitInfoBaixaPastaBanco { get; set; }

    [Description("CODEMPRECOLG")]
    public CodigoColigada? CodigoColigada { get; set; }

    [Description("SITRECLSAC")]
    public string? SituacaoReclamacaoSac { get; set; }

    [Description("SCORECONTR")]
    public string? ScoreContratante { get; set; }

    [Description("REGTIMESTAMP")]
    public DateTime DataHoraRegistro { get; set; }

    [Description("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }
}