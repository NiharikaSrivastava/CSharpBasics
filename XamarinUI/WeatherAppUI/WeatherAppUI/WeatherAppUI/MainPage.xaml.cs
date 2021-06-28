using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/*namespace WeatherAppUI
{    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
         //   this.BindingContext = this;
        }*/
        /*public List<Weather> Weathers { get => WeatherData(); }
        private List<Weather> WeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Temp = "22", Date = "Sunday 16", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "21", Date = "Monday 17", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Tuesday 18", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "12", Date = "Wednesday 19", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "17", Date = "Thursday 20", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Friday 21", Icon = "weather.png" });

            return tempList;
        }*/
   // }

    /*public class Weather
    {
        public string Temp { get; set; }
        public string Date { get; set; }
        public string Icon { get; set; }
    }*/
//}

namespace WeatherAppUI
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Weather> Weathers { get => WeatherData(); }
        public List<Weather> WeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Date = "Thu 24", Icon = "rain.png", Temp = 16});
            tempList.Add(new Weather { Date = "Fri 25", Icon = "storm.png", Temp = 15 });
            tempList.Add(new Weather { Date = "Sat 26", Icon = "rain.png", Temp = 14 });
            tempList.Add(new Weather { Date = "Sun 27", Icon = "rain.png", Temp = 17 });
            tempList.Add(new Weather { Date = "Mon 28", Icon = "rain.png", Temp = 19 });
            tempList.Add(new Weather { Date = "Tue 29", Icon = "rain.png", Temp = 20 });
            tempList.Add(new Weather { Date = "Wed 30", Icon = "clouds.png", Temp = 20 });
            return tempList;
        }
    }
    public class Weather
    {
        public string Date { get; set; }
        public string Icon { get; set; }
        public int Temp { get; set; }
    }
}

