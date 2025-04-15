using Syncfusion.Maui.TabView;
using Android.App;
using Android.OS;
using Microsoft.Maui.Embedding;
using Syncfusion.Maui.Core.Hosting;
using Microsoft.Maui.Platform;
using Microsoft.Maui.Controls.Embedding;

namespace NativeEmbeddingAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MauiContext? _mauiContext;
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            MauiAppBuilder builder = MauiApp.CreateBuilder();
            builder.UseMauiEmbeddedApp<Microsoft.Maui.Controls.Application>();
            builder.ConfigureSyncfusionCore();
            MauiApp mauiApp = builder.Build();
            _mauiContext = new MauiContext(mauiApp.Services, this);

            SfTabView tabView = new SfTabView() { TabBarBackground=Colors.HotPink };

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

            Android.Views.View mauiView = tabView.ToPlatform(_mauiContext);
            SetContentView(mauiView);
        }

    }
}