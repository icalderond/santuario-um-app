using CommunityToolkit.Mvvm.Input;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.ViewModels;

public partial class DashViewModel : IDashViewModel
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

    [RelayCommand]
    private async void GoToAtrioAsync()=>   GoToNavigation(0);
    [RelayCommand]
    private async void GoToSantoAsync()=>   GoToNavigation(1);
    [RelayCommand]
    private async void GoToSantisimoAsync()=>   GoToNavigation(2);
    

    private async Task GoToNavigation(int i)
    {
        await _navigationService.ShellGoToAsync($"{nameof(ParentArticleViewModel)}?parentArticleId={i}");
    }

    #endregion
}