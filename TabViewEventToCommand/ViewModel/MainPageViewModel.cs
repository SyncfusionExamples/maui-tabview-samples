using System.ComponentModel;
using Syncfusion.Maui.TabView;
namespace TabViewEventToCommand
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private Command<object>? selectionChangedCommand;
        public Command<object>? SelectionChangedCommand
        {
            get { return selectionChangedCommand; }
            set
            {
                selectionChangedCommand = value;
                OnPropertyChanged(nameof(SelectionChangedCommand));
            }
        }
        public MainPageViewModel() 
        {
            SelectionChangedCommand = new Command<object>(TabViewSelectionChanged);
        }

        public void TabViewSelectionChanged(object obj)
        {
            // Do action

            var tabView = (obj as SfTabView);
            if (tabView != null)
            {
                foreach(var tabItem  in tabView.Items)
                {
                    if (tabItem != null)
                    {
                        if(tabItem.IsSelected)
                        {
                            App.Current?.MainPage?
                                .DisplayAlert("Alert", "You have been selected " + tabItem.Header + " Tab", "OK");
                        }
                    }
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
