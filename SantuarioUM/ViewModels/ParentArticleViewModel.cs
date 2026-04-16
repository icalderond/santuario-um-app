using CommunityToolkit.Mvvm.ComponentModel;
using SantuarioUM.Models;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.ViewModels;

public partial class ParentArticleViewModel : BaseViewModel, IParentArticleViewModel, IQueryAttributable
{
    #region Private Properties

    private readonly ISantuarioService _santuarioService;
    [ObservableProperty] private Area? _currentArea;

    #endregion

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="santuarioService"></param>
    public ParentArticleViewModel(ISantuarioService santuarioService)
    {
        _santuarioService = santuarioService;
    }

    public async void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("area"))
        {
            var area = query["area"].ToString();

            var santuarioData = await _santuarioService.GetSantuarioData();
            CurrentArea = santuarioData.Areas.FirstOrDefault(a => a.Id == area);
        }
    }
}