using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using EasyExploits;
using System.Linq.Expressions;
using xDialog;
using Bloxsploit.Properties;

namespace Bloxsploit
{
    public partial class Main : Form
    {
        readonly string CurrentVersion = "1.0.0";
        readonly string CondencedVersion = "1.0";

        readonly string programPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        readonly NeuronAPI.Exploit WeAreDevsAPI = new NeuronAPI.Exploit();
        readonly EasyExploits.Module EasyExploitsAPI = new EasyExploits.Module();
        readonly CheatSquadAPI.Module CSAPI = new CheatSquadAPI.Module();

        readonly string Domain = "http://localhost/";

        bool WRDExists = true;
        bool EXExists = true;

        public Main()
        {
            Debug.Write("Thanks to various Flaticon artists.\n");
            if (!File.Exists(@".\WRDMod.dll"))
            {
                WRDExists = false;
            }
            if (!File.Exists(@".\EasyExploits.dll"))
            {
                EXExists = false;
            }
            if (WRDExists == false && EXExists == false)
            {
                DialogResult ErrorMessage = MsgBox.Show("Neither API DLL exist. Press OK to install them.", "Bloxsploit Error", MsgBox.Buttons.OKCancel, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                if (ErrorMessage == DialogResult.OK)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFileAsync(new Uri(Domain + "WeAreDevs_API.dll"), "WeAreDevs_API.dll");
                        wc.DownloadFileAsync(new Uri(Domain + "EasyExploits.dll"), "EasyExploits.dll");
                        Thread.Sleep(500);
                    }
                }
            }
            else if (WRDExists == false)
            {
                DialogResult ErrorMessage = MsgBox.Show("The WRD API DLL does not exist. Press OK to install it.", "Bloxsploit Error", MsgBox.Buttons.OKCancel, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                if (ErrorMessage == DialogResult.OK)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFileAsync(new Uri(Domain + "WeAreDevs_API.dll"), "WeAreDevs_API.dll");
                        Thread.Sleep(500);
                    }
                }
            }
            else if (EXExists == false)
            {
                DialogResult ErrorMessage = MsgBox.Show("The EX DLL does not exist. Press OK to install it.", "Bloxsploit Error", MsgBox.Buttons.OKCancel, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                if (ErrorMessage == DialogResult.OK)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFileAsync(new Uri(Domain + "EasyExploits.dll"), "EasyExploits.dll");
                        Thread.Sleep(500);
                    }
                }
            }

            GetMissingFiles();

            Properties.Settings.Default.ScriptHubOpen = false;
            Properties.Settings.Default.OptionsOpen = false;
            Properties.Settings.Default.CreditsOpen = false;
            Properties.Settings.Default.ThemesOpen = false;
            
            if (File.Exists(@".\BloxsploitUpdater.exe"))
            {
                File.Delete(@".\BloxsploitUpdater.exe");
            }
            try
            {
                WebClient wb = new WebClient();
                string LatestVersion = wb.DownloadString("https://pastebin.com/raw/au0CjfCS");
                if (CurrentVersion != LatestVersion)
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFileAsync(new Uri(Domain + "BloxsploitUpdater.exe"), "BloxsploitUpdater.exe");
                        Thread.Sleep(5000);
                        Process.Start(@".\BloxsploitUpdater.exe");
                    }
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MsgBox.Show("Bloxsploit cannot check if you are outdated. This can happen if either pastebin.com is down, or you do not have access to the internet. If you continue the usage of Bloxsploit may be limited and Bloxsploit may throw many errors.", "Bloxsploit Error", MsgBox.Buttons.OK, MsgBox.Icon.Warning, MsgBox.AnimateStyle.FadeIn);
            }

            try
            {
                using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                {
                    w.WriteLine("# Anti-Banwave Code");
                    w.WriteLine("127.0.0.1 data.roblox.com");
                    w.WriteLine("127.0.0.1 roblox.sp.backtrace.io");
                }
            }
            catch (Exception)
            {
                
            }

            if (Properties.Settings.Default.Theme == "Synapse")
            {
                SynapseUI openform = new SynapseUI();
                openform.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else if (Properties.Settings.Default.Theme == "Colorful")
            {
                UltraModern openform = new UltraModern();
                openform.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MakeScripts();
                InitializeComponent();
                SettingCheck();
                AttachExploit();

                DirectoryInfo dinfo = new DirectoryInfo("AutoExecute");
                FileInfo[] TxtFiles = dinfo.GetFiles(".txt");
                foreach (FileInfo file in TxtFiles)
                {
                    ExecuteExploit(file.Name);
                }
                FileInfo[] LuaFiles = dinfo.GetFiles(".lua");
                foreach (FileInfo file in LuaFiles)
                {
                    ExecuteExploit(file.Name);
                }

                Functions.PopulateListBox(Scripts, "Scripts", "*.lua");
                Functions.PopulateListBox(Scripts, "Scripts", "*.txt");

                Version.Text = "v" + CondencedVersion;

                timer.Start();
                refresher.Start();
                
                tooltip.SetToolTip(CloseWindow, "Close");
                tooltip.SetToolTip(Minimize, "Minimize");
                tooltip.SetToolTip(Logo, "Credits");
                Task.Delay(1000);
            }
        }
        Point lastPoint;
        public async void AttachExploit()
        {
            if (Properties.Settings.Default.API == "WeAreDevs")
            {
                if (!WeAreDevsAPI.IsAPIAttached())
                {
                    await WeAreDevsAPI.AttachExploit(null, "\\Bin", "\\Workspace");
                }
            }
            if (Properties.Settings.Default.API == "EasyExploits")
            {
                if (!Functions.NamedPipeExist(Functions.EasyExploitsPipe))
                {
                    foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                    {
                        if (!File.Exists(@".\injection.exe"))
                        {
                            using (WebClient wc = new WebClient())
                            {
                                wc.DownloadFileAsync(new Uri(Domain + "injection.exe"), "injection.exe");
                            }
                        }
                        else
                        {
                            try
                            {
                                Process.Start(@".\injection.exe", "EasyExploits");
                            }
                            catch (Exception error)
                            {
                                MsgBox.Show("Bloxsploit failed to run the injection.exe file. Error: " + error.Message, "Bloxsploit Error", MsgBox.Buttons.RetryCancel, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                            }
                        }
                    }
                }
            }
            if (Properties.Settings.Default.API == "CheatSquad")
            {
                foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    CSAPI.Attach();
                }
            }
        }
        public static void ExecuteExploit(string Script)
        {
            NeuronAPI.Exploit WeAreDevsAPI = new NeuronAPI.Exploit();
            EasyExploits.Module EasyExploitsAPI = new EasyExploits.Module();
            CheatSquadAPI.Module CSAPI = new CheatSquadAPI.Module();
            if (Properties.Settings.Default.API == "WeAreDevs")
            {
                if (WeAreDevsAPI.IsAPIAttached() == true)
                {
                    foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                    {
                        WeAreDevsAPI.ExecuteLua(Script);
                    }
                }
            }
            if (Properties.Settings.Default.API == "EasyExploits")
            {
                if (Functions.NamedPipeExist(Functions.EasyExploitsPipe))
                {
                    foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                    {
                        EasyExploitsAPI.ExecuteScript(Script);
                    }
                }
            }
            if (Properties.Settings.Default.API == "CheatSquad")
            {
                foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    CSAPI.Execute(Script);
                }
            }
        }
        private async void SettingCheck()
        {
            if (Properties.Settings.Default.AutoAttach == true)
            {
                if (!Functions.NamedPipeExist(Functions.EasyExploitsPipe))
                {
                    foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                    {
                        AttachExploit();
                    }
                }
            }

            if (Properties.Settings.Default.OnTop == true)
            {
                await Task.Delay(100);
                if (this.TopMost == false)
                {
                    this.TopMost = true;
                }
            }
            else if (Properties.Settings.Default.OnTop == false)
            {
                await Task.Delay(100);
                if (this.TopMost == true)
                {
                    this.TopMost = false;
                }
            }

            if (Properties.Settings.Default.Fade == false)
            {
                this.AllowTransparency = true;
                this.Opacity = 1.00;
            }
            
            if (Properties.Settings.Default.Theme == "Dark")
            {
                // panel recoloring
                TitleBar.BackColor = Color.FromArgb(72, 72, 72);
                ButtonPanel.BackColor = Color.FromArgb(46, 46, 46);

                // image back recoloring
                CloseWindow.BackColor = Color.FromArgb(72, 72, 72);
                Minimize.BackColor = Color.FromArgb(72, 72, 72);
                Logo.BackColor = Color.FromArgb(72, 72, 72);
                Pastebin.BackColor = Color.FromArgb(53, 53, 53);

                // image front recoloring
                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
                Minimize.BackgroundImage = Properties.Resources.WhiteMinimize;

                // text recoloring
                Attach.ForeColor = Color.White;
                ScriptHub.ForeColor = Color.White;
                Execute.ForeColor = Color.White;
                Title.ForeColor = Color.White;
                Options.ForeColor = Color.White;
                Save.ForeColor = Color.White;
                Open.ForeColor = Color.White;
                Version.ForeColor = Color.White;

                // button recoloring
                Attach.BackColor = Color.FromArgb(72, 72, 72);
                ScriptHub.BackColor = Color.FromArgb(72, 72, 72);
                Execute.BackColor = Color.FromArgb(72, 72, 72);
                Options.BackColor = Color.FromArgb(72, 72, 72);
                Save.BackColor = Color.FromArgb(65, 60, 60);
                Open.BackColor = Color.FromArgb(65, 60, 60);

                // scripts recolor
                Scripts.BackColor = Color.FromArgb(65, 60, 60);

                // invert monaco
                webBrowser1.Document.InvokeScript("SetTheme", new object[] { "defaultDark" });
            }

            else if (Properties.Settings.Default.Theme == "Light")
            {
                // panel recoloring
                TitleBar.BackColor = Color.FromArgb(183, 183, 183);
                ButtonPanel.BackColor = Color.FromArgb(209, 209, 209);

                // image back recoloring
                CloseWindow.BackColor = Color.FromArgb(183, 183, 183);
                Minimize.BackColor = Color.FromArgb(183, 183, 183);
                Logo.BackColor = Color.FromArgb(183, 183, 183);
                Pastebin.BackColor = Color.FromArgb(202, 202, 202);

                // image front recoloring
                CloseWindow.BackgroundImage = Properties.Resources.BlackClose;
                Minimize.BackgroundImage = Properties.Resources.BlackMinimize;

                // text recoloring
                Attach.ForeColor = Color.Black;
                ScriptHub.ForeColor = Color.Black;
                Execute.ForeColor = Color.Black;
                Title.ForeColor = Color.Black;
                Options.ForeColor = Color.Black;
                Save.ForeColor = Color.Black;
                Open.ForeColor = Color.Black;
                Version.ForeColor = Color.Black;

                // button recoloring
                Attach.BackColor = Color.FromArgb(183, 183, 183);
                ScriptHub.BackColor = Color.FromArgb(183, 183, 183);
                Execute.BackColor = Color.FromArgb(183, 183, 183);
                Options.BackColor = Color.FromArgb(183, 183, 183);
                Save.BackColor = Color.FromArgb(190, 195, 195);
                Open.BackColor = Color.FromArgb(190, 195, 195);

                // scripts recolor
                Scripts.BackColor = Color.FromArgb(190, 195, 195);

                // invert monaco
                webBrowser1.Document.InvokeScript("SetTheme", new object[] { "defaultLight" });
            }

            else if (Properties.Settings.Default.Theme == "Black")
            {
                // panel recoloring
                TitleBar.BackColor = Color.FromArgb(41, 41, 41);
                ButtonPanel.BackColor = Color.FromArgb(22, 22, 22);

                // image back recoloring
                CloseWindow.BackColor = Color.FromArgb(41, 41, 41);
                Minimize.BackColor = Color.FromArgb(41, 41, 41);
                Logo.BackColor = Color.FromArgb(41, 41, 41);
                Pastebin.BackColor = Color.FromArgb(27, 27, 27);

                // image front recoloring
                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
                Minimize.BackgroundImage = Properties.Resources.WhiteMinimize;

                // text recoloring
                Attach.ForeColor = Color.White;
                ScriptHub.ForeColor = Color.White;
                Execute.ForeColor = Color.White;
                Title.ForeColor = Color.White;
                Options.ForeColor = Color.White;
                Save.ForeColor = Color.White;
                Open.ForeColor = Color.White;
                Version.ForeColor = Color.White;

                // button recoloring
                Attach.BackColor = Color.FromArgb(41, 41, 41);
                ScriptHub.BackColor = Color.FromArgb(41, 41, 41);
                Execute.BackColor = Color.FromArgb(41, 41, 41);
                Options.BackColor = Color.FromArgb(41, 41, 41);
                Save.BackColor = Color.FromArgb(36, 32, 32);
                Open.BackColor = Color.FromArgb(36, 32, 32);

                // scripts recolor
                Scripts.BackColor = Color.FromArgb(36, 32, 32);

                // invert monaco
                webBrowser1.Document.InvokeScript("SetTheme", new object[] { "defaultBlack" });
            }

            else if (Properties.Settings.Default.Theme == "Red")
            {
                // panel recoloring
                TitleBar.BackColor = Color.FromArgb(143, 52, 53);
                ButtonPanel.BackColor = Color.FromArgb(117, 29, 30);

                // image back recoloring
                CloseWindow.BackColor = Color.FromArgb(143, 52, 53);
                Minimize.BackColor = Color.FromArgb(143, 52, 53);
                Logo.BackColor = Color.FromArgb(143, 52, 53);
                Pastebin.BackColor = Color.FromArgb(124, 35, 36);

                // image front recoloring
                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
                Minimize.BackgroundImage = Properties.Resources.WhiteMinimize;

                // text recoloring
                Attach.ForeColor = Color.White;
                ScriptHub.ForeColor = Color.White;
                Execute.ForeColor = Color.White;
                Title.ForeColor = Color.White;
                Options.ForeColor = Color.White;
                Save.ForeColor = Color.White;
                Open.ForeColor = Color.White;
                Version.ForeColor = Color.White;

                // button recoloring
                Attach.BackColor = Color.FromArgb(143, 52, 53);
                ScriptHub.BackColor = Color.FromArgb(143, 52, 53);
                Execute.BackColor = Color.FromArgb(143, 52, 53);
                Options.BackColor = Color.FromArgb(143, 52, 53);
                Save.BackColor = Color.FromArgb(136, 41, 42);
                Open.BackColor = Color.FromArgb(136, 41, 42);

                // scripts recolor
                Scripts.BackColor = Color.FromArgb(136, 41, 42);

                // invert monaco
                webBrowser1.Document.InvokeScript("SetTheme", new object[] { "defaultRed" });
            }

            else if (Properties.Settings.Default.Theme == "Purple")
            {
                // panel recoloring
                TitleBar.BackColor = Color.FromArgb(131, 72, 131);
                ButtonPanel.BackColor = Color.FromArgb(104, 46, 104);

                // image back recoloring
                CloseWindow.BackColor = Color.FromArgb(131, 72, 131);
                Minimize.BackColor = Color.FromArgb(131, 72, 131);
                Logo.BackColor = Color.FromArgb(131, 72, 131);
                Pastebin.BackColor = Color.FromArgb(109, 53, 91);

                // image front recoloring
                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
                Minimize.BackgroundImage = Properties.Resources.WhiteMinimize;

                // text recoloring
                Attach.ForeColor = Color.White;
                ScriptHub.ForeColor = Color.White;
                Execute.ForeColor = Color.White;
                Title.ForeColor = Color.White;
                Options.ForeColor = Color.White;
                Save.ForeColor = Color.White;
                Open.ForeColor = Color.White;
                Version.ForeColor = Color.White;

                // button recoloring
                Attach.BackColor = Color.FromArgb(131, 72, 131);
                ScriptHub.BackColor = Color.FromArgb(131, 72, 131);
                Execute.BackColor = Color.FromArgb(131, 72, 131);
                Options.BackColor = Color.FromArgb(131, 72, 131);
                Save.BackColor = Color.FromArgb(122, 60, 99);
                Open.BackColor = Color.FromArgb(122, 60, 99);

                // scripts recolor
                Scripts.BackColor = Color.FromArgb(122, 60, 99);

                // invert monaco
                webBrowser1.Document.InvokeScript("SetTheme", new object[] { "defaultPurple" });
            }

            else if (Properties.Settings.Default.Theme == "Green")
            {
                // panel recoloring
                TitleBar.BackColor = Color.FromArgb(8, 105, 8);
                ButtonPanel.BackColor = Color.FromArgb(2, 77, 2);

                // image back recoloring
                CloseWindow.BackColor = Color.FromArgb(8, 105, 8);
                Minimize.BackColor = Color.FromArgb(8, 105, 8);
                Logo.BackColor = Color.FromArgb(8, 105, 8);
                Pastebin.BackColor = Color.FromArgb(3, 85, 3);

                // image front recoloring
                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
                Minimize.BackgroundImage = Properties.Resources.WhiteMinimize;

                // text recoloring
                Attach.ForeColor = Color.White;
                ScriptHub.ForeColor = Color.White;
                Execute.ForeColor = Color.White;
                Title.ForeColor = Color.White;
                Options.ForeColor = Color.White;
                Save.ForeColor = Color.White;
                Open.ForeColor = Color.White;
                Version.ForeColor = Color.White;

                // button recoloring
                Attach.BackColor = Color.FromArgb(8, 105, 8);
                ScriptHub.BackColor = Color.FromArgb(8, 105, 8);
                Execute.BackColor = Color.FromArgb(8, 105, 8);
                Options.BackColor = Color.FromArgb(8, 105, 8);
                Save.BackColor = Color.FromArgb(6, 93, 5);
                Open.BackColor = Color.FromArgb(6, 93, 5);

                // scripts recolor
                Scripts.BackColor = Color.FromArgb(6, 93, 5);

                // invert monaco
                webBrowser1.Document.InvokeScript("SetTheme", new object[] { "defaultGreen" });
            }

            if (Properties.Settings.Default.BackgroundUrl != null)
            {
                webBrowser1.Document.InvokeScript("SetImage", new object[] { Properties.Settings.Default.BackgroundUrl });
            }
        }

        private async void FadeIn(Form o, int interval = 80)
        {
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1;    
        }

        private async void FadeOut(Form o, int interval = 80)
        {
            while (o.Opacity > 0.45)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0.45;
        }

        private void Options_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OptionsOpen == false)
            {
                Options openform = new Options();
                openform.Show();
                Properties.Settings.Default.OptionsOpen = true;
            }
        }

        private void Scriptbox_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            MakeScripts();
            SaveFileDialog openDialog = new SaveFileDialog
            {
                InitialDirectory = Path.GetFullPath(Path.Combine(programPath, "Scripts")),
                Filter = "Lua Source Files (*.lua)|*.lua|Text Documents (*.txt)|*.txt",
                RestoreDirectory = true
            };
            string TextToSave = webBrowser1.Document.InvokeScript("GetText", new string[0]).ToString();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!File.Exists(openDialog.FileName))
                    {
                        File.WriteAllText(openDialog.FileName, TextToSave);
                    }
                    else
                    {
                        File.WriteAllText(openDialog.FileName, TextToSave);
                    }
                }
                catch (Exception er)
                {
                    MsgBox.Show("An error has occured when trying to save your file. Try again, or do it manually. \nError: " + er.Message, "Bloxsploit Error", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }
            }
        }

        private void Scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeScripts();
            try 
            { 
                webBrowser1.Document.InvokeScript("SetText", new object[] { File.ReadAllText($"./Scripts/{Scripts.SelectedItem}") });
                Scripts.ClearSelected();
            }
            catch
            {

            }
        }
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Execute.Text = "Executing...";
            string script = webBrowser1.Document.InvokeScript("GetText", new string[0]).ToString();
            ExecuteExploit(script);
            Execute.Text = "Execute";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            MakeScripts();
            OpenFileDialog openDialog = new OpenFileDialog
            {
                InitialDirectory = Path.GetFullPath(Path.Combine(programPath, "Scripts")),
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

        private void Attach_Click(object sender, EventArgs e)
        {
            Attach.Text = "Attaching...";
            AttachExploit();
            Thread.Sleep(1000);
            Attach.Text = "Attach";
        }

        private async void CloseWindow_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Dark" || Properties.Settings.Default.Theme == "Light" || Properties.Settings.Default.Theme == "Black" || Properties.Settings.Default.Theme == "Red" || Properties.Settings.Default.Theme == "Purple" || Properties.Settings.Default.Theme == "Green")
            {
                string programPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string easyExploitsDllPath = Path.GetFullPath(Path.Combine(programPath, "EasyExploitsDLL.dll"));
                string wrdDllPath = Path.GetFullPath(Path.Combine(programPath, "exploit-main.dll"));
                File.Delete(easyExploitsDllPath);
                File.Delete(wrdDllPath);
                while (this.Opacity > 0.00)
                {
                    await Task.Delay(10);
                    this.Opacity -= 0.05;
                }
                this.Opacity = 0.00;
                while (this.Opacity != 0.00)
                {
                    await Task.Delay(1);
                }
                Application.Exit();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void TitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ScriptHub_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ScriptHubOpen == false)
            {
                ScriptHubWindow openform = new ScriptHubWindow();
                openform.Show();
                Properties.Settings.Default.ScriptHubOpen = true;
            }
        }
        private void label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CreditsOpen == false)
            {
                Credits openform = new Credits();
                openform.Show();
                Properties.Settings.Default.CreditsOpen = true;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
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
            webBrowser1.Document.InvokeScript("SetTheme", new object[] {"defaultDark"} );
            var desktopWorkingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
        }
        public void MakeScripts()
        {
            if (!Directory.Exists(@".\Scripts"))
            {
               Directory.CreateDirectory(@".\Scripts");
            }
            if (!Directory.Exists(@".\AutoExecute"))
            {
                Directory.CreateDirectory(@".\AutoExecute");
            }
        }
        public async void GetMissingFiles()
        {
            if (!File.Exists(@".\WeAreDevs_API.dll"))
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileAsync(new Uri(Domain + "WeAreDevs_API.dll"), "WeAreDevs_API.dll");
                }
            }
            if (!File.Exists(@".\EasyExploits.dll"))
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileAsync(new Uri(Domain + "EasyExploits.dll"), "EasyExploits.dll");
                }
            }
            if (!Directory.Exists(@".\Editor"))
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileAsync(new Uri(Domain + "Editor.zip"), "Editor.zip");
                    await Task.Delay(400);
                    System.IO.Compression.ZipFile.ExtractToDirectory(@".\Editor.zip", @".\");
                    await Task.Delay(800);
                    if (File.Exists(@".\Editor.zip"))
                    {
                        File.Delete(@".\Editor.zip");
                    }
                }
            }
            if (!Directory.Exists(@".\Scripts"))
            {
                Directory.CreateDirectory(@".\Scripts");
            }
            if (!Directory.Exists(@".\AutoExecute"))
            {
                Directory.CreateDirectory(@".\AutoExecute");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SettingCheck();
        }

        private void Version_MouseEnter(object sender, EventArgs e)
        {
            Version.Text = "v" + CurrentVersion;
        }

        private void Version_MouseLeave(object sender, EventArgs e)
        {
            Version.Text = "v" + CondencedVersion;
        }

        private void Pastebin_Click(object sender, EventArgs e)
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object[] args = new string[0];
            object obj = document.InvokeScript(scriptName, args);
            string script = obj.ToString();
            PastebinRequest openform = new PastebinRequest(script);
            openform.ShowDialog();
        }

        private void refresher_Tick(object sender, EventArgs e)
        {
            Scripts.Items.Clear();
            Functions.PopulateListBox(Scripts, "Scripts", "*.lua");
            Functions.PopulateListBox(Scripts, "Scripts", "*.txt");
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Insert:
                    if (!Functions.NamedPipeExist(Functions.EasyExploitsPipe))
                    {
                        AttachExploit();
                    }
                    WebClient wb = new WebClient();
                    string Script = wb.DownloadString("https://pastebin.com/raw/eJesK5gJ");
                    ExecuteExploit(Script);
                break;
            }
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Fade == true)
            {
                FadeOut(this, 5);
            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Fade == true)
            {
                FadeIn(this, 5);
            }
        }
    }
}