using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Asset : BaseEntity<ContractId>
{
    /// <summary>
    /// [DCRBEM] [varchar](50)
    /// </summary>
    public string? DescricaoBem
    {
        get
        {
            return _descricao;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _descricao = Strings.Left(value, 50);
        }
    }
    private string? _descricao;

    /// <summary>
    /// [DCRMARCABEM] [varchar](40)
    /// </summary>
    public string? Marca
    {
        get => _marca;
        set => _marca = Strings.Left(value, 40);
    }
    private string? _marca;

    /// <summary>
    /// [DCRMODELBEM] [varchar](40)
    /// </summary>
    public string? Modelo
    {
        get => _modelo;
        set => _modelo = Strings.Left(value, 40);
    }
    private string? _modelo;

    /// <summary>
    /// [NUMANOFABBEM] [numeric](4, 0) NOT NULL
    /// </summary>
    public int AnoFabricacao { get; set; }

    /// <summary>
    /// [NUMANOMODELO] [smallint] NULL
    /// </summary>
    public int AnoModelo { get; set; }

    /// <summary>
    /// [NUMPLACABEM] [varchar](8)
    /// </summary>
    public string? Placa { get; set; }

    /// <summary>
    /// [DCRCORBEM] [varchar](25)
    /// </summary>
    public string? Cor
    {
        get => _cor;
        set
        {
            _cor = Strings.Left(value, 25);
        }
    }
    private string? _cor;

    /// <summary>
    /// [NUMCHASSIBEM] [varchar](25) NOT NULL
    /// </summary>
    public string? Chassi
    {
        get
        {
            return _chassi;
        }
        set
        {
            _chassi = Strings.Left(value, 25);
        }
    }
    private string? _chassi;

    /// <summary>
    /// [TIPCOMBBEM] [numeric](1, 0) NOT NULL
    /// </summary>
    public TipoCombustivel TipoCombustivel { get; set; }

    /// <summary>
    /// [DATREMARQ] [datetime]
    /// </summary>
    public DateTime DataRemessaArquivo { get; set; }

    /// <summary>
    /// [DATATUALREG] [datetime] NOT NULL
    /// </summary>
    public DateTime DataAtualizacaoRegistro { get; set; }

    /// <summary>
    /// [TIPBEM] [char](1) NOT NULL
    /// </summary>
    public TipoBem Tipo { get; set; }

    /// <summary>
    /// [SITGARANTBEM] [char](1) NOT NULL
    /// </summary>
    public string SituacaoGarantia { get; set; } = string.Empty;

    /// <summary>
    /// [CODCERTBEM] [varchar](10)
    /// </summary>
    public string? CodigoCertificado { get; set; }

    /// <summary>
    /// [CODSINISTBEM] [varchar](15)
    /// </summary>
    public string? CodigoSinistro { get; set; }

    /// <summary>
    /// [NUMRENAVAMBEM] [varchar](15)
    /// </summary>
    public string? Renavam
    {
        get
        {
            return _renavam;
        }
        set
        {
            _renavam = Strings.Left(value, 15);
        }
    }
    private string? _renavam;

    /// <summary>
    /// [VALORBEM] [numeric](19, 6)
    /// </summary>
    public decimal? Valor { get; set; }

    /// <summary>
    /// [REGTIMESTAMP] [datetime]
    /// </summary>
    public DateTime DataHoraRegistro { get; set; }

    /// <summary>
    /// [REGCKTRANSF] - char(1)
    /// </summary>
    public string? RegistroTransferido { get; set; }

    /// <summary>
    /// [VLRCOTACAO] [money](19,4)
    /// </summary>
    /// <returns></returns>
    public decimal? ValorCotacao { get; set; }

    /// <summary>
    /// [CODMOLICARVEIC] [varchar](15)
    /// </summary>
    public string? CodigoMolicar { get; set; }

    /// <summary>
    /// [CODFIPE] varchar(50)
    /// </summary>
    public string? CodigoFipe { get; set; }
}
