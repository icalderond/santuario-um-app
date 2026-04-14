using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM;

public partial class AppShell : Shell
{
    public AppShell(IAppShellViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext= viewModel;
    }
}