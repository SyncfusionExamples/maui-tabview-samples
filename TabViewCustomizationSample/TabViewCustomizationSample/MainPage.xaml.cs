using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace TabViewCustomizationSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}
