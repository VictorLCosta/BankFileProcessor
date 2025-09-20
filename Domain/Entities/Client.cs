namespace Domain.Entities;

public class Client : BaseEntity<ContractId>
{
    private string _nomeCliente = string.Empty;
    /// <summary>
    /// NOMCLI - varchar(40) - not null
    /// </summary>
    [Description("NOMCLI")]
    public string NomeCliente
    {
        get => _nomeCliente;
        set
        {
            if (value != null)
            {
                _nomeCliente = value.Replace("&", "e")
                                    .Replace("'", "")
                                    .Replace("\"", "");
                if (_nomeCliente.Length > 40)
                    _nomeCliente = _nomeCliente.Substring(0, 40);
                _nomeCliente = _nomeCliente.ToUpper();
                // Funcoes.LimparCaracteresEspeciais(_nomeCliente);
            }
        }
    }

    /// <summary>
    /// CODCPFCNPJCLI - numeric(14,0) - not null
    /// </summary>
    [Description("CODCPFCNPJCLI")]
    public long CpfCnpj { get; set; }

    /// <summary>
    /// TIPPESSCLI - char(1) - not null
    /// </summary>
    [Description("TIPPESSCLI")]
    public TipoPessoa TipoPessoa { get; set; }

    /// <summary>
    /// CODCLIEMP - varchar(50)
    /// </summary>
    [Description("CODCLIEMP")]
    public string? CodigoClienteEmpresa { get; set; }

    /// <summary>
    /// DATNASCCLI - datetime
    /// </summary>
    [Description("DATNASCCLI")]
    public DateTime? DatNascCliente { get; set; }

    private string? _numRgCliente;
    /// <summary>
    /// NUMRGIDENTCLI - varchar(15)
    /// </summary>
    [Description("NUMRGIDENTCLI")]
    public string? NumRgCliente
    {
        get => _numRgCliente;
        set => _numRgCliente = value?.Substring(0, Math.Min(value.Length, 15));
    }

    private string? _nomeConjCliente;
    /// <summary>
    /// NOMCONJUCLI - varchar(40)
    /// </summary>
    [Description("NOMCONJUCLI")]
    public string? NomeConjCliente
    {
        get => _nomeConjCliente;
        set => _nomeConjCliente = value?.Substring(0, Math.Min(value.Length, 40));
    }

    private string? _filiacaoCliente;
    /// <summary>
    /// FILIACAOCLI - varchar(80)
    /// </summary>
    [Description("FILIACAOCLI")]
    public string? FiliacaoCliente
    {
        get => _filiacaoCliente;
        set => _filiacaoCliente = value?.Substring(0, Math.Min(value.Length, 80));
    }

    private Address? _enderecoResidencial;
    /// <summary>
    /// Endereço Residencial
    /// </summary>

    public Address? EnderecoResidencial
    {
        get => _enderecoResidencial;
        set { if (value != null) _enderecoResidencial = value; }
    }

    /// <summary>
    /// NUMTELRESCLI - numeric(15,0) - not null
    /// </summary>
    [Description("NUMTELRESCLI")]
    public long TelefoneResidencial { get; set; }

    /// <summary>
    /// NUMTELCELCLI - numeric(15,0) - not null
    /// </summary>
    [Description("NUMTELCELCLI")]
    public long TelefoneCelular { get; set; }

    private string? _localTrabalho;
    /// <summary>
    /// DCRLOCTRABCLI - varchar(35)
    /// </summary>
    [Description("DCRLOCTRABCLI")]
    public string? LocalTrabalho
    {
        get => _localTrabalho;
        set => _localTrabalho = value?.Substring(0, Math.Min(value.Length, 35));
    }

    private Address? _enderecoComercial;
    /// <summary>
    /// Endereço Comercial
    /// </summary>

    public Address? EnderecoComercial
    {
        get => _enderecoComercial;
        set { if (value != null) _enderecoComercial = value; }
    }

