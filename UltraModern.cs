using Microsoft.Win32;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xDialog;

namespace Bloxsploit
{
    public partial class UltraModern : Form
    {
        readonly NeuronAPI.Exploit WeAreDevsAPI = new NeuronAPI.Exploit();
        readonly EasyExploits.Module EasyExploitsAPI = new EasyExploits.Module();

        readonly string programPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );
        public UltraModern()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Functions.PopulateListBox(Scripts, "Scripts", "*.lua");
            Functions.PopulateListBox(Scripts, "Scripts", "*.txt");
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
        public static void ExecuteExploit(string Script)
        {
            NeuronAPI.Exploit WeAreDevsAPI = new NeuronAPI.Exploit();
            EasyExploits.Module EasyExploitsAPI = new EasyExploits.Module();

            if (Properties.Settings.Default.API == "WeAreDevs")
            {
                if (WeAreDevsAPI.IsAPIAttached())
                {
                    WeAreDevsAPI.ExecuteLua(Script);
                }
            }
            if (Properties.Settings.Default.API == "EasyExploits")
            {
                if (Functions.NamedPipeExist(Functions.EasyExploitsPipe))
                {
                    EasyExploitsAPI.ExecuteScript(Script);
                }
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
        private void Discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/qhgRFQw");
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void Exit_Click(object sender, EventArgs e)
        {
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

        private void UltraModern_Load(object sender, EventArgs e)
        {
            this.Input.Margins[0].Width = 16;
            string str1 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string str2 = "0123456789";
            string str3 = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";
            this.Input.StyleResetDefault();
            this.Input.Styles[32].Font = "Consolas";
            this.Input.Styles[32].Size = 10;
            this.Input.Styles[32].ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Input.Styles[32].BackColor = Color.FromArgb(30, 30, 30);
            this.Input.StyleClearAll();
            this.Input.Styles[1].ForeColor = Color.FromArgb(87, 166, 74);
            this.Input.Styles[2].ForeColor = Color.FromArgb(87, 166, 74);
            this.Input.Styles[4].ForeColor = Color.FromArgb(181, 206, 151);
            this.Input.Styles[5].ForeColor = Color.FromArgb(77, 156, 214);
            this.Input.Styles[13].ForeColor = Color.FromArgb(77, 156, 214);
            this.Input.Styles[14].ForeColor = Color.FromArgb(77, 156, 214);
            this.Input.Styles[15].ForeColor = Color.FromArgb(77, 156, 214);
            this.Input.Styles[6].ForeColor = Color.FromArgb(214, 157, 133);
            this.Input.Styles[10].ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Input.Styles[9].ForeColor = Color.FromArgb((int)sbyte.MaxValue, 0, 0);
            this.Input.Lexer = Lexer.Lua;
            this.Input.WordChars = str1 + str2 + str3;
            this.Input.SetKeywords(0, "and break do else elseif end for function if in local nil not or repeat return then until while false true goto");
            this.Input.SetKeywords(1, "assert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV");
            this.Input.SetKeywords(2, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset");
            this.Input.SetKeywords(3, "coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath require package.cpath package.loaded package.loadlib package.path package.preload");
            this.Input.SetProperty("fold", "1");
            this.Input.SetProperty("fold.compact", "1");
            this.Input.Margins[2].Type = MarginType.Symbol;
            this.Input.Margins[2].Mask = 4261412864U;
            this.Input.Margins[2].Sensitive = true;
            this.Input.Margins[2].Width = 20;
            for (int index = 25; index <= 31; ++index)
            {
                this.Input.Markers[index].SetForeColor(Color.FromArgb(35, 35, 35));
                this.Input.Markers[index].SetBackColor(Color.FromArgb(85, 85, 85));
            }
            this.Input.Markers[30].Symbol = MarkerSymbol.BoxPlus;
            this.Input.Markers[31].Symbol = MarkerSymbol.BoxMinus;
            this.Input.Markers[25].Symbol = MarkerSymbol.BoxPlusConnected;
            this.Input.Markers[27].Symbol = MarkerSymbol.TCorner;
            this.Input.Markers[26].Symbol = MarkerSymbol.BoxMinusConnected;
            this.Input.Markers[29].Symbol = MarkerSymbol.VLine;
            this.Input.Markers[28].Symbol = MarkerSymbol.LCorner;
            this.Input.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;
            this.Input.Styles[32].BackColor = Color.FromArgb(27, 27, 27);
            this.Input.SetFoldMarginHighlightColor(true, Color.FromArgb(27, 27, 27));
            this.Input.SetFoldMarginColor(true, Color.FromArgb(27, 27, 27));
            this.Input.Styles[33].BackColor = Color.FromArgb(34, 34, 34);
            this.Input.Styles[33].ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Input.SetSelectionForeColor(true, Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue));
            this.Input.SetSelectionBackColor(true, Color.FromArgb(70, 70, 70));
        }
        Point lastPoint;
        private void Background_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Background_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            AttachExploit();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            AttachExploit();
            ExecuteExploit(Input.Text);
        }

        private void Open_Click(object sender, EventArgs e)
        {
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
                    Input.Text = MainText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog openDialog = new SaveFileDialog
            {
                InitialDirectory = Path.GetFullPath(Path.Combine(programPath, "Scripts")),
                Filter = "Lua Source Files (*.lua)|*.lua|Text Documents (*.txt)|*.txt",
                RestoreDirectory = true
            };
            string TextToSave = Input.Text;
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            Scripts.Items.Clear();
            Functions.PopulateListBox(Scripts, "Scripts", "*.lua");
            Functions.PopulateListBox(Scripts, "Scripts", "*.txt");
        }

        private void Scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            { 
                Input.Text = File.ReadAllText($"./Scripts/{Scripts.SelectedItem}");
                Scripts.ClearSelected();
            }
            catch
            {

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

        private void Settings_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OptionsOpen == false)
            {
                Options openform = new Options();
                openform.Show();
                Properties.Settings.Default.OptionsOpen = true;
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = "Dark";
            Properties.Settings.Default.Save();
            this.Close();
            Application.Restart();
        }

        private void UltraModern_Deactivate(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Fade == true)
            {
                FadeOut(this, 5);
            }
        }

        private void UltraModern_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Fade == true)
            {
                FadeIn(this, 5);
            }
        }
    }
}
