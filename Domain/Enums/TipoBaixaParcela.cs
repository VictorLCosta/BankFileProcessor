namespace Domain.Enums;

public enum TipoBaixaParcela
{
    [Description("BU")]
    BaixaUsuario = 1,
    [Description("DE")]
    DevolvidoExpiracao = 2,
    [Description("DP")]
    DevolvidoPagamento = 3,
    [Description("DS")]
    DevolvidoSolicitacao = 4,
    [Description("PG")]
    Pago = 5
}
