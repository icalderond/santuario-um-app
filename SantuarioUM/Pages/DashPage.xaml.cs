using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.Pages;

public partial class DashPage : ContentPage
{
    public DashPage(IDashViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}