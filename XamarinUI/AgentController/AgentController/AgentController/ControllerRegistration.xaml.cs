using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace AgentController
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControllerRegistration : ContentPage
    {
        public ControllerRegistration()
        {
            InitializeComponent();
           /* Xamarin.Forms.ImageButton button = ImgButton;
            button.On<Android>()
                       .SetIsShadowEnabled(true)
                       .SetShadowColor(Color.Gray)
                       .SetShadowOffset(new Size(10, 10))
                       .SetShadowRadius(12);*/
        }
        private void Entry_Focused_1(object sender, FocusEventArgs e)
        {
            nameCard.Opacity = 1;
        }

        private void Entry_Focused_2(object sender, FocusEventArgs e)
        {
            emailCard.Opacity = 1;
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            passCard.Opacity = 1;
        }

        private void Entry_Focused_3(object sender, FocusEventArgs e)
        {
            confirmPassCard.Opacity = 1;
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            nameCard.Opacity = 0.5;
        }

        private void Entry_Unfocused_1(object sender, FocusEventArgs e)
        {
            emailCard.Opacity = 0.5;
        }

        private void Entry_Unfocused_2(object sender, FocusEventArgs e)
        {
            passCard.Opacity = 0.5;
        }

        private void Entry_Unfocused_3(object sender, FocusEventArgs e)
        {
            confirmPassCard.Opacity = 0.5;
        }

        private async void ImgButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgentInfo());
        }
    }
}