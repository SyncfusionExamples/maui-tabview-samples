using System.ComponentModel;
using Syncfusion.Maui.TabView;
using LoadPageContentInSfTabView.View;

namespace LoadPageContentInSfTabView
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields

        private TabItemCollection items;

        #endregion

        #region Construtor

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.GetTabItems();
        }

        #endregion

        #region Events 

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value of the Items. This property can be used to give children for tab view using the collection of SfTabItem.
        /// </summary>
        public TabItemCollection Items
        {
            get 
            { 
                return items; 
            }
            set
            {
                items = value;
                OnPropertyChanged("Items");
            }
        }

        #endregion

        #region Property changed

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Methods

        /// <summary>
        /// To get the tab items for the tab view.
        /// </summary>
        private void GetTabItems()
        {
            Items = new TabItemCollection();
            TabViewItemPage1 page1 = new TabViewItemPage1();
            TabViewItemPage2 page2 = new TabViewItemPage2();
            TabViewItemPage3 page3 = new TabViewItemPage3();
            TabViewItemPage4 page4 = new TabViewItemPage4();
            Items.Add(new SfTabItem { Content = page1.Content, Header = "Page1" });
            Items.Add(new SfTabItem { Content = page2.Content, Header = "Page2" });
            Items.Add(new SfTabItem { Content = page3.Content, Header = "Page3" });
            Items.Add(new SfTabItem { Content = page4.Content, Header = "Page4" });
        }

        #endregion
    }
}
