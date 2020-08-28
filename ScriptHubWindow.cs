using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloxsploit
{
    public partial class ScriptHubWindow : Form
    {
        readonly NeuronAPI.Exploit WeAreDevsAPI = new NeuronAPI.Exploit();
        readonly EasyExploits.Module EasyExploitsAPI = new EasyExploits.Module();

        Point lastPoint;
        public ScriptHubWindow()
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
        private void SHTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/9UtBscMx");
            ExecuteExploit(Script);
        }

        private void T0PK3K_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/3DtM3zAx");
            ExecuteExploit(Script);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IY_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
            ExecuteExploit(Script);
        }

        private void Reviz_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ibFPdiF7");
            ExecuteExploit(Script);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExecuteExploit("game.Players.LocalPlayer.Character.Humanoid.JumpPower = game.Players.LocalPlayer.Character.Humanoid.JumpPower + 20");
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.ScriptHubOpen = false;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void Fly_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/XMNnv1Wi");
            ExecuteExploit(Script);
        }

        private void Noclip_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/8qeg944Z");
            ExecuteExploit(Script);

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

        private void ScriptHubWindow_Load(object sender, EventArgs e)
        {

        }

        private void BringAll_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/F4uMQ6BJ");
            ExecuteExploit(Script);
        }

        private void Invisible_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/iG6rHqz9");
            ExecuteExploit(Script);
        }

        private void InstantRespawn_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/q8KX4xeL");
            ExecuteExploit(Script);
        }

        private void WalkSpeed_Click(object sender, EventArgs e)
        {
            ExecuteExploit("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = game.Players.LocalPlayer.Character.Humanoid.WalkSpeed + 25");
        }

        private void TeleportTool_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/cU4pVvcj");
            ExecuteExploit(Script);
        }

        private void ESP_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/gtQPsZHS");
            ExecuteExploit(Script);
        }

        private void InvisibleFling_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/Lpn5rUDp");
            ExecuteExploit(Script);
        }

        private void BTools_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/xjcMfxjX");
            ExecuteExploit(Script);
        }

        private void Drophats_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/tzf1zgcs");
            ExecuteExploit(Script);
        }

        private void DroppableTools_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/nikvSbwg");
            ExecuteExploit(Script);
        }

        private void InfiniteJump_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/6zq9B4Uj");
            ExecuteExploit(Script);
        }

        private void ChatTranslator_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://raw.githubusercontent.com/xxaim/ignore/master/translator.lua");
            ExecuteExploit(Script);
        }

        private void Ragdoll_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/NVf0Rja2");
            ExecuteExploit(Script);
        }

        private void SaveTools_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ecSr0JAK");
            ExecuteExploit(Script);
        }

        private void RetriveTools_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/q8An5HXs");
            ExecuteExploit(Script);
        }

        private void EquipTools_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/0HEbxUd5");
            ExecuteExploit(Script);
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

        private void CrabRave_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/MSr2uL3s");
            ExecuteExploit(Script);
        }

        private void TODD_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/7fUfBXFv");
            ExecuteExploit(Script);
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void GamesHub_Click(object sender, EventArgs e)
        {
            if (GamesHub.Text == "Script Hub")
            {
                GamesHub.Text = "Games Hub";
                Games.Visible = false;
            }
            else if (GamesHub.Text == "Games Hub")
            {
                GamesHub.Text = "Script Hub";
                Games.Visible = true;
            }
        }
    }
}