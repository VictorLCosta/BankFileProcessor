namespace Domain.Entities;

public class Client : BaseChargeEntity
{
    private string _nomeCliente = string.Empty;
    /// <summary>
    /// NOMCLI - varchar(40) - not null
    /// </summary>
    [Column("NOMCLI")]
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
    [Column("CODCPFCNPJCLI")]
    public long CpfCnpj { get; set; }

    /// <summary>
    /// TIPPESSCLI - char(1) - not null
    /// </summary>
    [Column("TIPPESSCLI")]
    public TipoPessoa TipoPessoa { get; set; }

    /// <summary>
    /// CODCLIEMP - varchar(50)
    /// </summary>
    [Column("CODCLIEMP")]
    public string? CodigoClienteEmpresa { get; set; }

    /// <summary>
    /// DATNASCCLI - datetime
    /// </summary>
    [Column("DATNASCCLI")]
    public DateTime? DatNascCliente { get; set; }

    private string? _numRgCliente;
    /// <summary>
    /// NUMRGIDENTCLI - varchar(15)
    /// </summary>
    [Column("NUMRGIDENTCLI")]
    public string? NumRgCliente
    {
        get => _numRgCliente;
        set => _numRgCliente = value?.Substring(0, Math.Min(value.Length, 15));
    }

    private string? _nomeConjCliente;
    /// <summary>
    /// NOMCONJUCLI - varchar(40)
    /// </summary>
    [Column("NOMCONJUCLI")]
    public string? NomeConjCliente
    {
        get => _nomeConjCliente;
        set => _nomeConjCliente = value?.Substring(0, Math.Min(value.Length, 40));
    }

    private string? _filiacaoCliente;
    /// <summary>
    /// FILIACAOCLI - varchar(80)
    /// </summary>
    [Column("FILIACAOCLI")]
    public string? FiliacaoCliente
    {
        get => _filiacaoCliente;
        set => _filiacaoCliente = value?.Substring(0, Math.Min(value.Length, 80));
    }

    private ClientAddress? _enderecoResidencial;
    /// <summary>
    /// Endereço Residencial
    /// </summary>

    public ClientAddress? EnderecoResidencial
    {
        get => _enderecoResidencial;
        set { if (value != null) _enderecoResidencial = value; }
    }

    /// <summary>
    /// NUMTELRESCLI - numeric(15,0) - not null
    /// </summary>
    [Column("NUMTELRESCLI")]
    public long TelefoneResidencial { get; set; }

    /// <summary>
    /// NUMTELCELCLI - numeric(15,0) - not null
    /// </summary>
    [Column("NUMTELCELCLI")]
    public long TelefoneCelular { get; set; }

    private string? _localTrabalho;
    /// <summary>
    /// DCRLOCTRABCLI - varchar(35)
    /// </summary>
    [Column("DCRLOCTRABCLI")]
    public string? LocalTrabalho
    {
        get => _localTrabalho;
        set => _localTrabalho = value?[..Math.Min(value.Length, 35)];
    }

    private ClientAddress? _enderecoComercial;
    /// <summary>
    /// Endereço Comercial
    /// </summary>

    public ClientAddress? EnderecoComercial
    {
        get => _enderecoComercial;
        set { if (value != null) _enderecoComercial = value; }
    }

    /// <summary>
    /// NUMTELCOMCLI - numeric(15,0) - not null
    /// </summary>
    [Column("NUMTELCOMCLI")]
    public long TelefoneComercial { get; set; }

    /// <summary>
    /// NUMFAXCOMCLI - numeric(15,0) - not null
    /// </summary>
    [Column("NUMFAXCOMCLI")]
    public long TelefoneFax { get; set; }

    /// <summary>
    /// CODCORRESPCLI - char(1) - not null
    /// </summary>
    [Column("CODCORRESPCLI")]
    public string CodigoCorrespondenciaCliente { get; set; } = null!;

    private string? _email;
    /// <summary>
    /// ENDEMAILCLI - varchar(120)
    /// </summary>
    [Column("ENDEMAILCLI")]
    public string? Email
    {
        get => _email;
        set => _email = string.IsNullOrEmpty(value) ? null :
                        value.ToLower()[..Math.Min(value.Length, 120)];
    }

    /// <summary>
    /// NOMSOCCLI - varchar(80)
    /// </summary>
    [Column("NOMSOCCLI")]
    public string? NomeSocioCliente { get; set; }

    /// <summary>
    /// NOMCONTCLI - varchar(40)
    /// </summary>
    [Column("NOMCONTCLI")]
    public string? NomeContatoCliente { get; set; }

    /// <summary>
    /// DATCADCLI - datetime
    /// </summary>
    [Column("DATCADCLI")]
    public DateTime? DataCadastroCliente { get; set; }

    /// <summary>
    /// DATREMARQ - datetime
    /// </summary>
    [Column("DATREMARQ")]
    public DateTime DataRemessaArquivo { get; set; }

    /// <summary>
    /// DATATUALREG - datetime
    /// </summary>
    [Column("DATATUALREG")]
    public DateTime DataAtualizacaoRegistro { get; set; }

    /// <summary>
    /// NUMTELCONTCLI - numeric(15,0) - not null
    /// </summary>
    [Column("NUMTELCONTCLI")]
    public long TelefoneContato { get; set; }

    /// <summary>
    /// NUMTELCOBRCLI - numeric(15,0) - not null
    /// </summary>
    [Column("NUMTELCOBRCLI")]
    public long TelefoneCobranca { get; set; }

    private int _ramalTelefoneComercial;
    /// <summary>
    /// NUMRAMTELCOMCLI - numeric(4,0) - not null
    /// </summary>
    [Column("NUMRAMTELCOMCLI")]
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
    [Column("CODFILIAL")]
    public int? CodigoFilial { get; set; }

    /// <summary>
    /// Endereço de Cobrança
    /// </summary>
    public ClientAddress? EnderecoCobranca { get; set; }

    /// <summary>
    /// TIPREGIMECASAMENTO - char(1)
    /// </summary>
    [Column("TIPREGIMECASAMENTO")]
    public char TipoRegimeCasamento { get; set; }

    /// <summary>
    /// TIPSEXOCLI - char(1)
    /// </summary>
    [Column("TIPSEXOCLI")]
    public char Sexo { get; set; }

    /// <summary>
    /// CODESTADOCIVIL - tinyint
    /// </summary>
    [Column("CODESTADOCIVIL")]
    public EstadoCivil? CodigoEstadoCivil { get; set; }

    /// <summary>
    /// REGCKTRANSF - char(1)
    /// </summary>
    [Column("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }
}
