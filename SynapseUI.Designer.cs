namespace Bloxsploit
{
    partial class SynapseUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynapseUI));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.NavBar = new System.Windows.Forms.Panel();
            this.GoBack = new System.Windows.Forms.Button();
            this.OptionsTab = new System.Windows.Forms.Button();
            this.ConsoleTab = new System.Windows.Forms.Button();
            this.ScriptHubTab = new System.Windows.Forms.Button();
            this.ExecutionTab = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.ExecuteFile = new System.Windows.Forms.Button();
            this.Attach = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Execution = new System.Windows.Forms.Label();
            this.Watermark = new System.Windows.Forms.Label();
            this.Scripts = new System.Windows.Forms.ListBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.ClearConfirmation = new Bloxsploit.User_Controls.SynapseUIClearConfimation();
            this.ScriptHub = new Bloxsploit.User_Controls.SynapseUIScriptHub();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(154)))));
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Controls.Add(this.Minimize);
            this.TitleBar.Controls.Add(this.CloseWindow);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(841, 52);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            // 
            // Title
            // 
            this.Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Title.BackgroundImage")));
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Title.Location = new System.Drawing.Point(12, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(172, 40);
            this.Title.TabIndex = 1;
            this.Title.TabStop = false;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(154)))));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(789, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 27);
            this.Minimize.TabIndex = 15;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(154)))));
            this.CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.CloseWindow.ForeColor = System.Drawing.Color.White;
            this.CloseWindow.Location = new System.Drawing.Point(819, 0);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(21, 25);
            this.CloseWindow.TabIndex = 14;
            this.CloseWindow.Text = "X";
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.NavBar.Controls.Add(this.GoBack);
            this.NavBar.Controls.Add(this.OptionsTab);
            this.NavBar.Controls.Add(this.ConsoleTab);
            this.NavBar.Controls.Add(this.ScriptHubTab);
            this.NavBar.Controls.Add(this.ExecutionTab);
            this.NavBar.Location = new System.Drawing.Point(0, 51);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(51, 364);
            this.NavBar.TabIndex = 16;
            // 
            // GoBack
            // 
            this.GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.GoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBack.BackgroundImage")));
            this.GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.GoBack.FlatAppearance.BorderSize = 0;
            this.GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack.ForeColor = System.Drawing.Color.White;
            this.GoBack.Location = new System.Drawing.Point(0, 210);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(50, 50);
            this.GoBack.TabIndex = 26;
            this.GoBack.UseVisualStyleBackColor = false;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // OptionsTab
            // 
            this.OptionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.OptionsTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionsTab.BackgroundImage")));
            this.OptionsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OptionsTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionsTab.FlatAppearance.BorderSize = 0;
            this.OptionsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsTab.ForeColor = System.Drawing.Color.White;
            this.OptionsTab.Location = new System.Drawing.Point(0, 158);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Size = new System.Drawing.Size(50, 50);
            this.OptionsTab.TabIndex = 25;
            this.OptionsTab.UseVisualStyleBackColor = false;
            this.OptionsTab.Click += new System.EventHandler(this.OptionsTab_Click);
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ConsoleTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsoleTab.BackgroundImage")));
            this.ConsoleTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ConsoleTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConsoleTab.FlatAppearance.BorderSize = 0;
            this.ConsoleTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTab.ForeColor = System.Drawing.Color.White;
            this.ConsoleTab.Location = new System.Drawing.Point(0, 106);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Size = new System.Drawing.Size(50, 50);
            this.ConsoleTab.TabIndex = 24;
            this.ConsoleTab.UseVisualStyleBackColor = false;
            // 
            // ScriptHubTab
            // 
            this.ScriptHubTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ScriptHubTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScriptHubTab.BackgroundImage")));
            this.ScriptHubTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ScriptHubTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScriptHubTab.FlatAppearance.BorderSize = 0;
            this.ScriptHubTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptHubTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHubTab.ForeColor = System.Drawing.Color.White;
            this.ScriptHubTab.Location = new System.Drawing.Point(0, 54);
            this.ScriptHubTab.Name = "ScriptHubTab";
            this.ScriptHubTab.Size = new System.Drawing.Size(50, 50);
            this.ScriptHubTab.TabIndex = 23;
            this.ScriptHubTab.UseVisualStyleBackColor = false;
            this.ScriptHubTab.Click += new System.EventHandler(this.ScriptHubTab_Click);
            // 
            // ExecutionTab
            // 
            this.ExecutionTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ExecutionTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExecutionTab.BackgroundImage")));
            this.ExecutionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExecutionTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExecutionTab.FlatAppearance.BorderSize = 0;
            this.ExecutionTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecutionTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecutionTab.ForeColor = System.Drawing.Color.White;
            this.ExecutionTab.Location = new System.Drawing.Point(0, 2);
            this.ExecutionTab.Name = "ExecutionTab";
            this.ExecutionTab.Size = new System.Drawing.Size(50, 50);
            this.ExecutionTab.TabIndex = 22;
            this.ExecutionTab.UseVisualStyleBackColor = false;
            this.ExecutionTab.Click += new System.EventHandler(this.ExecutionTab_Click);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Execute.Cursor = System.Windows.Forms.Cursors.Default;
            this.Execute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(58, 373);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(109, 37);
            this.Execute.TabIndex = 17;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Open.Cursor = System.Windows.Forms.Cursors.Default;
            this.Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(288, 373);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(109, 37);
            this.Open.TabIndex = 19;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // ExecuteFile
            // 
            this.ExecuteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ExecuteFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExecuteFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.ExecuteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteFile.ForeColor = System.Drawing.Color.White;
            this.ExecuteFile.Location = new System.Drawing.Point(403, 373);
            this.ExecuteFile.Name = "ExecuteFile";
            this.ExecuteFile.Size = new System.Drawing.Size(109, 37);
            this.ExecuteFile.TabIndex = 20;
            this.ExecuteFile.Text = "Execute File";
            this.ExecuteFile.UseVisualStyleBackColor = false;
            // 
            // Attach
            // 
            this.Attach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Attach.Cursor = System.Windows.Forms.Cursors.Default;
            this.Attach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attach.ForeColor = System.Drawing.Color.White;
            this.Attach.Location = new System.Drawing.Point(725, 373);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(109, 37);
            this.Attach.TabIndex = 21;
            this.Attach.Text = "Attach";
            this.Attach.UseVisualStyleBackColor = false;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(58, 92);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(622, 275);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Execution
            // 
            this.Execution.AutoSize = true;
            this.Execution.Font = new System.Drawing.Font("Microsoft YaHei UI", 17F);
            this.Execution.ForeColor = System.Drawing.Color.White;
            this.Execution.Location = new System.Drawing.Point(63, 58);
            this.Execution.Name = "Execution";
            this.Execution.Size = new System.Drawing.Size(121, 30);
            this.Execution.TabIndex = 23;
            this.Execution.Text = "Execution";
            // 
            // Watermark
            // 
            this.Watermark.AutoSize = true;
            this.Watermark.BackColor = System.Drawing.Color.Transparent;
            this.Watermark.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Watermark.ForeColor = System.Drawing.Color.White;
            this.Watermark.Location = new System.Drawing.Point(597, 70);
            this.Watermark.Name = "Watermark";
            this.Watermark.Size = new System.Drawing.Size(67, 19);
            this.Watermark.TabIndex = 25;
            this.Watermark.Text = "Bloxsploit";
            this.Watermark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scripts
            // 
            this.Scripts.AllowDrop = true;
            this.Scripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Scripts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scripts.Font = new System.Drawing.Font("Verdana", 10F);
            this.Scripts.ForeColor = System.Drawing.Color.White;
            this.Scripts.FormattingEnabled = true;
            this.Scripts.ItemHeight = 16;
            this.Scripts.Location = new System.Drawing.Point(683, 63);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(154, 304);
            this.Scripts.TabIndex = 24;
            this.Scripts.SelectedIndexChanged += new System.EventHandler(this.Scripts_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // refresher
            // 
            this.refresher.Enabled = true;
            this.refresher.Interval = 4000;
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(173, 373);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(109, 37);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(518, 373);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 37);
            this.Save.TabIndex = 26;
            this.Save.Text = "Save File";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // No
            // 
            this.No.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("No.BackgroundImage")));
            this.No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.No.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.No.ForeColor = System.Drawing.Color.White;
            this.No.Location = new System.Drawing.Point(480, 313);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(115, 42);
            this.No.TabIndex = 35;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Visible = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Yes
            // 
            this.Yes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Yes.BackgroundImage")));
            this.Yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Yes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Yes.ForeColor = System.Drawing.Color.White;
            this.Yes.Location = new System.Drawing.Point(601, 313);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(115, 42);
            this.Yes.TabIndex = 34;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Visible = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // ClearConfirmation
            // 
            this.ClearConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClearConfirmation.Location = new System.Drawing.Point(150, 62);
            this.ClearConfirmation.Name = "ClearConfirmation";
            this.ClearConfirmation.Size = new System.Drawing.Size(576, 305);
            this.ClearConfirmation.TabIndex = 36;
            this.ClearConfirmation.Visible = false;
            // 
            // ScriptHub
            // 
            this.ScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ScriptHub.Location = new System.Drawing.Point(51, 52);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.Size = new System.Drawing.Size(790, 363);
            this.ScriptHub.TabIndex = 32;
            this.ScriptHub.Visible = false;
            // 
            // SynapseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(841, 415);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.ClearConfirmation);
            this.Controls.Add(this.ScriptHub);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Watermark);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.Execution);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.Attach);
            this.Controls.Add(this.ExecuteFile);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SynapseUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synapse X";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SynapseUI_Load);
            this.Shown += new System.EventHandler(this.SynapseUI_Shown);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.NavBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button ExecuteFile;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Button ExecutionTab;
        private System.Windows.Forms.Button ScriptHubTab;
        private System.Windows.Forms.Button OptionsTab;
        private System.Windows.Forms.Button ConsoleTab;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label Execution;
        private System.Windows.Forms.Label Watermark;
        private System.Windows.Forms.ListBox Scripts;
        private System.Windows.Forms.ToolTip tooltip;
        private User_Controls.SynapseUIScriptHub ScriptHub;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer refresher;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Yes;
        private User_Controls.SynapseUIClearConfimation ClearConfirmation;
    }
}