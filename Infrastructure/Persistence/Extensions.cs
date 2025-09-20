using Finbuckle.MultiTenant.Abstractions;
using Infrastructure.Tenant;
using Microsoft.EntityFrameworkCore;

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

    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        using var serviceProvider = services.BuildServiceProvider();

        services.AddDbContext<ApplicationDbContext>((options) =>
        {
            var accessor = serviceProvider.GetRequiredService<IMultiTenantContextAccessor<ApplicationTenantInfo>>();
            var tenant = accessor.MultiTenantContext?.TenantInfo;

            var connectionString = tenant?.ConnectionString ?? configuration.GetConnectionString("DefaultConnection")!;
            var dbProvider = tenant?.DbProvider ?? DbProviders.MSSQL;

            options.ConfigureDatabase(dbProvider, connectionString);
        });

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        return services;
    }
}
