using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int clickCount = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            clickCount++;
            ((Button)sender).Text =$"Clicked {clickCount} Times";
        }
    }
}
