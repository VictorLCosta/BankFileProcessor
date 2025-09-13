namespace Domain.Entities;

internal class Address : BaseEntity<ContractId>
{
    /// <summary>
    /// CODCPFCNPJCLI - numeric(14,0) - not null
    /// </summary>
    public long CpfCnpj { get; set; }

    private string? _logradouro;
    public string? Logradouro
    {
        get => _logradouro;
        set => _logradouro = value?[..Math.Min(90, value.Length)];
    }

    public int? NumeroLogradouro { get; set; }

    private string? _complemento;
    public string? Complemento
    {
        get => _complemento;
        set => _complemento = value?[..Math.Min(50, value.Length)];
    }

    private string? _bairro;
    public string? Bairro
    {
        get => _bairro;
        set => _bairro = value?[..Math.Min(40, value.Length)];
    }

    private string? _cidade;
    public string? Cidade
    {
        get => _cidade;
        set => _cidade = value?[..Math.Min(40, value.Length)];
    }

    private string? _uf;
    public string? Uf
    {
        get => _uf;
        set => _uf = value?[..Math.Min(2, value.Length)];
    }

    private int _cep;
    public int Cep
    {
        get => _cep;
        set
        {
            var str = value.ToString();
            _cep = str.Length > 8 ? Convert.ToInt32(str[..8]) : value;
        }
    }

    private string? _descricaoReferencia;
    public string? DescricaoReferencia
    {
        get => _descricaoReferencia;
        set => _descricaoReferencia = value?[..Math.Min(50, value.Length)];
    }

    public TipoEndereco TipoEndereco { get; set; }
    public SituacaoEnderecoPrincipal SituacaoEnderecoPrincipal { get; set; }
    public SituacaoEndereco StatusEndereco { get; set; }
    public DateTime DataRemessaArquivo { get; set; }
    public OrigemEmail OrigemEndereco { get; set; }
    public TipoEnderecoCobranca CodigoEnderecoCobranca { get; set; }
    public string? SituacaoBloqCorresp { get; set; }

    private string? _usuarioCadastro;
    public string? UsuarioCadastro
    {
        get => _usuarioCadastro;
        set => _usuarioCadastro = value?[..Math.Min(10, value.Length)];
    }

    public DateTime DataCadastro { get; set; }
    public DateTime? DataRetorno { get; set; }
    public int SituacaoPrioridadeEndereco { get; set; }
    public DateTime DataHoraRegistro { get; set; }
    public string? RegistroTransferido { get; set; }
    public string? Observacao { get; set; }
    public string? UsuarioCancelamento { get; set; }
    public DateTime? DataCancelamento { get; set; }
    public string? UsuarioAlteracao { get; set; }
    public DateTime? DataEnderecoConferido { get; set; }
    public string? SitEnderecoConferido { get; set; }
    public string? CodigoChaveBanco { get; set; }
}
