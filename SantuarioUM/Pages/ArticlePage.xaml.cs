using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.Pages;

public partial class ArticlePage : ContentPage
{
    public ArticlePage(IArticleViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}