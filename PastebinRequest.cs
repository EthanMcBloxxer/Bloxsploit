using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace Bloxsploit
{
    public partial class PastebinRequest : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public string text;
        public PastebinRequest(string code)
        {
            InitializeComponent();
            SettingCheck();
            text = code;
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

        private void SettingCheck()
        {
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
                PasteTitle.ForeColor = Color.Black;
                Password.ForeColor = Color.Black;
                Error.ForeColor = Color.Black;
                PasteTitleBox.ForeColor = Color.Black;
                Syntax.ForeColor = Color.Black;
                SyntaxBox.ForeColor = Color.Black;
                Error.ForeColor = Color.Black;

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
                PasteTitle.ForeColor = Color.White;
                Password.ForeColor = Color.White;
                Error.ForeColor = Color.White;
                PasteTitleBox.ForeColor = Color.White;
                Syntax.ForeColor = Color.White;
                SyntaxBox.ForeColor = Color.White;
                Error.ForeColor = Color.White;

                CloseWindow.BackgroundImage = Properties.Resources.WhiteClose;
            }

            CloseWindow.BackColor = TitleBar.BackColor;
            
            Title.BackColor = TitleBar.BackColor;
            label1.BackColor = TitleBar.BackColor;
            PasteTitleBox.BackColor = TitleBar.BackColor;
            SyntaxBox.BackColor = TitleBar.BackColor;
            Title.BackColor = TitleBar.BackColor;
            label1.BackColor = TitleBar.BackColor;
            PasswordBox.BackColor = TitleBar.BackColor;
            Submit.BackColor = TitleBar.BackColor;
            UsernameBox.BackColor = TitleBar.BackColor;

            PasteTitle.BackColor = this.BackColor;
            Password.BackColor = this.BackColor;
            Error.BackColor = this.BackColor;
            Syntax.BackColor = this.BackColor;
            
        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
            {
                { "api_dev_key", "86c0c2ae88e40d8b46ddf2c7878f26c0" },
                { "api_option", "paste" },
                { "api_paste_code", text },
                { "api_paste_name", PasteTitleBox.Text },
                { "api_paste_expire_date", "N" },
                { "api_paste_private", "0" },
                { "api_paste_format", SyntaxBox.Text.ToLower() },
                { "api_user_name", UsernameBox.Text },
                { "api_user_password", PasswordBox.Text }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://pastebin.com/api/api_post.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            try
            {
                if (new Uri(responseString).Scheme == "http" || new Uri(responseString).Scheme == "https")
                {
                    System.Diagnostics.Process.Start(responseString);
                }
            }
            catch (Exception er)
            {
                Error.Visible = true;
                Error.Text = responseString;
                if (Error.Text == "")
                {
                    Error.Text = er.ToString();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SettingCheck();
        }
    }
}