using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CO001",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "int", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NOMCLI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CODCPFCNPJCLI = table.Column<long>(type: "bigint", nullable: false),
                    TIPPESSCLI = table.Column<int>(type: "int", nullable: false),
                    CODCLIEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATNASCCLI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NUMRGIDENTCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMCONJUCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FILIACAOCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMTELRESCLI = table.Column<long>(type: "bigint", nullable: false),
                    NUMTELCELCLI = table.Column<long>(type: "bigint", nullable: false),
                    DCRLOCTRABCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMTELCOMCLI = table.Column<long>(type: "bigint", nullable: false),
                    NUMFAXCOMCLI = table.Column<long>(type: "bigint", nullable: false),
                    CODCORRESPCLI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ENDEMAILCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMSOCCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOMCONTCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCADCLI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATREMARQ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATATUALREG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUMTELCONTCLI = table.Column<long>(type: "bigint", nullable: false),
                    NUMTELCOBRCLI = table.Column<long>(type: "bigint", nullable: false),
                    NUMRAMTELCOMCLI = table.Column<int>(type: "int", nullable: false),
                    CODFILIAL = table.Column<int>(type: "int", nullable: true),
                    TIPREGIMECASAMENTO = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TIPSEXOCLI = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CODESTADOCIVIL = table.Column<int>(type: "int", nullable: true),
                    REGCKTRANSF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRBAICLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODCEPCLI = table.Column<int>(type: "int", nullable: false),
                    DCRCIDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODCHAVEBANCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODENDCOBR = table.Column<int>(type: "int", nullable: false),
                    DCRCOMPLEMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCADENDCLI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATCANCENDCLI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATCONFENDCLI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATRETARQ = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DCRREFCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMENDCLI = table.Column<int>(type: "int", nullable: true),
                    OBSENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ORGENDCLI = table.Column<int>(type: "int", nullable: false),
                    SITCONFENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SITBLOQCORRESPENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SITENDPRINC = table.Column<int>(type: "int", nullable: false),
                    SITPRIORENDCOBR = table.Column<int>(type: "int", nullable: false),
                    STAENDCLI = table.Column<int>(type: "int", nullable: false),
                    TIPENDCLI = table.Column<int>(type: "int", nullable: false),
                    CODUFCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODUSERALTENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODUSERCADCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODUSERCANCENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO001", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO002",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "int", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CODFILIAL = table.Column<int>(type: "int", nullable: false),
                    DATCHEGBODERDIV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATDEVDIV = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CODINDFIN = table.Column<int>(type: "int", nullable: false),
                    NUMPARCPLANODIV = table.Column<int>(type: "int", nullable: false),
                    VLRSALDHISTPLDIV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VLRCPDIARIADIV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TAXFINCONTRDIV = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CODAGENCIADIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STAFASECOBRDIV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOMCONCAGENDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMCARTCOBDIV = table.Column<long>(type: "bigint", nullable: false),
                    CODPRODCONTRDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRPRODCONTRDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRSEGPROTDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INFCOMPLDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SITDIVCOB = table.Column<int>(type: "int", nullable: false),
                    SITCONTRDIVADV = table.Column<int>(type: "int", nullable: false),
                    SITCOBDIV = table.Column<int>(type: "int", nullable: false),
                    CODCAMPANHA = table.Column<int>(type: "int", nullable: false),
                    CODSCRIPTCOB = table.Column<int>(type: "int", nullable: true),
                    CODUSERID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATULTCOBDIV = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATAGENCOBR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SITACERTDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCADDIV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATATUALREG = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SITREFCONTRDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIPCONTR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCONTRDIV = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATENQRDIV = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TIPCOBRDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATPERFCOBRDIV = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FASCOBRDIV = table.Column<int>(type: "int", nullable: false),
                    SITCONTRDIVTERC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SITBLOQAJUIZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODCLASSPDDDIV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CODCARTCOBR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VLRRISCOCONTRDIV = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VLRPERCPLPG = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CODINSTRCOBR = table.Column<long>(type: "bigint", nullable: true),
                    CODAREACOBRDIV = table.Column<int>(type: "int", nullable: true),
                    CODFASECOBRDIV = table.Column<int>(type: "int", nullable: true),
                    TIPOPRCONTRDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODMOTIVINAD = table.Column<short>(type: "smallint", nullable: true),
                    TIPOPRCOBR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODDIALING = table.Column<long>(type: "bigint", nullable: true),
                    TIPVINCCONTRDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMCONTRDIVVINC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QTDVINCCONTRDIV = table.Column<short>(type: "smallint", nullable: true),
                    STATELHIGCONTRDIV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMCONTRCOBDIV = table.Column<long>(type: "bigint", nullable: false),
                    TIPODIVIDA = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CODESTRATEG = table.Column<int>(type: "int", nullable: true),
                    SCOREDIVCOBR = table.Column<long>(type: "bigint", nullable: true),
                    SITINFBXPASTABCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODEMPRECOLG = table.Column<int>(type: "int", nullable: true),
                    SITRECLSAC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCORECONTR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGCKTRANSF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO002", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO003",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "int", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NUMPARC = table.Column<int>(type: "int", nullable: false),
                    TIPPARC = table.Column<int>(type: "int", nullable: false),
                    SITPARC = table.Column<int>(type: "int", nullable: false),
                    DATVCTOPARC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VLRPRINCPARC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VLRMULTAPARC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VLRCPPARC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VLRMORAPARC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CODPARC = table.Column<long>(type: "bigint", nullable: false),
                    NUMDOCPARC = table.Column<long>(type: "bigint", nullable: false),
                    TIPCADPARC = table.Column<int>(type: "int", nullable: false),
                    VLRDESPPARC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUMLOTPARC = table.Column<long>(type: "bigint", nullable: false),
                    DATCHEGBODERPARC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CODINDFIN = table.Column<int>(type: "int", nullable: false),
                    FASCOBRDIV = table.Column<int>(type: "int", nullable: false),
                    SITBOLPARC = table.Column<int>(type: "int", nullable: false),
                    SITBLOQPARC = table.Column<int>(type: "int", nullable: false),
                    PERCVENCPARC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DATVCTORGPARC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SITFORVCTOPARC = table.Column<int>(type: "int", nullable: false),
                    TIPBXPARC = table.Column<int>(type: "int", nullable: false),
                    DATBXPARC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATPGTOPARC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATDEVPARC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SLDPARC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TIPMOEDAPARC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIPAPPLPARC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATATUALREG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATCADPARC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUMPARCORIGINAL = table.Column<int>(type: "int", nullable: true),
                    DATNOTIFPARC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CODFASCONTBPARC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SITCONTRAJUIZ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCOREDIVCOBR = table.Column<long>(type: "bigint", nullable: false),
                    REGCKTRANSF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO003", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO004",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "int", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DCRBEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRMARCABEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRMODELBEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMANOFABBEM = table.Column<int>(type: "int", nullable: false),
                    NUMANOMODELO = table.Column<int>(type: "int", nullable: false),
                    NUMPLACABEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRCORBEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMCHASSIBEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIPCOMBBEM = table.Column<int>(type: "int", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATATUALREG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TIPBEM = table.Column<int>(type: "int", nullable: false),
                    SITGARANTBEM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CODCERTBEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODSINISTBEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMRENAVAMBEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALORBEM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    REGCKTRANSF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VLRCOTACAO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CODMOLICARVEIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODFIPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO004", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO090",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "int", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NUMTELCOBR = table.Column<long>(type: "bigint", nullable: false),
                    CODTELCOBR = table.Column<int>(type: "int", nullable: false),
                    SITPRIORTELCOBR = table.Column<short>(type: "smallint", nullable: false),
                    OBSTELCOBR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATELCOBR = table.Column<int>(type: "int", nullable: false),
                    SITBLOQSMS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USERCADTELCOBR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USERALTERTELCOBR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USERCANCTELCOBR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCANCTELCOBR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATCADTELCOBR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CODCPFCNPJCLI = table.Column<long>(type: "bigint", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "datetime2", nullable: true),
                    STAHIGTELCOBR = table.Column<int>(type: "int", nullable: false),
                    NUMTELORIGINAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODAREA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODORGTEL = table.Column<int>(type: "int", nullable: false),
                    SCORETELCOBR = table.Column<int>(type: "int", nullable: true),
                    CODCHAVEBANCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODEMPPESQ = table.Column<int>(type: "int", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO090", x => new { x.CODEMPRESA, x.NUMCONTRDIV, x.NUMTELCOBR });
                });

            migrationBuilder.CreateTable(
                name: "CO092",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "int", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CODCPFCNPJCLI = table.Column<long>(type: "bigint", nullable: false),
                    DCRENDCLI = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NUMENDCLI = table.Column<int>(type: "int", nullable: true),
                    DCRCOMPLEMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRBAICLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRCIDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODUFCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODCEPCLI = table.Column<int>(type: "int", nullable: false),
                    DCRREFCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TIPENDCLI = table.Column<int>(type: "int", nullable: false),
                    SITENDPRINC = table.Column<int>(type: "int", nullable: false),
                    STAENDCLI = table.Column<int>(type: "int", nullable: false),
                    DATREMARQ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ORGENDCLI = table.Column<int>(type: "int", nullable: false),
                    CODENDCOBR = table.Column<int>(type: "int", nullable: false),
                    SITBLOQCORRESPENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODUSERCADCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCADENDCLI = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATRETARQ = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SITPRIORENDCOBR = table.Column<int>(type: "int", nullable: false),
                    REGCKTRANSF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OBSENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODUSERCANCENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCANCENDCLI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CODUSERALTENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCONFENDCLI = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SITCONFENDCLI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODCHAVEBANCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO092", x => new { x.CODEMPRESA, x.NUMCONTRDIV });
                });

            migrationBuilder.CreateTable(
                name: "CO125",
                columns: table => new
                {
                    CODEMPRESA = table.Column<int>(type: "int", nullable: false),
                    NUMCONTRDIV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DCREMAIL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TIPOEMAIL = table.Column<int>(type: "int", nullable: false),
                    CODUSERIDCAD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCADEMAIL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CODUSERIDALT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATALTEMAIL = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OBSMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STAEMAIL = table.Column<int>(type: "int", nullable: false),
                    CODCPFCNPJ = table.Column<long>(type: "bigint", nullable: false),
                    CODUSERCANC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATCANCEMAIL = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SITMAILPRINC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATREMARQ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    REGCKTRANSF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STAHIGEMAIL = table.Column<int>(type: "int", nullable: true),
                    ORGEMAILCLI = table.Column<int>(type: "int", nullable: false),
                    SITROBOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODCHAVEBANCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CO125", x => new { x.CODEMPRESA, x.NUMCONTRDIV, x.DCREMAIL });
                });

            migrationBuilder.CreateTable(
                name: "PR001",
                columns: table => new
                {
                    NUMPROC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPPROC = table.Column<int>(type: "int", nullable: false),
                    DCRPROC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DCRDIR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR001", x => x.NUMPROC);
                });

            migrationBuilder.CreateTable(
                name: "PR017",
                columns: table => new
                {
                    CODREPETICAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMREPETICAO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIASSEMANA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INTERVALO = table.Column<TimeSpan>(type: "time", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR017", x => x.CODREPETICAO);
                });

            migrationBuilder.CreateTable(
                name: "PR018",
                columns: table => new
                {
                    IDAGENDA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HORAINIAGENDA = table.Column<TimeOnly>(type: "time", nullable: false),
                    HORAFIMAGENDA = table.Column<TimeOnly>(type: "time", nullable: true),
                    PRIORIDADE = table.Column<int>(type: "int", nullable: false),
                    STAAGENDA = table.Column<bool>(type: "bit", nullable: false),
                    REPETIRPROCESSO = table.Column<bool>(type: "bit", nullable: false),
                    DATAULTVERIFICACAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CODREPETICAO = table.Column<int>(type: "int", nullable: false),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR018", x => x.IDAGENDA);
                    table.ForeignKey(
                        name: "FK_PR018_PR017_CODREPETICAO",
                        column: x => x.CODREPETICAO,
                        principalTable: "PR017",
                        principalColumn: "CODREPETICAO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PR012",
                columns: table => new
                {
                    CODDESC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARQDESC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STAPROC = table.Column<bool>(type: "bit", nullable: false),
                    SITSUPORTAPART = table.Column<bool>(type: "bit", nullable: false),
                    QTDPARTES = table.Column<int>(type: "int", nullable: true),
                    SITHEADER = table.Column<bool>(type: "bit", nullable: false),
                    SITFOOTER = table.Column<bool>(type: "bit", nullable: false),
                    NUMPROC = table.Column<int>(type: "int", nullable: false),
                    SchedulingId = table.Column<int>(type: "int", nullable: true),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR012", x => x.CODDESC);
                    table.ForeignKey(
                        name: "FK_PR012_PR001_NUMPROC",
                        column: x => x.NUMPROC,
                        principalTable: "PR001",
                        principalColumn: "NUMPROC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PR012_PR018_SchedulingId",
                        column: x => x.SchedulingId,
                        principalTable: "PR018",
                        principalColumn: "IDAGENDA");
                });

            migrationBuilder.CreateTable(
                name: "PR030",
                columns: table => new
                {
                    CODDESC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INFORARQUIVO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EXTARQUIVO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CODROTINA = table.Column<int>(type: "int", nullable: false),
                    ProcessingRoutineId = table.Column<int>(type: "int", nullable: false),
                    REGTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MODTIMESTAMP = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PR030", x => x.CODDESC);
                    table.ForeignKey(
                        name: "FK_PR030_PR012_ProcessingRoutineId",
                        column: x => x.ProcessingRoutineId,
                        principalTable: "PR012",
                        principalColumn: "CODDESC",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_CO092_DCRENDCLI_CODCEPCLI",
                table: "CO092",
                columns: new[] { "DCRENDCLI", "CODCEPCLI" });

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

            migrationBuilder.CreateIndex(
                name: "IX_PR030_ProcessingRoutineId",
                table: "PR030",
                column: "ProcessingRoutineId");
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
                name: "CO092");

            migrationBuilder.DropTable(
                name: "CO125");

            migrationBuilder.DropTable(
                name: "PR030");

            migrationBuilder.DropTable(
                name: "PR012");

            migrationBuilder.DropTable(
                name: "PR001");

            migrationBuilder.DropTable(
                name: "PR018");

            migrationBuilder.DropTable(
                name: "PR017");
        }
    }
}
