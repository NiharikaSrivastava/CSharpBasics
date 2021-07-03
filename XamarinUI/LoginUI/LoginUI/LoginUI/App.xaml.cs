using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly:ExportFont("Poppins-Light.ttf",Alias ="Poppins")]
namespace LoginUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental","MediaElement_Experimental"});
            MainPage = new MainPage();
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