    /// <summary>
    /// NUMTELCOMCLI - numeric(15,0) - not null
    /// </summary>
    [Description("NUMTELCOMCLI")]
    public long TelefoneComercial { get; set; }

    /// <summary>
    /// NUMFAXCOMCLI - numeric(15,0) - not null
    /// </summary>
    [Description("NUMFAXCOMCLI")]
    public long TelefoneFax { get; set; }

    /// <summary>
    /// CODCORRESPCLI - char(1) - not null
    /// </summary>
    [Description("CODCORRESPCLI")]
    public string CodigoCorrespondenciaCliente { get; set; } = null!;

    private string? _email;
    /// <summary>
    /// ENDEMAILCLI - varchar(120)
    /// </summary>
    [Description("ENDEMAILCLI")]
    public string? Email
    {
        get => _email;
        set => _email = string.IsNullOrEmpty(value) ? null :
                        value.ToLower().Substring(0, Math.Min(value.Length, 120));
    }

    /// <summary>
    /// NOMSOCCLI - varchar(80)
    /// </summary>
    [Description("NOMSOCCLI")]
    public string? NomeSocioCliente { get; set; }

    /// <summary>
    /// NOMCONTCLI - varchar(40)
    /// </summary>
    [Description("NOMCONTCLI")]
    public string? NomeContatoCliente { get; set; }

    /// <summary>
    /// DATCADCLI - datetime
    /// </summary>
    [Description("DATCADCLI")]
    public DateTime? DataCadastroCliente { get; set; }

    /// <summary>
    /// DATREMARQ - datetime
    /// </summary>
    [Description("DATREMARQ")]
    public DateTime DataRemessaArquivo { get; set; }

    /// <summary>
    /// DATATUALREG - datetime
    /// </summary>
    [Description("DATATUALREG")]
    public DateTime DataAtualizacaoRegistro { get; set; }

    /// <summary>
    /// NUMTELCONTCLI - numeric(15,0) - not null
    /// </summary>
    [Description("NUMTELCONTCLI")]
    public long TelefoneContato { get; set; }

    /// <summary>
    /// NUMTELCOBRCLI - numeric(15,0) - not null
    /// </summary>
    [Description("NUMTELCOBRCLI")]
    public long TelefoneCobranca { get; set; }

    private int _ramalTelefoneComercial;
    /// <summary>
    /// NUMRAMTELCOMCLI - numeric(4,0) - not null
    /// </summary>
    [Description("NUMRAMTELCOMCLI")]
    public int RamalTelefoneComercial
    {
        get => _ramalTelefoneComercial;
        set
        {
            var text = value.ToString();
            if (text.Length > 4)
                text = text.Substring(0, 4);
            _ramalTelefoneComercial = Convert.ToInt32(text);
        }
    }

    /// <summary>
    /// Filial - CODFILIAL
    /// </summary>
    [Description("CODFILIAL")]
    public int? CodigoFilial { get; set; }

    /// <summary>
    /// Endereço de Cobrança
    /// </summary>
    public Address EnderecoCobranca { get; set; }

    /// <summary>
    /// TIPREGIMECASAMENTO - char(1)
    /// </summary>
    [Description("TIPREGIMECASAMENTO")]
    public char TipoRegimeCasamento { get; set; }

    /// <summary>
    /// TIPSEXOCLI - char(1)
    /// </summary>
    [Description("TIPSEXOCLI")]
    public char Sexo { get; set; }

    /// <summary>
    /// CODESTADOCIVIL - tinyint
    /// </summary>
    [Description("CODESTADOCIVIL")]
    public EstadoCivil? CodigoEstadoCivil { get; set; }

    /// <summary>
    /// REGTIMESTAMP - datetime
    /// </summary>
    [Description("REGTIMESTAMP")]
    public DateTime DataHoraRegistro { get; set; }

    /// <summary>
    /// REGCKTRANSF - char(1)
    /// </summary>
    [Description("REGCKTRANSF")]
    public string RegistroTransferido { get; set; }
}
