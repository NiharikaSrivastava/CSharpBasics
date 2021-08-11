using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgentController
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class AgentInfo : ContentPage
    {
        public AgentInfo()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<AllAgentsInfo> AssignedAgents { get => AssignedAgentData(); }
        public List<AllAgentsInfo> UnassignedAgents { get => UnassignedAgentData(); }

        public List<AllAgentsInfo> AssignedAgentData()
        {
            var tempList = new List<AllAgentsInfo>();
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Suhani", AgentLastLocation = "Sobo Center, South Bopal..." });
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Shreyas", AgentLastLocation = "AB Complex, Prahladnagar..." });
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Rohan", AgentLastLocation = "The Mega Mall, Satellite..." });
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Monu", AgentLastLocation = "Titan Square, Law Garden..." });
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Akshan", AgentLastLocation = "Alpha 1 Mall, Vastrapur..." });
            return tempList;
        }

        public List<AllAgentsInfo> UnassignedAgentData()
        {
            var tempList = new List<AllAgentsInfo>();
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Shreya" });
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Aman" });
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Raj" });
            tempList.Add(new AllAgentsInfo { AgentName = "Agent Riya" });
            return tempList;
        }
    }
    public class AllAgentsInfo
    {
        public string AgentName { get; set; }
        public string AgentLastLocation { get; set; }
    }
}