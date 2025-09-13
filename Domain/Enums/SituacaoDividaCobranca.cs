namespace Domain.Enums;

public enum SituacaoDividaCobranca
{
    [Description("Em Cobrança")]
    EmCobranca = 1,
    [Description("Entrega Amigável")]
    EntregaAmigavel = 2,
    [Description("Cobrança Jurídica Encerrada")]
    CobrancaJuridicaEncerrada = 3,
    [Description("Cobrança Cancelada")]
    CobrancaCancelada = 4,
    [Description("Cobrança Paralisada")]
    CobrancaParalisada = 5,
    [Description("Cobrança Infrutífera")]
    CobrancaInfrutifera = 6,
    [Description("Cobrança Devolvida")]
    CobrancaDevolvida = 7,
    [Description("Cobrança Encerrada")]
    CobrancaEncerrada = 8,
    [Description("Ajuizado Outra Assessoria")]
    AjuizadoOutraAssessoria = 9
}