using Syncfusion.Maui.TabView;

namespace TabViewDynamicHeight
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            tabsView.HeightRequest = GetContentHeight(call);
        }
        private void tabsView_SelectionChanged(object sender, Syncfusion.Maui.TabView.TabSelectionChangedEventArgs e)
        {
            AdjustTabViewHeight(e.NewIndex);
        }

        private void AdjustTabViewHeight(double selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: 
                    tabsView.HeightRequest = GetContentHeight(call);
                    break;
                case 1: 
                    tabsView.HeightRequest = GetContentHeight(contacts);
                    break;
                case 2: 
                    tabsView.HeightRequest = GetContentHeight(favourite);
                    break;
                default:
                    tabsView.HeightRequest = 100; // Set a minimum height
                    break;
            }
        }

        private double GetContentHeight(SfTabItem tabItem)
        {
            if (tabItem.Content == null)
            {
                return 100; // Set a minimum height when there is no content
            }

            return tabItem.Content.Measure(double.PositiveInfinity, double.PositiveInfinity).Request.Height;
        }
    }
}
