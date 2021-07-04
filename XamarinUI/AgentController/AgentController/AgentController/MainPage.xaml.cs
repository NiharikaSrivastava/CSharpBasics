using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgentController
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;
            Thread.Sleep(2000);
            await Navigation.PushAsync(new ControllerRegistration());
            loading.IsVisible = false;
        }
    }
}
