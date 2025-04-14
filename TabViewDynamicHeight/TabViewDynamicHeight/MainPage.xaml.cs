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
            tabView.HeightRequest = GetContentHeight(call);
        }
        private void OnSelectionChanged(object sender, Syncfusion.Maui.TabView.TabSelectionChangedEventArgs e)
        {
            AdjustTabViewHeight(e.NewIndex);
        }

        private void AdjustTabViewHeight(double selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: 
                    tabView.HeightRequest = GetContentHeight(call);
                    break;
                case 1: 
                    tabView.HeightRequest = GetContentHeight(contacts);
                    break;
                case 2: 
                    tabView.HeightRequest = GetContentHeight(favourite);
                    break;
                default:
                    tabView.HeightRequest = 100; // Set a minimum height
                    break;
            }
        }

        private double GetContentHeight(SfTabItem tabItem)
        {
            if (tabItem.Content == null)
            {
                return 100; // Set a minimum height when there is no content
            }

            return tabItem.Content.Measure(double.PositiveInfinity, double.PositiveInfinity).Height;
        }
    }
}
