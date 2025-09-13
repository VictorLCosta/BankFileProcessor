namespace Domain.Enums;

public enum SituacaoParcela
{
    [Description("EmCobranca")]
    EmCobranca = 1,
    [Description("Quitada")]
    Quitada = 2,
    [Description("Acordo")]
    Acordo = 3,
    [Description("AguardandoPrestacaoContas")]
    AguardandoPrestacaoContas = 4,
    [Description("Refinanciamento")]
    Refinanciamento = 5,
    [Description("Devolvida")]
    Devolvida = 6
}

