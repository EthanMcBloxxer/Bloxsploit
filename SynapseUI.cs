using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloxsploit
{
    public partial class SynapseUI : Form
    {
        readonly NeuronAPI.Exploit WeAreDevsAPI = new NeuronAPI.Exploit();
        readonly EasyExploits.Module EasyExploitsAPI = new EasyExploits.Module();
        Point lastPoint;
        public SynapseUI()
        {
            InitializeComponent();

            Functions.PopulateListBox(Scripts, "Scripts", "*.lua");
            Functions.PopulateListBox(Scripts, "Scripts", "*.txt");

            timer.Start();
            refresher.Start();

            tooltip.SetToolTip(ExecutionTab, "Execution Tab");
            tooltip.SetToolTip(ScriptHubTab, "Script Hub");
            tooltip.SetToolTip(ConsoleTab, "External Synapse Console");
            tooltip.SetToolTip(OptionsTab, "Options Tab");
            tooltip.SetToolTip(GoBack, "Back to Bloxsploit");
        }
        public void AttachExploit()
        {
            if (Properties.Settings.Default.API == "WeAreDevs")
            {
                WeAreDevsAPI.AttachExploit(null, "\\Bin", "\\Workspace");
            }
            if (Properties.Settings.Default.API == "EasyExploits")
            {
                EasyExploitsAPI.LaunchExploit();
            }
        }
        public void ExecuteExploit(string Script)
        {
            if (Properties.Settings.Default.API == "EasyExploits")
            {
                EasyExploitsAPI.ExecuteScript(Script);
            }
            if (Properties.Settings.Default.API == "WeAreDevs")
            {
                WeAreDevsAPI.ExecuteLua(Script);
            }
        }
        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Synapse";
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SynapseUI_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            webBrowser1.Url = new Uri(string.Format("file:///{0}/Editor/Editor.html", Directory.GetCurrentDirectory()));

        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Attach_Click(object sender, EventArgs e)
        {
            AttachExploit();
            Thread.Sleep(1000);
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            ExecuteExploit(script);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Yes.Visible = true;
            No.Visible = true;
            ClearConfirmation.Visible = true;
        }

        private void SynapseUI_Shown(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("SetText", new object[] { "-- Welcome to Bloxapse X!" });
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Dark";
            Properties.Settings.Default.Save();
            this.Close();
            Application.Restart();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                InitialDirectory = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Scripts")),
                Filter = "Lua Source Files (*.lua)|*.lua|Text Documents (*.txt)|*.txt"
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string MainText = File.ReadAllText(openDialog.FileName);
                    webBrowser1.Document.InvokeScript("SetText", new object[]
                    {
                          MainText
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folderPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Scripts"));
            if (Directory.Exists(folderPath) == false)
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }
            webBrowser1.Document.InvokeScript("SetText", new object[] { File.ReadAllText($"./Scripts/{Scripts.SelectedItem}") });
        }

        private void ScriptHubTab_Click(object sender, EventArgs e)
        {
            ScriptHub.Visible = true;
        }

        private void ExecutionTab_Click(object sender, EventArgs e)
        {
            ScriptHub.Visible = false;
        }

        private void OptionsTab_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OptionsOpen == false)
            {
                Options openform = new Options();
                openform.Show();
                Properties.Settings.Default.OptionsOpen = true;
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CreditsOpen == false)
            {
                Credits openform = new Credits();
                openform.Show();
                Properties.Settings.Default.CreditsOpen = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("SetTheme", new object[] { "synapse" });
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            Scripts.Items.Clear();
            Functions.PopulateListBox(Scripts, "Scripts", "*.lua");
            Functions.PopulateListBox(Scripts, "Scripts", "*.txt");
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("SetText", new object[] { "" });
            ClearConfirmation.Visible = false;
            Yes.Visible = false;
            No.Visible = false;
        }

        private void No_Click(object sender, EventArgs e)
        {
            ClearConfirmation.Visible = false;
            Yes.Visible = false;
            No.Visible = false;
        }
    }
}