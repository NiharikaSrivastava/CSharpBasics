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
            Thread.Sleep(10000);
            loading.PlayAnimation();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            controllerCard.BackgroundColor = Color.LightCyan;
            await Navigation.PushAsync(new ControllerRegistration());
            controllerCard.BackgroundColor = Color.White;
            loading.IsVisible = false;
        }
    }
}
