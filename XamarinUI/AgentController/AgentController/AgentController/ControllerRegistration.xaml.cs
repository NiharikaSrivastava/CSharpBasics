using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgentController
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControllerRegistration : ContentPage
    {
        public ControllerRegistration()
        {
            InitializeComponent();
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
    }
}