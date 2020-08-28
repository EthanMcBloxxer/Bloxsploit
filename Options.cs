using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloxsploit
{
    public partial class Options : Form
    {
        Point lastPoint;
        public Options()
        {
            InitializeComponent();
            SettingCheck();
            if (Properties.Settings.Default.OnTop == true)
            {
                this.TopMost = true;
                AlwaysOnTop.Checked = true;
            }
            else
            {
                this.TopMost = false;
                AlwaysOnTop.Checked = false;
            }
            if (Properties.Settings.Default.AutoAttach == true)
            {
                AutoAttach.Checked = true;
            }
            else
            {
                AutoAttach.Checked = false;
            }
            if (Properties.Settings.Default.Fade == true) 
            {
                Fade.Checked = true;
            }
            else
            {
                Fade.Checked = false;
            }

            if (Properties.Settings.Default.API == "WeAreDevs")
            {
                WeAreDevs.Checked = true;
            }
            if (Properties.Settings.Default.API == "EasyExploits")
            {
                EasyXploits.Checked = true;
            }
            if (Properties.Settings.Default.API == "CheatSquad")
            {
                CheatSquad.Checked = true;
            }
        }

        private void SettingCheck()
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(53, 53, 53);
                panel1.BackColor = Color.FromArgb(72, 72, 72);
            }

            else if (Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(202, 202, 202);
                panel1.BackColor = Color.FromArgb(183, 183, 183);

                KillRoblox.ForeColor = Color.Black;
                DiscordServer.ForeColor = Color.Black;
                Obfuscater.ForeColor = Color.Black;
                AltGen.ForeColor = Color.Black;
                AlwaysOnTop.ForeColor = Color.Black;
                Fade.ForeColor = Color.Black;
                BoostFPS.ForeColor = Color.Black;
                Changelog.ForeColor = Color.Black;
                SHTitle.ForeColor = Color.Black;
                Title.ForeColor = Color.Black;
                Themes.ForeColor = Color.Black;
                AutoAttach.ForeColor = Color.Black;
                APISettings.ForeColor = Color.Black;
                EasyXploits.ForeColor = Color.Black;
                WeAreDevs.ForeColor = Color.Black;
                Changelog.ForeColor = Color.Black;
                BloxsploitChangelog.ForeColor = Color.Black;
                CloseWindow.BackgroundImage = Properties.Resources.BlackClose;
            }

            else if (Properties.Settings.Default.Theme == "Black")
            {
                this.BackColor = Color.FromArgb(27, 27, 27);
                panel1.BackColor = Color.FromArgb(41, 41, 41);
            }

            else if (Properties.Settings.Default.Theme == "Red")
            {
                this.BackColor = Color.FromArgb(124, 35, 36);
                panel1.BackColor = Color.FromArgb(143, 52, 53);
            }

            else if (Properties.Settings.Default.Theme == "Purple")
            {
                this.BackColor = Color.FromArgb(109, 53, 91);
                panel1.BackColor = Color.FromArgb(131, 72, 131);
            }

            else if (Properties.Settings.Default.Theme == "Green")
            {
                this.BackColor = Color.FromArgb(3, 85, 3);
                panel1.BackColor = Color.FromArgb(8, 105, 8);
            }
            if (Properties.Settings.Default.Theme != "Light")
            {
                KillRoblox.ForeColor = Color.White;
                DiscordServer.ForeColor = Color.White;
                Obfuscater.ForeColor = Color.White;
                AltGen.ForeColor = Color.White;
                AlwaysOnTop.ForeColor = Color.White;
                Fade.ForeColor = Color.White;
                BoostFPS.ForeColor = Color.White;
                Changelog.ForeColor = Color.White;
                SHTitle.ForeColor = Color.White;
                Title.ForeColor = Color.White;
                Themes.ForeColor = Color.White;
                AutoAttach.ForeColor = Color.White;
                APISettings.ForeColor = Color.White;
                EasyXploits.ForeColor = Color.White;
                WeAreDevs.ForeColor = Color.White;
                Changelog.ForeColor = Color.White;
                BloxsploitChangelog.ForeColor = Color.White;
                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
            }

            CloseWindow.BackColor = panel1.BackColor;
            Logo.BackColor = panel1.BackColor;

            // Buttons
            AlwaysOnTop.BackColor = this.BackColor;
            Fade.BackColor = this.BackColor;
            BoostFPS.BackColor = this.BackColor;
            Changelog.BackColor = this.BackColor;
            AutoAttach.BackColor = this.BackColor;
            APISettings.BackColor = this.BackColor;

            // Not-Buttons
            Themes.BackColor = panel1.BackColor;
            Title.BackColor = panel1.BackColor;
            SHTitle.BackColor = panel1.BackColor;
            KillRoblox.BackColor = panel1.BackColor;
            DiscordServer.BackColor = panel1.BackColor;
            Obfuscater.BackColor = panel1.BackColor;
            AltGen.BackColor = panel1.BackColor;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OptionsOpen = false;
            this.Close();
        }

        private void SHTitle_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SHTitle_MouseMove(object sender, MouseEventArgs e)
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

        private void AutoAttach_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoAttach.Checked == true)
            {
                Properties.Settings.Default.AutoAttach = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AutoAttach = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Obfuscater_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://obfuscator.aztupscripts.xyz/Home");
        }

        private void AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (AlwaysOnTop.Checked == true)
            {
                Properties.Settings.Default.OnTop = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.OnTop = false;
                Properties.Settings.Default.Save();
            }
        }
        private void KillRoblox_Click(object sender, EventArgs e)
        {
            if (Functions.NamedPipeExist(Functions.EasyExploitsPipe))
            {
                foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    pc.Kill();
                }
            }
        }

        private void DiscordServer_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/qhgRFQw");
        }

        private void FPSUnlocker_Click(object sender, EventArgs e)
        {
            Process.Start("https://altgen.club/");
        }

        private void WeAreDevs_CheckedChanged(object sender, EventArgs e)
        {
            if (WeAreDevs.Checked == true)
            {
                Properties.Settings.Default.API = "WeAreDevs";
                Properties.Settings.Default.Save();
            }
        }

        private void EasyXploits_CheckedChanged(object sender, EventArgs e)
        {
            if (EasyXploits.Checked == true)
            {
                Properties.Settings.Default.API = "EasyExploits";
                Properties.Settings.Default.Save();
            }
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BoostFPS_CheckedChanged(object sender, EventArgs e)
        {
            if (File.Exists(@".\rbxfpsunlocker.exe"))
            {
                if (BoostFPS.Checked == true)
                {
                    Process.Start(@".\rbxfpsunlocker.exe");
                }
            }
            else
            {
                if (BoostFPS.Checked == true)
                {
                    using (var client = new WebClient())
                    { client.DownloadFile("https://github.com/axstin/rbxfpsunlocker/files/4200559/rbxfpsunlocker-x64.zip", "rbxfpsunlocker-x64.zip"); }
                    ZipFile.ExtractToDirectory(@".\rbxfpsunlocker-x64.zip", @".\");
                    Thread.Sleep(100);
                    File.Delete(@".\rbxfpsunlocker-x64.zip");
                }
            }
            if (BoostFPS.Checked == false)
            {
                foreach (Process pc in Process.GetProcessesByName("rbxfpsunlocker"))
                {
                    pc.Kill();
                }
                File.Delete(@".\rbxfpsunlocker.exe");
            }
        }

        private void Themes_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ThemesOpen == false)
            {
                Themes openform = new Themes();
                openform.Show();
                Properties.Settings.Default.ThemesOpen = true;
            }
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Fade_CheckedChanged(object sender, EventArgs e)
        {
            if (Fade.Checked == true)
            {
                Properties.Settings.Default.Fade = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Fade = false;
                Properties.Settings.Default.Save();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SettingCheck();
        }

        private void CheatSquad_CheckedChanged(object sender, EventArgs e)
        {
            if (CheatSquad.Checked == true)
            {
                Properties.Settings.Default.API = "CheatSquad";
                Properties.Settings.Default.Save();
            }
        }
    }
}
