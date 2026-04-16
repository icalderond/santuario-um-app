using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SantuarioUM.Models;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.ViewModels;

public partial class ParentArticleViewModel : BaseViewModel, IParentArticleViewModel, IQueryAttributable
{
    #region Private Properties

    string _areaId =  string.Empty;
    private readonly ISantuarioService _santuarioService;
    private readonly INavigationService _navigationService;
    [ObservableProperty] private Area? _currentArea;

    #endregion

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="santuarioService"></param>
    /// <param name="navigationService"></param>
    public ParentArticleViewModel(
        ISantuarioService santuarioService, 
        INavigationService navigationService)
    {
        _santuarioService = santuarioService;
        _navigationService = navigationService;
    }

    /// <summary>
    /// Apply query attributes
    /// </summary>
    /// <param name="query"></param>
    public async void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("area"))
        {
            var area = query["area"].ToString();
            _areaId = area ?? string.Empty;
            
            var santuarioData = await _santuarioService.GetSantuarioData();
            CurrentArea = santuarioData.Areas.FirstOrDefault(a => a.Id == area);
        }
    }

    [RelayCommand]
    private async Task NavigateToAsync(string muebleId)
    {
        await _navigationService.ShellGoToAsync($"{nameof(ArticleViewModel)}?area={_areaId}&mueble={muebleId}");
    }
}