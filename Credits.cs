using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloxsploit
{
    public partial class Credits : Form
    {
        Point lastPoint;
        public Credits()
        {
            InitializeComponent();
            SettingCheck();
        }
        private void SettingCheck()
        {
            if (Properties.Settings.Default.OnTop == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(53, 53, 53);
                TitleBar.BackColor = Color.FromArgb(72, 72, 72);
            }

            else if (Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(202, 202, 202);
                TitleBar.BackColor = Color.FromArgb(183, 183, 183);

                Title.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                Creator.ForeColor = Color.Black;
                EthanMcBloxxer.ForeColor = Color.Black;
                Designer.ForeColor = Color.Black;
                Axel.ForeColor = Color.Black;
                APIDevelopers.ForeColor = Color.Black;
                APIDevelopersBody.ForeColor = Color.Black;
                OpenGamerTips.ForeColor = Color.Black;
                AntiBanwave.ForeColor = Color.Black;

                CloseWindow.BackgroundImage = Properties.Resources.BlackClose;
            }

            else if (Properties.Settings.Default.Theme == "Black")
            {
                this.BackColor = Color.FromArgb(27, 27, 27);
                TitleBar.BackColor = Color.FromArgb(41, 41, 41);
            }

            else if (Properties.Settings.Default.Theme == "Red")
            {
                this.BackColor = Color.FromArgb(124, 35, 36);
                TitleBar.BackColor = Color.FromArgb(143, 52, 53);
            }

            else if (Properties.Settings.Default.Theme == "Purple")
            {
                this.BackColor = Color.FromArgb(109, 53, 91);
                TitleBar.BackColor = Color.FromArgb(131, 72, 131);
            }

            else if (Properties.Settings.Default.Theme == "Green")
            {
                this.BackColor = Color.FromArgb(3, 85, 3);
                TitleBar.BackColor = Color.FromArgb(8, 105, 8);
            }

            if (Properties.Settings.Default.Theme != "Light")
            {
                Title.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                Creator.ForeColor = Color.White;
                EthanMcBloxxer.ForeColor = Color.White;
                Designer.ForeColor = Color.White;
                Axel.ForeColor = Color.White;
                APIDevelopers.ForeColor = Color.White;
                APIDevelopersBody.ForeColor = Color.White;
                OpenGamerTips.ForeColor = Color.White;
                AntiBanwave.ForeColor = Color.White;

                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
            }

            CloseWindow.BackColor = TitleBar.BackColor;
            Logo.BackColor = TitleBar.BackColor;

            Title.BackColor = TitleBar.BackColor;
            label1.BackColor = TitleBar.BackColor;

            Creator.BackColor = this.BackColor;
            EthanMcBloxxer.BackColor = this.BackColor;
            Designer.BackColor = this.BackColor;
            Axel.BackColor = this.BackColor;
            APIDevelopers.BackColor = this.BackColor;
            APIDevelopersBody.BackColor = this.BackColor;
            OpenGamerTips.BackColor = this.BackColor;
            AntiBanwave.BackColor = this.BackColor;
        }
        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CreditsOpen = false;
            this.Close();
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
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

        private void timer_Tick(object sender, EventArgs e)
        {
            SettingCheck();
        }
    }
}
