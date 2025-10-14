using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations.Oracle.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CO002",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    CODFILIAL = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DATCHEGBODERDIV = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATDEVDIV = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CODINDFIN = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMPARCPLANODIV = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    VLRSALDHISTPLDIV = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    VLRCPDIARIADIV = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    TAXFINCONTRDIV = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    CODAGENCIADIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    STAFASECOBRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NOMCONCAGENDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMCARTCOBDIV = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    CODPRODCONTRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DCRPRODCONTRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DCRSEGPROTDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    INFCOMPLDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SITDIVCOB = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITCONTRDIVADV = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITCOBDIV = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CODCAMPANHA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CODSCRIPTCOB = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CODUSERID = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATULTCOBDIV = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DATAGENCOBR = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    SITACERTDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCADDIV = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATATUALREG = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    SITREFCONTRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPCONTR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCONTRDIV = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DATENQRDIV = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    TIPCOBRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATPERFCOBRDIV = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    FASCOBRDIV = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITCONTRDIVTERC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SITBLOQAJUIZ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODCLASSPDDDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CODCARTCOBR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    VLRRISCOCONTRDIV = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: true),
                    VLRPERCPLPG = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: true),
                    CODINSTRCOBR = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    CODAREACOBRDIV = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CODFASECOBRDIV = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TIPOPRCONTRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODMOTIVINAD = table.Column<short>(type: "NUMBER(5)", nullable: true),
                    TIPOPRCOBR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODDIALING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    TIPVINCCONTRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMCONTRDIVVINC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    QTDVINCCONTRDIV = table.Column<short>(type: "NUMBER(5)", nullable: true),
                    STATELHIGCONTRDIV = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMCONTRCOBDIV = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    TIPODIVIDA = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    CODESTRATEG = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SCOREDIVCOBR = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    SITINFBXPASTABCO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODEMPRECOLG = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SITRECLSAC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SCORECONTR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGCKTRANSF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO002", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO003",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    NUMPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TIPPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DATVCTOPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    VLRPRINCPARC = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    VLRMULTAPARC = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    VLRCPPARC = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    VLRMORAPARC = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    CODPARC = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NUMDOCPARC = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    TIPCADPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    VLRDESPPARC = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NUMLOTPARC = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DATCHEGBODERPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CODINDFIN = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FASCOBRDIV = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITBOLPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITBLOQPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PERCVENCPARC = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    DATVCTORGPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    SITFORVCTOPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TIPBXPARC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DATBXPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DATPGTOPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DATDEVPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    SLDPARC = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    TIPMOEDAPARC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPAPPLPARC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATATUALREG = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATCADPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NUMPARCORIGINAL = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DATNOTIFPARC = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CODFASCONTBPARC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SITCONTRAJUIZ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SCOREDIVCOBR = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    REGCKTRANSF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO003", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO004",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    DCRBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DCRMARCABEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DCRMODELBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMANOFABBEM = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMANOMODELO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMPLACABEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DCRCORBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMCHASSIBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPCOMBBEM = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATATUALREG = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TIPBEM = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITGARANTBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CODCERTBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODSINISTBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NUMRENAVAMBEM = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    VALORBEM = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: true),
                    REGCKTRANSF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    VLRCOTACAO = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: true),
                    CODMOLICARVEIC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODFIPE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO004", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO090",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Numero = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    CODTELCOBR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITPRIORTELCOBR = table.Column<short>(type: "NUMBER(5)", nullable: false),
                    OBSTELCOBR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    STATELCOBR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITBLOQSMS = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    USERCADTELCOBR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    USERALTERTELCOBR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    USERCANCTELCOBR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCANCTELCOBR = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DATCADTELCOBR = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CODCPFCNPJCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    STAHIGTELCOBR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMTELORIGINAL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODAREA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODORGTEL = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SCORETELCOBR = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CODCHAVEBANCO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODEMPPESQ = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO090", x => new { x.CODEMPRESA, x.NUMCONTRDIV, x.Numero });
                });

            migrationBuilder.CreateTable(
                name: "CO092",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    CODCPFCNPJCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DCRENDCLI = table.Column<string>(type: "NVARCHAR2(450)", nullable: true),
                    NUMENDCLI = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DCRCOMPLEMENTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DCRBAICLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DCRCIDCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODUFCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Cep = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DCRREFCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TIPENDCLI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITENDPRINC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    STAENDCLI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ORGENDCLI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CODENDCOBR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITBLOQCORRESPENDCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODUSERCADCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCADENDCLI = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATRETARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    SITPRIORENDCOBR = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    REGCKTRANSF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    OBSENDCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODUSERCANCENDCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCANCENDCLI = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CODUSERALTENDCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCONFENDCLI = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    SITCONFENDCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODCHAVEBANCO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO092", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO125",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    DCREMAIL = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    TIPOEMAIL = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CODUSERIDCAD = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCADEMAIL = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CODUSERIDALT = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATALTEMAIL = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    OBSMAIL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    STAEMAIL = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CODCPFCNPJ = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    CODUSERCANC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCANCEMAIL = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    SITMAILPRINC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATREMARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    REGCKTRANSF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    STAHIGEMAIL = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    ORGEMAILCLI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SITROBOT = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CODCHAVEBANCO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO125", x => new { x.CODEMPRESA, x.NUMCONTRDIV, x.DCREMAIL });
                });

            migrationBuilder.CreateTable(
                name: "InstitutionProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TIPPROC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DCRPROC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DCRDIR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repetition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOMREPETICAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DIASSEMANA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    INTERVALO = table.Column<TimeSpan>(type: "INTERVAL DAY(8) TO SECOND(7)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repetition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CO001",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    NOMCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CODCPFCNPJCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    TIPPESSCLI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CODCLIEMP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATNASCCLI = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    NUMRGIDENTCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMCONJUCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FILIACAOCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EnderecoResidencialCodigoEmpresa = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EnderecoResidencialNumeroContrato = table.Column<string>(type: "NVARCHAR2(450)", nullable: true),
                    NUMTELRESCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NUMTELCELCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DCRLOCTRABCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EnderecoComercialCodigoEmpresa = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EnderecoComercialNumeroContrato = table.Column<string>(type: "NVARCHAR2(450)", nullable: true),
                    NUMTELCOMCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NUMFAXCOMCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    CODCORRESPCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ENDEMAILCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMSOCCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NOMCONTCLI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DATCADCLI = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    DATREMARQ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DATATUALREG = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NUMTELCONTCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NUMTELCOBRCLI = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NUMRAMTELCOMCLI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CODFILIAL = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EnderecoCobrancaCodigoEmpresa = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EnderecoCobrancaNumeroContrato = table.Column<string>(type: "NVARCHAR2(450)", nullable: true),
                    TIPREGIMECASAMENTO = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    TIPSEXOCLI = table.Column<string>(type: "NVARCHAR2(1)", nullable: false),
                    CODESTADOCIVIL = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    REGCKTRANSF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO001", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                    table.ForeignKey(
                        name: "FK_CO001_CO092_EnderecoCobrancaCodigoEmpresa_EnderecoCobrancaNumeroContrato",
                        columns: x => new { x.EnderecoCobrancaCodigoEmpresa, x.EnderecoCobrancaNumeroContrato },
                        principalTable: "CO092",
                        principalColumns: new[] { "CODEMPRESA", "NUMCONTRDIV" });
                    table.ForeignKey(
                        name: "FK_CO001_CO092_EnderecoComercialCodigoEmpresa_EnderecoComercialNumeroContrato",
                        columns: x => new { x.EnderecoComercialCodigoEmpresa, x.EnderecoComercialNumeroContrato },
                        principalTable: "CO092",
                        principalColumns: new[] { "CODEMPRESA", "NUMCONTRDIV" });
                    table.ForeignKey(
                        name: "FK_CO001_CO092_EnderecoResidencialCodigoEmpresa_EnderecoResidencialNumeroContrato",
                        columns: x => new { x.EnderecoResidencialCodigoEmpresa, x.EnderecoResidencialNumeroContrato },
                        principalTable: "CO092",
                        principalColumns: new[] { "CODEMPRESA", "NUMCONTRDIV" });
                });

            migrationBuilder.CreateTable(
                name: "PR018",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    HORAINIAGENDA = table.Column<string>(type: "NVARCHAR2(48)", nullable: false),
                    HORAFIMAGENDA = table.Column<string>(type: "NVARCHAR2(48)", nullable: true),
                    PRIORIDADE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    STAAGENDA = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    REPETIRPROCESSO = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    DATAULTVERIFICACAO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CODREPETICAO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR018", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PR018_Repetition_CODREPETICAO",
                        column: x => x.CODREPETICAO,
                        principalTable: "Repetition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PR012",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ARQDESC = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    STAPROC = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    SITSUPORTAPART = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    QTDPARTES = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    SITHEADER = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    SITFOOTER = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    NUMPROC = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SchedulingId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR012", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PR012_InstitutionProfiles_NUMPROC",
                        column: x => x.NUMPROC,
                        principalTable: "InstitutionProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PR012_PR018_SchedulingId",
                        column: x => x.SchedulingId,
                        principalTable: "PR018",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FilePattern",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    INFORARQUIVO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EXTARQUIVO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ProcessingRoutineId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "RAW(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilePattern", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilePattern_PR012_ProcessingRoutineId",
                        column: x => x.ProcessingRoutineId,
                        principalTable: "PR012",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CO001_CODCPFCNPJCLI",
                table: "CO001",
                column: "CODCPFCNPJCLI");

            migrationBuilder.CreateIndex(
                name: "IX_CO001_CODEMPRESA_NUMCONTRDIV_CODCPFCNPJCLI",
                table: "CO001",
                columns: new[] { "CODEMPRESA", "NUMCONTRDIV", "CODCPFCNPJCLI" });

            migrationBuilder.CreateIndex(
                name: "IX_CO001_EnderecoCobrancaCodigoEmpresa_EnderecoCobrancaNumeroContrato",
                table: "CO001",
                columns: new[] { "EnderecoCobrancaCodigoEmpresa", "EnderecoCobrancaNumeroContrato" });

            migrationBuilder.CreateIndex(
                name: "IX_CO001_EnderecoComercialCodigoEmpresa_EnderecoComercialNumeroContrato",
                table: "CO001",
                columns: new[] { "EnderecoComercialCodigoEmpresa", "EnderecoComercialNumeroContrato" });

            migrationBuilder.CreateIndex(
                name: "IX_CO001_EnderecoResidencialCodigoEmpresa_EnderecoResidencialNumeroContrato",
                table: "CO001",
                columns: new[] { "EnderecoResidencialCodigoEmpresa", "EnderecoResidencialNumeroContrato" });

            migrationBuilder.CreateIndex(
                name: "IX_CO002_NUMCARTCOBDIV",
                table: "CO002",
                column: "NUMCARTCOBDIV");

            migrationBuilder.CreateIndex(
                name: "IX_CO002_SCOREDIVCOBR",
                table: "CO002",
                column: "SCOREDIVCOBR");

            migrationBuilder.CreateIndex(
                name: "IX_CO002_SITDIVCOB_CODEMPRESA_NUMCONTRDIV",
                table: "CO002",
                columns: new[] { "SITDIVCOB", "CODEMPRESA", "NUMCONTRDIV" });

            migrationBuilder.CreateIndex(
                name: "IX_CO003_DATCHEGBODERPARC_CODEMPRESA",
                table: "CO003",
                columns: new[] { "DATCHEGBODERPARC", "CODEMPRESA" });

            migrationBuilder.CreateIndex(
                name: "IX_CO003_SCOREDIVCOBR",
                table: "CO003",
                column: "SCOREDIVCOBR");

            migrationBuilder.CreateIndex(
                name: "IX_CO003_SITPARC",
                table: "CO003",
                column: "SITPARC");

            migrationBuilder.CreateIndex(
                name: "IX_CO092_DCRENDCLI_Cep",
                table: "CO092",
                columns: new[] { "DCRENDCLI", "Cep" });

            migrationBuilder.CreateIndex(
                name: "IX_FilePattern_ProcessingRoutineId",
                table: "FilePattern",
                column: "ProcessingRoutineId");

            migrationBuilder.CreateIndex(
                name: "IX_PR012_NUMPROC",
                table: "PR012",
                column: "NUMPROC");

            migrationBuilder.CreateIndex(
                name: "IX_PR012_SchedulingId",
                table: "PR012",
                column: "SchedulingId");

            migrationBuilder.CreateIndex(
                name: "IX_PR018_CODREPETICAO",
                table: "PR018",
                column: "CODREPETICAO");

            migrationBuilder.CreateIndex(
                name: "IX_PR018_STAAGENDA",
                table: "PR018",
                column: "STAAGENDA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CO001");

            migrationBuilder.DropTable(
                name: "CO002");

            migrationBuilder.DropTable(
                name: "CO003");

            migrationBuilder.DropTable(
                name: "CO004");

            migrationBuilder.DropTable(
                name: "CO090");

            migrationBuilder.DropTable(
                name: "CO125");

            migrationBuilder.DropTable(
                name: "FilePattern");

            migrationBuilder.DropTable(
                name: "CO092");

            migrationBuilder.DropTable(
                name: "PR012");

            migrationBuilder.DropTable(
                name: "InstitutionProfiles");

            migrationBuilder.DropTable(
                name: "PR018");

            migrationBuilder.DropTable(
                name: "Repetition");
        }
    }
}
