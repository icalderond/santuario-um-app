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
}