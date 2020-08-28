using Bloxsploit.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bloxsploit
{
    public partial class Themes : Form
    {
        public Themes()
        {
            InitializeComponent();
            SettingCheck();
        }
        Point lastPoint;

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

                Dark.ForeColor = Color.Black;
                Light.ForeColor = Color.Black;
                Black.ForeColor = Color.Black;
                Red.ForeColor = Color.Black;
                Purple.ForeColor = Color.Black;
                Green.ForeColor = Color.Black;
                Synapse.ForeColor = Color.Black;
                SynapseLegacy.ForeColor = Color.Black;
                Colorful.ForeColor = Color.Black;
                Title.ForeColor = Color.Black;
                Theme.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;

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
                Dark.ForeColor = Color.White;
                Light.ForeColor = Color.White;
                Black.ForeColor = Color.White;
                Red.ForeColor = Color.White;
                Purple.ForeColor = Color.White;
                Green.ForeColor = Color.White;
                Synapse.ForeColor = Color.White;
                SynapseLegacy.ForeColor = Color.White;
                Colorful.ForeColor = Color.White;
                Title.ForeColor = Color.White;
                Theme.ForeColor = Color.White;
                label1.ForeColor = Color.White;

                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
            }

            CloseWindow.BackColor = panel1.BackColor;
            Logo.BackColor = panel1.BackColor;

            // Buttons
            Dark.BackColor = panel1.BackColor;
            Light.BackColor = panel1.BackColor;
            Black.BackColor = panel1.BackColor;
            Red.BackColor = panel1.BackColor;
            Purple.BackColor = panel1.BackColor;
            Green.BackColor = panel1.BackColor;
            Synapse.BackColor = panel1.BackColor;
            SynapseLegacy.BackColor = panel1.BackColor;
            Colorful.BackColor = panel1.BackColor;
            richTextBox1.BackColor = panel1.BackColor;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundUrl = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThemesOpen = false;
            this.Close();
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

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Theme_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Theme_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Synapse_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Synapse";
            Properties.Settings.Default.Save();
            SynapseUI openform = new SynapseUI();
            openform.Show();
        }

        private void Light_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Light";
            Properties.Settings.Default.Save();
        }

        private void Dark_Click(object sender, EventArgs e)
        {


            Properties.Settings.Default.Theme = "Dark";
            Properties.Settings.Default.Save();
        }

        private void Black_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Black";
            Properties.Settings.Default.Save();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Red";
            Properties.Settings.Default.Save();
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Purple";
            Properties.Settings.Default.Save();
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Green";
            Properties.Settings.Default.Save();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SettingCheck();
        }

        private void Colorful_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Colorful";
            Properties.Settings.Default.Save();
            UltraModern openform = new UltraModern();
            openform.Show();
        }
    }
}
