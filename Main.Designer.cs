using System;

namespace Bloxsploit
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Attach = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.Options = new System.Windows.Forms.Button();
            this.ScriptHub = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Scripts = new System.Windows.Forms.ListBox();
            this.Open = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.Pastebin = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TitleBar.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.TitleBar.Controls.Add(this.Version);
            this.TitleBar.Controls.Add(this.Minimize);
            this.TitleBar.Controls.Add(this.Logo);
            this.TitleBar.Controls.Add(this.CloseWindow);
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(677, 53);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_Paint);
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Leelawadee", 11.75F);
            this.Version.ForeColor = System.Drawing.Color.White;
            this.Version.Location = new System.Drawing.Point(392, 11);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(62, 19);
            this.Version.TabIndex = 8;
            this.Version.Text = "Version";
            this.Version.MouseEnter += new System.EventHandler(this.Version_MouseEnter);
            this.Version.MouseLeave += new System.EventHandler(this.Version_MouseLeave);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Minimize.BackgroundImage = global::Bloxsploit.Properties.Resources.WhiteMinimize;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(584, 11);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 27);
            this.Minimize.TabIndex = 6;
            this.Minimize.TabStop = false;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Logo.BackgroundImage = global::Bloxsploit.Properties.Resources.LogoImage;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Location = new System.Drawing.Point(12, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(44, 45);
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            this.Logo.UseVisualStyleBackColor = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.CloseWindow.BackgroundImage = global::Bloxsploit.Properties.Resources.WhiteClose;
            this.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.Color.White;
            this.CloseWindow.Location = new System.Drawing.Point(634, 11);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(31, 27);
            this.CloseWindow.TabIndex = 5;
            this.CloseWindow.TabStop = false;
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Leelawadee", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(262, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 35);
            this.Title.TabIndex = 2;
            this.Title.Text = "Bloxsploit";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown_1);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove_1);
            // 
            // Attach
            // 
            this.Attach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Attach.Cursor = System.Windows.Forms.Cursors.Default;
            this.Attach.FlatAppearance.BorderSize = 0;
            this.Attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attach.ForeColor = System.Drawing.Color.White;
            this.Attach.Location = new System.Drawing.Point(12, 8);
            this.Attach.Name = "Attach";
            this.Attach.Size = new System.Drawing.Size(133, 34);
            this.Attach.TabIndex = 1;
            this.Attach.TabStop = false;
            this.Attach.Text = "Attach";
            this.Attach.UseVisualStyleBackColor = false;
            this.Attach.Click += new System.EventHandler(this.Attach_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ButtonPanel.Controls.Add(this.Options);
            this.ButtonPanel.Controls.Add(this.ScriptHub);
            this.ButtonPanel.Controls.Add(this.Execute);
            this.ButtonPanel.Controls.Add(this.Attach);
            this.ButtonPanel.Location = new System.Drawing.Point(0, 305);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(677, 51);
            this.ButtonPanel.TabIndex = 2;
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Options.Cursor = System.Windows.Forms.Cursors.Default;
            this.Options.FlatAppearance.BorderSize = 0;
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.ForeColor = System.Drawing.Color.White;
            this.Options.Location = new System.Drawing.Point(532, 8);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(133, 34);
            this.Options.TabIndex = 4;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // ScriptHub
            // 
            this.ScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ScriptHub.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScriptHub.FlatAppearance.BorderSize = 0;
            this.ScriptHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptHub.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHub.ForeColor = System.Drawing.Color.White;
            this.ScriptHub.Location = new System.Drawing.Point(378, 8);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.Size = new System.Drawing.Size(133, 34);
            this.ScriptHub.TabIndex = 3;
            this.ScriptHub.TabStop = false;
            this.ScriptHub.Text = "Script Hub";
            this.ScriptHub.UseVisualStyleBackColor = false;
            this.ScriptHub.Click += new System.EventHandler(this.ScriptHub_Click);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Execute.Cursor = System.Windows.Forms.Cursors.Default;
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(219, 8);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(133, 34);
            this.Execute.TabIndex = 2;
            this.Execute.TabStop = false;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(510, 272);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(86, 34);
            this.Save.TabIndex = 5;
            this.Save.TabStop = false;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Scripts
            // 
            this.Scripts.AllowDrop = true;
            this.Scripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Scripts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scripts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scripts.ForeColor = System.Drawing.Color.White;
            this.Scripts.FormattingEnabled = true;
            this.Scripts.ItemHeight = 17;
            this.Scripts.Location = new System.Drawing.Point(510, 53);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(167, 221);
            this.Scripts.TabIndex = 4;
            this.Scripts.SelectedIndexChanged += new System.EventHandler(this.Scripts_SelectedIndexChanged);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Open.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Open.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Open.Location = new System.Drawing.Point(595, 272);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(82, 34);
            this.Open.TabIndex = 6;
            this.Open.TabStop = false;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 53);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(509, 253);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // refresher
            // 
            this.refresher.Enabled = true;
            this.refresher.Interval = 8000;
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // Pastebin
            // 
            this.Pastebin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Pastebin.BackgroundImage = global::Bloxsploit.Properties.Resources.PastebinIcon;
            this.Pastebin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pastebin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pastebin.FlatAppearance.BorderSize = 0;
            this.Pastebin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pastebin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Pastebin.ForeColor = System.Drawing.Color.White;
            this.Pastebin.Location = new System.Drawing.Point(456, 266);
            this.Pastebin.Name = "Pastebin";
            this.Pastebin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pastebin.Size = new System.Drawing.Size(30, 31);
            this.Pastebin.TabIndex = 9;
            this.Pastebin.TabStop = false;
            this.Pastebin.UseVisualStyleBackColor = false;
            this.Pastebin.Click += new System.EventHandler(this.Pastebin_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(280, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 167);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(677, 356);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Pastebin);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1243, 724);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloxsploit";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button Attach;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ScriptHub;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListBox Scripts;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button Pastebin;
        private System.Windows.Forms.Timer refresher;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

