using CommunityToolkit.Mvvm.ComponentModel;
using SantuarioUM.Models;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.ViewModels;

public partial class ArticleViewModel : BaseViewModel, IArticleViewModel, IQueryAttributable
{
    #region Private Properties
    private readonly ISantuarioService _santuarioService;
    [ObservableProperty] private Mueble? _currentMueble;

    #endregion
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="santuarioService"></param>
    public ArticleViewModel(ISantuarioService santuarioService)
    {
        _santuarioService = santuarioService;
    }
    
    /// <summary>
    /// Apply query attributes
    /// </summary>
    /// <param name="query"></param>
    public async void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("area") && query.ContainsKey("mueble"))
        {
            var area = query["area"].ToString();
            var mueble = query["mueble"].ToString();

            var santuarioData = await _santuarioService.GetSantuarioData();
            var currentArea = santuarioData.Areas.FirstOrDefault(a => a.Id == area);
            CurrentMueble =  currentArea.Muebles.FirstOrDefault(m => m.Id == mueble);
        }
    }
}