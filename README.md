
# Extended MAUI Controls

Unlock the true potential of .NET MAUI development with ExtendedMauiControls, a powerful toolkit designed to extend simple controls and effortlessly create sophisticated, custom UI elements.

Built exclusively for .NET MAUI, our library seamlessly integrates with the cross-platform framework, enabling you to enhance your app's UI on iOS, Android, and Windows with a unified codebase.

Right now, the toolkit is quite new and not tested in Windows devices, so some controls or properties may be unusable for the time being.

# Getting Started

First, in order to use ExtendedMauiControls you need to call in yout project's MauiProgram.cs the extension method of the dependent package CommunityToolkit.Maui and then call the extension method that initializes our toolkit.

```c#
public static MauiApp CreateMauiApp()
{
    var builder = MauiApp.CreateBuilder();

    // Initialize .NET MAUI Community Toolkit
    builder.UseMauiApp<App>().UseMauiCommunityToolkit();
    
    // Initialize Extended .NET MAUI Controls Toolkit
    builder.UseMauiApp<App>().UseExtendedMauiControls();
}
```
    
# Available Extented Controls
## ExtendedEntry

#### Bindable Properties:
   - Text

#### Properties:
   - Placeholder
   - IsPassword
   - HasClearButton
   - PrefixIcon
   - SuffixIcon
   - PrimaryColor
   - SecondaryColor

#### Important Notes
 PrimaryColor and SecondaryColor are binded your project's Colors.xaml, so if they are missing you need to add them in your file as shown below:
```
<ResourceDictionary 
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">

    <Color x:Key="Primary">#512BD4</Color>
    <Color x:Key="Secondary">#DFD8F7</Color>
</ResourceDictionary>
```
If you are not using the Colors.xaml file you have to use the PrimaryColor and SecondaryColor

If those values are missing, you need to set the control's PrimaryColor and SecondaryColor, otherwise the control will not render.
   

# Usage

You can use the namespace below to use the tookit in xaml or C#

xaml
```xml
xmlns:emc="clr-namespace:ExtendedMauiControls.Controls;assembly=ExtendedMauiControls"
```

C#
```c#
using MauiExtendedControls.Controls;
```


# Example

Below you can see a simple usage example on a sign-in view

```xml
<emc:ExtendedEntry Text="{Binding Username}"
                   Placeholder="Username"
                   PrefixIcon="Person"/>

<emc:ExtendedEntry Text="{Binding Password}" IsPassword="True"
                   Placeholder="Password"
                   PrefixIcon="Lock"/>
```
# License

Huge thanks to
[AathifMahir](https://github.com/AathifMahir) for his incredible work on creating MAUI Icons and making it easier to use Material Icons and many more in .NET MAUI.
