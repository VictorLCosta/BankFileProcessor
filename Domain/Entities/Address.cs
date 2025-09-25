namespace Domain.Entities;

public class Address : BaseEntity<ContractId>
{
    /// <summary>
    /// CODCPFCNPJCLI - numeric(14,0) - not null
    /// </summary>
    [Column("CODCPFCNPJCLI")]
    public long CpfCnpj { get; set; }

    [Column("DCRENDCLI")]
    public string? Logradouro
    {
        get => _logradouro;
        set => _logradouro = value?[..Math.Min(90, value.Length)];
    }
    private string? _logradouro;

    [Column("NUMENDCLI")]
    public int? NumeroLogradouro { get; set; }

    [Column("DCRCOMPLEMENTO")]
    public string? Complemento
    {
        get => _complemento;
        set => _complemento = value?[..Math.Min(50, value.Length)];
    }
    private string? _complemento;

    [Column("DCRBAICLI")]
    public string? Bairro
    {
        get => _bairro;
        set => _bairro = value?[..Math.Min(40, value.Length)];
    }
    private string? _bairro;

    [Column("DCRCIDCLI")]
    public string? Cidade
    {
        get => _cidade;
        set => _cidade = value?[..Math.Min(40, value.Length)];
    }
    private string? _cidade;

    [Column("CODUFCLI")]
    public string? Uf
    {
        get => _uf;
        set => _uf = value?[..Math.Min(2, value.Length)];
    }
    private string? _uf;

    [Column("NUMCEPCLI")]
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

    [Column("DCRREFCLI")]
    public string? DescricaoReferencia
    {
        get => _descricaoReferencia;
        set => _descricaoReferencia = value?[..Math.Min(50, value.Length)];
    }
    private string? _descricaoReferencia;

    [Column("TIPENDCLI")]
    public TipoEndereco TipoEndereco { get; set; }

    [Column("SITENDPRINC")]
    public SituacaoEnderecoPrincipal SituacaoEnderecoPrincipal { get; set; }

    [Column("STAENDCLI")]
    public SituacaoEndereco StatusEndereco { get; set; }

    [Column("DATREMARQ")]
    public DateTime DataRemessaArquivo { get; set; }

    [Column("ORGENDCLI")]
    public OrigemEmail OrigemEndereco { get; set; }

    [Column("CODENDCOBR")]
    public TipoEnderecoCobranca CodigoEnderecoCobranca { get; set; }

    [Column("SITBLOQCORRESPENDCLI")]
    public string? SituacaoBloqCorresp { get; set; }

    [Column("CODUSERCADCLI")]
    public string? UsuarioCadastro
    {
        get => _usuarioCadastro;
        set => _usuarioCadastro = value?[..Math.Min(10, value.Length)];
    }
    private string? _usuarioCadastro;

    [Column("DATCADENDCLI")]
    public DateTime DataCadastro { get; set; }

    [Column("DATRETARQ")]
    public DateTime? DataRetorno { get; set; }

    [Column("SITPRIORENDCOBR")]
    public int SituacaoPrioridadeEndereco { get; set; }

    [Column("REGTIMESTAMP")]
    public DateTime DataHoraRegistro { get; set; }

    [Column("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }

    [Column("OBSENDCLI")]
    public string? Observacao { get; set; }

    [Column("CODUSERCANCENDCLI")]
    public string? UsuarioCancelamento { get; set; }

    [Column("DATCANCENDCLI")]
    public DateTime? DataCancelamento { get; set; }

    [Column("CODUSERALTENDCLI")]
    public string? UsuarioAlteracao { get; set; }

    [Column("DATCONFENDCLI")]
    public DateTime? DataEnderecoConferido { get; set; }

    [Column("SITCONFENDCLI")]
    public string? SitEnderecoConferido { get; set; }

    [Column("CODCHAVEBANCO")]
    public string? CodigoChaveBanco { get; set; }
}
