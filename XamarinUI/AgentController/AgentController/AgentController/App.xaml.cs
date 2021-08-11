using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Poppins-Light.ttf", Alias = "Poppins")]
[assembly: ExportFont("Poppins-Medium.ttf", Alias = "Poppins-Medium")]
[assembly: ExportFont("Oswald.ttf", Alias = "Oswald")]
[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "OpenSans-Bold")]
[assembly: ExportFont("OpenSans-BoldItalic.ttf", Alias = "OpenSans-BoldItalic")]
[assembly: ExportFont("OpenSans-ExtraBold.ttf", Alias = "OpenSans-ExtraBold")]
[assembly: ExportFont("OpenSans-ExtraBoldItalic.ttf", Alias = "OpenSans-ExtraBoldItalic")]
[assembly: ExportFont("OpenSans-Italic.ttf", Alias = "OpenSans-Italic")]
[assembly: ExportFont("OpenSans-Light.ttf", Alias = "OpenSans-Light")]
[assembly: ExportFont("OpenSans-LightItalic.ttf", Alias = "OpenSans-LightItalic")]
[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "OpenSans-Regular")]
[assembly: ExportFont("OpenSans-SemiBold.ttf", Alias = "OpenSans-SemiBold")]
[assembly: ExportFont("OpenSans-SemiBoldItalic.ttf", Alias = "OpenSans-SemiBoldItalic")]
[assembly: ExportFont("PlayfairDisplay-Black.ttf", Alias = "PlayfairDisplay-Black")]
[assembly: ExportFont("PlayfairDisplay-BlackItalic.ttf", Alias = "PlayfairDisplay-BlackItalic")]
[assembly: ExportFont("PlayfairDisplay-Bold.ttf", Alias = "PlayfairDisplay-Bold")]
[assembly: ExportFont("PlayfairDisplay-BoldItalic.ttf", Alias = "PlayfairDisplay-BoldItalic")]
[assembly: ExportFont("PlayfairDisplay-ExtraBold.ttf", Alias = "PlayfairDisplay-ExtraBold")]
[assembly: ExportFont("PlayfairDisplay-ExtraBoldItalic.ttf", Alias = "PlayfairDisplay-ExtraBoldItalic")]
[assembly: ExportFont("PlayfairDisplay-Italic.ttf", Alias = "PlayfairDisplay-Italic")]
[assembly: ExportFont("PlayfairDisplay-Medium.ttf", Alias = "PlayfairDisplay-Medium")]
[assembly: ExportFont("PlayfairDisplay-MediumItalic.ttf", Alias = "PlayfairDisplay-MediumItalic")]
[assembly: ExportFont("PlayfairDisplay-Regular.ttf", Alias = "PlayfairDisplay-Regular")]
[assembly: ExportFont("PlayfairDisplay-SemiBold.ttf", Alias = "PlayfairDisplay-SemiBold")]
[assembly: ExportFont("PlayfairDisplay-SemiBoldItalic.ttf", Alias = "PlayfairDisplay-SemiBoldItalic")]

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
