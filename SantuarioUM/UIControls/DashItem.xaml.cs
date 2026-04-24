namespace SantuarioUM.UIControls;

public partial class DashItem : ContentView
{
    public DashItem()
    {
        InitializeComponent();
    }

    #region Bindable Properties
    /// <summary>
    /// The TitleText bindable property
    /// </summary>
    public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(
        propertyName: nameof(TitleText),
        returnType: typeof(string),
        declaringType: typeof(DashItem),
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.TwoWay);

    /// <summary>
    /// Get or set the TitleText Property
    /// </summary>
    public string TitleText
    {
        get => (string)GetValue(TitleTextProperty);
        set => SetValue(TitleTextProperty, value);
    }
    
    /// <summary>
    /// The ImageSource bindable property
    /// </summary>
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(
        propertyName: nameof(ImageSource),
        returnType: typeof(string),
        declaringType: typeof(DashItem),
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.TwoWay);

    /// <summary>
    /// Get or set the ImageSource Property
    /// </summary>
    public string ImageSource
    {
        get => (string)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }
    #endregion
}