namespace Domain.Enums;

/// <summary>
/// TIPOEMAIL - char(1)
/// </summary>
public enum TipoEmail
{
    [Description("P")]
    Pessoal = 1,

    [Description("T")]
    Trabalho = 2,

    [Description("L")]
    Localizacao = 3
}
