using Infrastructure.Persistence;
using Infrastructure.Tenant;
using Microsoft.Extensions.Hosting;

namespace Infrastructure;

public static class Extensions
{
    public static HostApplicationBuilder AddInfratructure(this HostApplicationBuilder builder, IConfiguration configuration)
    {
        builder.Services.AddMultitenancy();
        builder.Services.AddPersistence(configuration);

        return builder;
    }
}
