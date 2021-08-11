using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgentController
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class AgentSetup : ContentPage
    {
        public AgentSetup()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Agents> AllAgents { get => AgentData(); }
        public List<Agents> AgentData()
        {
            var tempList = new List<Agents>();
            tempList.Add(new Agents { AgentName = "Agent Niharika"});
            tempList.Add(new Agents { AgentName = "Agent Rohan" });
            tempList.Add(new Agents { AgentName = "Agent Monu" });
            tempList.Add(new Agents { AgentName = "Agent Suhani" });
            tempList.Add(new Agents { AgentName = "Agent Akshan" });
            tempList.Add(new Agents { AgentName = "Agent Shreya" });
            tempList.Add(new Agents { AgentName = "Agent Aman" });
            tempList.Add(new Agents { AgentName = "Agent Raj" });
            tempList.Add(new Agents { AgentName = "Agent Riya" });
            return tempList;
        }

        public void ImgButton_Clicked(object sender, EventArgs e)
        {
            label1.IsVisible = true;
            listView1.IsVisible = true;
            go2.IsVisible = true;
        }
    }
    public class Agents
    {
        public string AgentName { get; set; }
    }
}