# Xamarin.Forms.Controls.FloatingActionButton
A custom view to create a FloatingActionButton for both Android and iOS as part of Material Design

That's right, even on iOS!

## How to use

Clone the repository and open include the `src` projects in your Xamarin.Forms and Platform projects.

**Special note for iOS:** Make sure to call `FloatingActionButtonRenderer.InitRenderer();` in your `AppDelegate.cs` in order to avoid linking it out.

Then you can include it in your XAML or call it from C# (See the example projects for a demo):

``` xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:SuaveControls.FabExample"
             xmlns:controls="clr-namespace:SuaveControls.Views;assembly=SuaveControls.FloatingActionButton"
             x:Class="SuaveControls.FabExample.MainPage">
    <StackLayout Margin="32">
        <Label Text="This is a Floating Action Button!" 
           VerticalOptions="Center" 
           HorizontalOptions="Center"/>
        
        <controls:FloatingActionButton x:Name="FAB" HorizontalOptions="CenterAndExpand" WidthRequest="50" HeightRequest="50"  VerticalOptions="CenterAndExpand" Image="ic_add_white.png" ButtonColor="#03A9F4" Clicked="Button_Clicked"/>
    </StackLayout>
</ContentPage>
```

## Android Example

![Android Floating Action Button](https://i1.wp.com/alexdunndev.files.wordpress.com/2017/04/screenshot_1493173400.png?ssl=1&w=450)

## iOS Example

![iOS Floating Action Button](https://i2.wp.com/alexdunndev.files.wordpress.com/2017/04/2017-04-25_10-38-38-pm.jpg?ssl=1&w=450)

## TODO:
- Make it more flexible. Add Different color states, add sizing adjustments, etc.
- Create UWP implementation
- Create Nuget package
- Create Xamarin Component
