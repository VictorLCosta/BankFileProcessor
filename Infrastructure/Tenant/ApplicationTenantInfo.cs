using Infrastructure.Tenant.Abstractions;

namespace Infrastructure.Tenant;

public class ApplicationTenantInfo : IApplicationTenantInfo
{
    private string _id = default!;
    private string _identifier = default!;
    private string _name = default!;
    private string _dbProvider = default!;
    private string _connectionString = default!;

    public ApplicationTenantInfo() { }

    public ApplicationTenantInfo(string id, string name, string dbProvider, string connectionString)
    {
        _id = id;
        _identifier = id;
        _name = name;
        _dbProvider = dbProvider;
        _connectionString = connectionString;
    }

    public string? Id { get => _id; set => _id = value ?? throw new InvalidOperationException("Id can't be null."); }
    public string? Identifier { get => _identifier; set => _identifier = value ?? throw new InvalidOperationException("Identifier can't be null."); }
    public string? Name { get => _name; set => _name = value ?? throw new InvalidOperationException("Name can't be null."); }
    public string DbProvider { get => _dbProvider; set => _dbProvider = value ?? throw new InvalidOperationException("DbProvider can't be null."); }
    public string ConnectionString { get => _connectionString; set => _connectionString = value ?? throw new InvalidOperationException("Connection string can't be null."); }
}
