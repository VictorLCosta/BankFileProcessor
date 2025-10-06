using Finbuckle.MultiTenant.Abstractions;
using Infrastructure.Tenant;

namespace Infrastructure.Persistence;

internal static class Extensions
{
    private static DbContextOptionsBuilder ConfigureDatabase(this DbContextOptionsBuilder builder, string dbProvider, string connectionString) 
    {
        return dbProvider.ToUpperInvariant() switch
        {
            DbProviders.MSSQL => builder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure()),
            DbProviders.Oracle => builder.UseOracle(connectionString),
            DbProviders.PostgreSQL => builder.UseNpgsql(connectionString, options => options.EnableRetryOnFailure()),
            DbProviders.MySQL => builder.UseMySql(ServerVersion.AutoDetect(connectionString), options => options.EnableRetryOnFailure()).EnableDetailedErrors(),
            _ => throw new InvalidOperationException($"DB Provider {dbProvider} is not supported."),
        };
    }

    public static async Task<IServiceCollection> AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        using var serviceProvider = services.BuildServiceProvider();

        var store = serviceProvider.GetRequiredService<IMultiTenantStore<ApplicationTenantInfo>>();
        var tenant = await store.TryGetByIdentifierAsync("santander-varejo");

        services.AddDbContext<ApplicationDbContext>((options) =>
        {
            var connectionString = tenant?.ConnectionString ?? configuration.GetConnectionString("DefaultConnection")!;
            var dbProvider = tenant?.DbProvider ?? DbProviders.MSSQL;

            options.ConfigureDatabase(dbProvider, connectionString);
        });

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        return services;
    }
}
