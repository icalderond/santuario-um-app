using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.Pages;

public partial class ParentArticlePage : ContentPage
{
    public ParentArticlePage(IParentArticleViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}