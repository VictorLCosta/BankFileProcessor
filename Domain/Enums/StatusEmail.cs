namespace Domain.Enums;

/// <summary>
/// STAEMAIL - char(1)
/// </summary>
public enum StatusEmail
{
    [Description("A")]
    Ativo,

    [Description("I")]
    Inativo,

    [Description("C")]
    Cancelado,

    [Description("B")]
    BloqueadoPeloBanco
}
