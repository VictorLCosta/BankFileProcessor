namespace Domain.Enums;

public enum TipoCombustivel
{
    [Description("N")]
    Nenhum = 0,
    [Description("G")]
    Gasolina = 2,
    [Description("A")]
    Alcool = 1,
    [Description("D")]
    Diesel = 3,
    [Description("GNV")]
    GasVeicular = 4,
    [Description("ND")]
    NaoDeclarado = 5
}
