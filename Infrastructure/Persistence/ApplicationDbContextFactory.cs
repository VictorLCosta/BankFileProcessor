using Finbuckle.MultiTenant;
using Infrastructure.Tenant;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence;

internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        // Caminho base para localizar o appsettings
        var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../UserInterface");
        var appSettingsPath = Path.Combine(basePath, "appsettings.json");

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddCommandLine(args)
            .AddJsonFile(appSettingsPath, optional: true)
            .Build();

        var tenantId = configuration.GetValue<string>("tenant") ?? string.Empty;
        
        // 🔹 Carrega os tenants do appsettings
        var tenantsSection = configuration.GetSection("Finbuckle:MultiTenant:Stores:ConfigurationStore:Tenants");
        var tenants = tenantsSection.GetChildren().ToList();

        if (tenants.Count == 0)
            throw new InvalidOperationException("Nenhum tenant encontrado na configuração.");

        // 🔹 Seleciona o tenant pelo argumento ou o primeiro
        var tenantConfig = tenants.FirstOrDefault(t =>
            string.Equals(t["Id"], tenantId, StringComparison.OrdinalIgnoreCase)) ?? tenants.First();

        var dbProvider = tenantConfig["DbProvider"] ?? DbProviders.MSSQL;
        var connectionString = tenantConfig["ConnectionString"] ?? throw new InvalidOperationException("Connection string ausente.");

        // 🔹 Configura o EF Core
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.ConfigureDatabase(dbProvider, connectionString);

        // 🔹 Cria o TenantInfo fake para o design-time
        var tenantInfo = new ApplicationTenantInfo
        {
            Id = tenantConfig["Id"],
            Identifier = tenantConfig["Identifier"],
            Name = tenantConfig["Name"],
            ConnectionString = connectionString,
            DbProvider = dbProvider
        };

        var tenantContext = new MultiTenantContext<ApplicationTenantInfo>
        {
            TenantInfo = tenantInfo
        };

        var tenantAccessor = new ApplicationMultitenantContextAccessor<ApplicationTenantInfo>(tenantContext);

        return new ApplicationDbContext(tenantAccessor, optionsBuilder.Options);
    }
}
