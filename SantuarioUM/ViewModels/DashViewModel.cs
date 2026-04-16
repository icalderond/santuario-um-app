using CommunityToolkit.Mvvm.Input;
using SantuarioUM.Utilities.Enums;
using SantuarioUM.Utilities.Extensions;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.ViewModels;

public partial class DashViewModel : BaseViewModel, IDashViewModel
{
    #region Private Properties

    private readonly INavigationService _navigationService;

    #endregion

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="navigationService"></param>
    public DashViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    #region Methods

    /// <summary>
    /// Go to navigation async
    /// </summary>
    /// <param name="i"></param>
    [RelayCommand]
    private async Task GoToNavigationAsync(AreaEnum i)
    {
        await _navigationService.ShellGoToAsync($"{nameof(ParentArticleViewModel)}?area={i.GetDescription()}");
    }

    #endregion
}