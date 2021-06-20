using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TextTutorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue; //one letter back
            string newText = e.NewTextValue; //current value
            OldLabel.Text = oldText; 
            NewLabel.Text = newText;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            string completedText = ((Entry)sender).Text; //after pressing enter
            CompletedLabel.Text = completedText; 
        }
    }
}
