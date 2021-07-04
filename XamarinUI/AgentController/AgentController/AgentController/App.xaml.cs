using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Poppins-Light.ttf", Alias = "Poppins")]
[assembly: ExportFont("Poppins-Medium.ttf", Alias = "Poppins-Medium")]

namespace AgentController
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
