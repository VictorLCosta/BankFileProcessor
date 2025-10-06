using Finbuckle.MultiTenant.Abstractions;
using Infrastructure.Tenant;

namespace UserInterface.Forms;

public partial class MainWindow : Form
{
    private readonly IMultiTenantContextAccessor<ApplicationTenantInfo> _accessor;

    public MainWindow(IMultiTenantContextAccessor<ApplicationTenantInfo> accessor)
    {
        _accessor = accessor;

        InitializeComponent();
    }


}

