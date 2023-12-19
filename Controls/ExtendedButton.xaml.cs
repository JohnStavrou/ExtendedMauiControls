using System.Windows.Input;

namespace ExtendedMauiControls.Controls;

public partial class ExtendedButton : BaseControl
{
    public event EventHandler Tapped;
    public static readonly BindableProperty TappedCommandProperty = BindableProperty.Create(nameof(TappedCommand), typeof(ICommand), typeof(ExtendedButton));

    private string text;
    private TextAlignment horizontalTextAlignment = TextAlignment.Center;
    private TextAlignment verticalTextAlignment = TextAlignment.Center;
    private Color textColor = Colors.White;
    private Color iconColor = Colors.White;

    public ExtendedButton() => InitializeComponent();

    #region Public properties
    public ICommand TappedCommand
    {
        get => (ICommand)GetValue(TappedCommandProperty);
        set => SetValue(TappedCommandProperty, value);
    }

    public string Text
    {
        get => text;
        set
        {
            text = value;
            OnPropertyChanged();
        }
    }

    public TextAlignment HorizontalTextAlignment
    {
        get => horizontalTextAlignment;
        set
        {
            horizontalTextAlignment = value;
            OnPropertyChanged();
        }
    }

    public TextAlignment VerticalTextAlignment
    {
        get => verticalTextAlignment;
        set
        {
            verticalTextAlignment = value;
            OnPropertyChanged();
        }
    }

    public Color TextColor
    {
        get => textColor;
        set
        {
            textColor = value;
            OnPropertyChanged();
        }
    }

    public Color IconColor
    {
        get => iconColor;
        set
        {
            iconColor = value;
            OnPropertyChanged();
        }
    }
    #endregion
}