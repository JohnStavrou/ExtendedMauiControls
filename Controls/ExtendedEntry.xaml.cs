#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif

namespace ExtendedMauiControls.Controls;

public partial class ExtendedEntry : BaseControl
{
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ExtendedEntry), "");
    
    private string placeholder;
    private bool isPassword;
    private bool hasClearButton = true;
    private Color textColor = Colors.Black;
    private Color unfocusedColor = Colors.Gray;

    public ExtendedEntry()
    {
        InitializeHandlers();
        InitializeComponent();
    }

    #region Handlers
    private void InitializeHandlers()
    {
        RemoveEntryUnderline();
    }

    private void RemoveEntryUnderline()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif WINDOWS
            handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
            // Do something here to remove the windows border when focused!!!
#endif
        });
    }
    #endregion

    #region Public properties
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set
        {
            SetValue(TextProperty, value);
            OnPropertyChanged(nameof(HasClearButton));
        }
    }

    public string Placeholder
    {
        get => placeholder;
        set
        {
            placeholder = value;
            OnPropertyChanged();
        }
    }

    public bool IsPassword
    {
        get => isPassword;
        set
        {
            isPassword = value;
            if (value)
                IsPasswordVisible = false;
            OnPropertyChanged();
        }
    }

    public bool HasClearButton
    {
        get => hasClearButton && !string.IsNullOrEmpty(Text);
        set
        {
            hasClearButton = value;
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

    public Color UnfocusedColor
    {
        get => unfocusedColor;
        set
        {
            unfocusedColor = value;
            OnPropertyChanged();
        }
    }
    #endregion

    public Color BorderColor => IsFocused ? PrimaryColor : UnfocusedColor;

    public MaterialIcons PasswordIcon => IsPasswordVisible ? MaterialIcons.Visibility : MaterialIcons.VisibilityOff;

    private bool isFocused;
    protected new bool IsFocused
    {
        get => isFocused;
        set
        {
            isFocused = value;
            OnPropertyChanged(nameof(BorderColor));
        }
    }

    private bool isPasswordVisible;
    protected bool IsPasswordVisible
    {
        get => isPasswordVisible;
        set
        {
            isPasswordVisible = value;
            entry.IsPassword = !isPasswordVisible;
            OnPropertyChanged(nameof(PasswordIcon));
        }
    }

    #region Events
    [RelayCommand]
    void InsetTapped() => entry.Focus();

    [RelayCommand]
    void PasswordVisibilityTapped() => IsPasswordVisible = !IsPasswordVisible;

    [RelayCommand]
    void ClearTapped()
    {
        entry.Text = "";
        entry.Focus();
    }

    void Entry_Focused(object sender, FocusEventArgs e) => IsFocused = true;

    void Entry_Unfocused(object sender, FocusEventArgs e) => IsFocused = false;

    void Entry_TextChanged(object sender, TextChangedEventArgs e) => Text = e.NewTextValue;
    #endregion
}