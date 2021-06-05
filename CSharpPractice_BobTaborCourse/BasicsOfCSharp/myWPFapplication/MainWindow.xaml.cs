using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace myWPFapplication  //Windows Presentation Foundation Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += Button_Click2; //attaching another event handler manually
        }

        private void Button_Click(object sender, RoutedEventArgs e) //event handler to handle button click
        {
            label.Content = "Hello World"; //set content of label when button is clicked
        }

        private void Button_Click2(object sender, RoutedEventArgs e) //event handler to handle button click
        {
            label2.Content = "Hello Again!"; 
        }
    }
}
