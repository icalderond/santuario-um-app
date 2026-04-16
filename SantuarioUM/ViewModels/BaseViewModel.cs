using CommunityToolkit.Mvvm.ComponentModel;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.ViewModels;

public partial class BaseViewModel : ObservableObject, IViewModel
{
    #region Private properties
    [ObservableProperty] private bool _isBusy;
    #endregion

    #region Lifecycle methods
    /// <summary>
    /// Constructor
    /// </summary>
    public BaseViewModel()
    {
    }
    #endregion

    #region Virtual methods
    /// <summary>
    /// When overriden, allows application developers to customize behavior immediately prior to the Page becoming visible
    /// </summary>
    public virtual void OnAppearing()
    {
    }

    /// <summary>
    /// When overriden, allows the application developer to customize behavior as the Page disappears
    /// </summary>
    public virtual void OnDisappearing()
    {
    }

    /// <summary>
    /// When overriden, allow the application developer customize action when navigation was done
    /// </summary>
    public virtual void OnNavigatedFrom()
    {
        
    }
    #endregion
}