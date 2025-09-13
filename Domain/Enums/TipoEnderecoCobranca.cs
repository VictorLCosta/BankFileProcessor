namespace Domain.Enums;

public enum TipoEnderecoCobranca
{
    [Description("CRES")]
    ResidencialCliente = 1,
    [Description("CCOM")]
    ComercialCliente = 2,
    [Description("CCOB")]
    CobrancaCliente = 3,
    [Description("CCOR")]
    CorrespondenciaCliente = 4,
    [Description("PESQ")]
    Pesquisa = 5,
    [Description("COUT")]
    OutrosCliente = 6,
    [Description("ACOM")]
    ComercialAvalista = 7,
    [Description("ARES")]
    ResidencialAvalista = 8
}
