using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Poppins-Light.ttf", Alias = "Poppins")]
[assembly: ExportFont("Poppins-Medium.ttf", Alias = "Poppins-Medium")]
[assembly: ExportFont("Oswald.ttf", Alias = "Oswald")]

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
