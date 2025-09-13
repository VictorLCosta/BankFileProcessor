namespace Domain.Enums;

public enum TipoTelefone
{
    [Description("CRES")]
    ResidencialCliente = 1,
    [Description("CCEL")]
    CelularCliente = 2,
    [Description("CCOM")]
    ComercialCliente = 3,
    [Description("COUT")]
    OutrosCliente = 4,
    [Description("CFAX")]
    FaxCliente = 5,
    [Description("CREF")]
    ReferenciaCliente = 6,
    [Description("ACEL")]
    CelularAvalista = 7,
    [Description("ACOM")]
    ComercialAvalista = 8,
    [Description("ARES")]
    ResidencialAvalista = 9,
    [Description("TRES")]
    ResidencialTerceiros = 10,
    [Description("TCOM")]
    ComercialTerceiros = 11,
    [Description("TCEL")]
    CelularTerceiros = 12,
    [Description("TOUT")]
    OutrosTerceiros = 13,
    [Description("PESQ")]
    Pesquisa = 14,
    [Description("RTEL")]
    TelefoneReferencia = 15,
    [Description("AFAX")]
    FaxAvalista = 16,
    [Description("TFAX")]
    FaxTerceiros = 17
}