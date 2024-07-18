using System;
using System.Drawing;
using Foundation;
using Microsoft.Maui.Embedding;
using Microsoft.Maui.Platform;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.TabView;
using UIKit;

namespace TabViewNativeEmbeddingiOS;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window
    {
        get;
        set;
    }
    MauiContext? _mauiContext;
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // create a new window instance based on the screen size.
        Window = new UIWindow(UIScreen.MainScreen.Bounds);
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder.UseMauiEmbedding<Microsoft.Maui.Controls.Application>();
        builder.ConfigureSyncfusionCore();
        // Register the Window.
        builder.Services.Add(new Microsoft.Extensions.DependencyInjection.ServiceDescriptor(typeof(UIWindow), Window));
        MauiApp mauiApp = builder.Build();
        _mauiContext = new MauiContext(mauiApp.Services);

        SfTabView tabView = new SfTabView() { TabBarBackground = Colors.HotPink };

        ListView listView = new ListView
        {
            RowHeight = 50,
            ItemsSource = new string[] { "James", "Richard", "Clara", "Michael", "Alex", "Clara" },
            ItemTemplate = new DataTemplate(() =>
            {
                var grid = new Grid
                {
                    Margin = new Thickness(10, 5)
                };
                var label = new Label
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(5, 0),
                    TextColor = Colors.Black,
                    FontSize = 16
                };
                label.SetBinding(Label.TextProperty, ".");

                grid.Children.Add(label);

                return new ViewCell { View = grid };
            })
        };

        Grid favoritesGrid = new Grid { };
        favoritesGrid.Children.Add(listView);
        Grid recentsGrid = new Grid { BackgroundColor = Colors.Green };
        Grid contactsGrid = new Grid { BackgroundColor = Colors.Blue };
        var tabItems = new TabItemCollection
        {
            new SfTabItem()
                {
                    Header = "FAVOURITES",
                    Content = favoritesGrid
                },
                new SfTabItem()
                {
                    Header = "RECENTS",
                    Content = recentsGrid
                },
                new SfTabItem()
                {
                    Header = "CONTACTS",
                    Content = contactsGrid
                }
            };

        tabView.Items = tabItems;

        UIView mauiView = tabView.ToPlatform(_mauiContext);
        mauiView.Frame = Window!.Frame;

        // create UIViewController 
        var vc = new UIViewController();
        vc.View!.AddSubview(mauiView);

        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}


