using Microsoft.VisualBasic;

namespace Domain.Entities;

public class Asset : BaseChargeEntity
{
    /// <summary>
    /// [DCRBEM] [varchar](50)
    /// </summary>
    [Column("DCRBEM")]
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
    [Column("DCRMARCABEM")]
    public string? Marca
    {
        get => _marca;
        set => _marca = Strings.Left(value, 40);
    }
    private string? _marca;

    /// <summary>
    /// [DCRMODELBEM] [varchar](40)
    /// </summary>
    [Column("DCRMODELBEM")]
    public string? Modelo
    {
        get => _modelo;
        set => _modelo = Strings.Left(value, 40);
    }
    private string? _modelo;

    /// <summary>
    /// [NUMANOFABBEM] [numeric](4, 0) NOT NULL
    /// </summary>
    [Column("NUMANOFABBEM")]
    public int AnoFabricacao { get; set; }

    /// <summary>
    /// [NUMANOMODELO] [smallint] NULL
    /// </summary>
    [Column("NUMANOMODELO")]
    public int AnoModelo { get; set; }

    /// <summary>
    /// [NUMPLACABEM] [varchar](8)
    /// </summary>
    [Column("NUMPLACABEM")]
    public string? Placa { get; set; }

    /// <summary>
    /// [DCRCORBEM] [varchar](25)
    /// </summary>
    [Column("DCRCORBEM")]
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
    [Column("NUMCHASSIBEM")]
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
    [Column("TIPCOMBBEM")]
    public TipoCombustivel TipoCombustivel { get; set; }

    /// <summary>
    /// [DATREMARQ] [datetime]
    /// </summary>
    [Column("DATREMARQ")]
    public DateTime DataRemessaArquivo { get; set; }

    /// <summary>
    /// [DATATUALREG] [datetime] NOT NULL
    /// </summary>
    [Column("DATATUALREG")]
    public DateTime DataAtualizacaoRegistro { get; set; }

    /// <summary>
    /// [TIPBEM] [char](1) NOT NULL
    /// </summary>
    [Column("TIPBEM")]
    public TipoBem Tipo { get; set; }

    /// <summary>
    /// [SITGARANTBEM] [char](1) NOT NULL
    /// </summary>
    [Column("SITGARANTBEM")]
    public string SituacaoGarantia { get; set; } = string.Empty;

    /// <summary>
    /// [CODCERTBEM] [varchar](10)
    /// </summary>
    [Column("CODCERTBEM")]
    public string? CodigoCertificado { get; set; }

    /// <summary>
    /// [CODSINISTBEM] [varchar](15)
    /// </summary>
    [Column("CODSINISTBEM")]
    public string? CodigoSinistro { get; set; }

    /// <summary>
    /// [NUMRENAVAMBEM] [varchar](15)
    /// </summary>
    [Column("NUMRENAVAMBEM")]
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
    [Column("VALORBEM")]
    public decimal? Valor { get; set; }

    /// <summary>
    /// [REGCKTRANSF] - char(1)
    /// </summary>
    [Column("REGCKTRANSF")]
    public string? RegistroTransferido { get; set; }

    /// <summary>
    /// [VLRCOTACAO] [money](19,4)
    /// </summary>
    [Column("VLRCOTACAO")]
    public decimal? ValorCotacao { get; set; }

    /// <summary>
    /// [CODMOLICARVEIC] [varchar](15)
    /// </summary>
    [Column("CODMOLICARVEIC")]
    public string? CodigoMolicar { get; set; }

    /// <summary>
    /// [CODFIPE] varchar(50)
    /// </summary>
    [Column("CODFIPE")]
    public string? CodigoFipe { get; set; }
}
