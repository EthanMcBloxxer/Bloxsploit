using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloxsploit.User_Controls
{
    public partial class SynapseUIScriptHub : UserControl
    {
        readonly NeuronAPI.Exploit WeAreDevsAPI = new NeuronAPI.Exploit();
        readonly EasyExploits.Module EasyExploitsAPI = new EasyExploits.Module();

        public SynapseUIScriptHub()
        {
            InitializeComponent();
        }
        public void ExecuteExploit(string Script)
        {
            if (Properties.Settings.Default.API == "WeAreDevs")
            {
                WeAreDevsAPI.ExecuteLua(Script);
            }
            if (Properties.Settings.Default.API == "EasyExploits")
            {
                EasyExploitsAPI.ExecuteScript(Script);
            }
        }
        private void Dex_Click(object sender, EventArgs e)
        {
            ExecuteExploit("https://gist.githubusercontent.com/DinosaurXxX/b757fe011e7e600c0873f967fe427dc2/raw/ee5324771f017073fc30e640323ac2a9b3bfc550/dark%2520dex%2520v4");
        }

        private void InfiniteYield_Click(object sender, EventArgs e)
        {
            ExecuteExploit("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
        }

        private void Reviz_Click(object sender, EventArgs e)
        {
            ExecuteExploit("https://pastebin.com/raw/ibFPdiF7");
        }
    }
}
