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
            Thread.Sleep(20000);
            loading.PlayAnimation();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;
            controllerCard.BackgroundColor = Color.LightCyan;
            await Navigation.PushAsync(new ControllerRegistration());
            controllerCard.BackgroundColor = Color.White;
            loading.IsVisible = false;
        }

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            loading.IsVisible = true;
            agentCard.BackgroundColor = Color.LightCyan;
            await Navigation.PushAsync(new AgentSetup());
            agentCard.BackgroundColor = Color.White;
            loading.IsVisible = false;
        }
    }
}
