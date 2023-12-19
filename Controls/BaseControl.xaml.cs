namespace ExtendedMauiControls.Controls;

public partial class BaseControl : ContentView
{
    private MaterialIcons? prefixIcon;
    private MaterialIcons? suffixIcon;
    private Color primaryColor;

    public BaseControl() => InitializeComponent();

    #region Public properties
    public MaterialIcons? PrefixIcon
    {
        get => prefixIcon;
        set
        {
            prefixIcon = value;
            OnPropertyChanged();
        }
    }

    public MaterialIcons? SuffixIcon
    {
        get => suffixIcon;
        set
        {
            suffixIcon = value;
            OnPropertyChanged();
        }
    }

    public Color PrimaryColor
    {
        get => primaryColor;
        set => primaryColor = value;
    }
    #endregion
}
