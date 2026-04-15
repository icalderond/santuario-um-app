using System.Windows.Input;
using SantuarioUM.Models;

namespace SantuarioUM.Controls;

public partial class ItemMenuControl : ContentView
{
    public ItemMenuControl()
    {
        InitializeComponent();
    }

    /// <summary>
    /// The ItemMenu bindable property
    /// </summary>
    public static readonly BindableProperty ItemSourceProperty = BindableProperty.Create(
        propertyName: nameof(ItemSource),
        returnType: typeof(ItemMenu),
        declaringType: typeof(ItemMenuControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.TwoWay);

    /// <summary>
    /// Get or set the ItemMenu Property
    /// </summary>
    public ItemMenu ItemSource
    {
        get => (ItemMenu)GetValue(ItemSourceProperty);
        set => SetValue(ItemSourceProperty, value);
    }
    
    /// <summary>
    /// Gets or sets the ItemCommand Property.
    /// </summary>
    public ICommand ItemCommand
    {
        get => (ICommand)GetValue(ItemCommandProperty);
        set => SetValue(ItemCommandProperty, value);
    }

    /// <summary>
    /// The ItemCommand bindable property
    /// </summary>
    public static readonly BindableProperty ItemCommandProperty = BindableProperty.Create(
        propertyName: nameof(ItemCommand),
        returnType: typeof(ICommand),
        declaringType: typeof(ItemMenuControl),
        defaultValue:null,
        defaultBindingMode: BindingMode.TwoWay );
}