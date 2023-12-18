global using CommunityToolkit.Maui;
global using CommunityToolkit.Mvvm.Input;
global using MauiIcons.Core;
global using MauiIcons.Material;

namespace ExtendedMauiControls;

public static class ExtendedMauiControls
{
    public static void UseExtendedMauiControls(this MauiAppBuilder builder)
    {
        builder.UseMauiCommunityToolkit();
        builder.UseMaterialMauiIcons();

        // Official temporary workaround for url styled namespace in xaml
        _ = new MauiIcon();
    }
}
