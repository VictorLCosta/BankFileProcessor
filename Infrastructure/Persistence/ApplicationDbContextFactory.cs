using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence;

internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {


        return new ApplicationDbContext();
    }
}

