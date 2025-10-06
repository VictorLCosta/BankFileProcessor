using Infrastructure.Persistence;
using Infrastructure.Tenant;
using Microsoft.Extensions.Hosting;

namespace Infrastructure;

public static class Extensions
{
    public static async Task<HostApplicationBuilder> AddInfrastructure(this HostApplicationBuilder builder)
    {
        builder.Services.AddMultitenancy();
        await builder.Services.AddPersistence(builder.Configuration);

        return builder;
    }

}
