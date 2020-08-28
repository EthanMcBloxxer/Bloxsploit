namespace Bloxsploit
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SHTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.KillRoblox = new System.Windows.Forms.Button();
            this.DiscordServer = new System.Windows.Forms.Button();
            this.Obfuscater = new System.Windows.Forms.Button();
            this.Changelog = new System.Windows.Forms.RichTextBox();
            this.BloxsploitChangelog = new System.Windows.Forms.Label();
            this.Themes = new System.Windows.Forms.Button();
            this.AutoAttach = new System.Windows.Forms.CheckBox();
            this.AlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.AltGen = new System.Windows.Forms.Button();
            this.WeAreDevs = new System.Windows.Forms.RadioButton();
            this.APISettings = new System.Windows.Forms.Label();
            this.EasyXploits = new System.Windows.Forms.RadioButton();
            this.Fade = new System.Windows.Forms.CheckBox();
            this.BoostFPS = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CheatSquad = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.SHTitle);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.CloseWindow);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 57);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // SHTitle
            // 
            this.SHTitle.AutoSize = true;
            this.SHTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.SHTitle.ForeColor = System.Drawing.Color.White;
            this.SHTitle.Location = new System.Drawing.Point(226, 13);
            this.SHTitle.Name = "SHTitle";
            this.SHTitle.Size = new System.Drawing.Size(62, 20);
            this.SHTitle.TabIndex = 1;
            this.SHTitle.Text = "Options";
            this.SHTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SHTitle_MouseDown);
            this.SHTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SHTitle_MouseMove);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Leelawadee", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(97, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 35);
            this.Title.TabIndex = 33;
            this.Title.Text = "Bloxsploit";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
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
            this.Logo.Location = new System.Drawing.Point(10, 7);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(41, 41);
            this.Logo.TabIndex = 32;
            this.Logo.TabStop = false;
            this.Logo.UseVisualStyleBackColor = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.CloseWindow.BackgroundImage = global::Bloxsploit.Properties.Resources.WhiteClose;
            this.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseWindow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.Color.White;
            this.CloseWindow.Location = new System.Drawing.Point(344, 14);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(24, 23);
            this.CloseWindow.TabIndex = 7;
            this.CloseWindow.TabStop = false;
            this.CloseWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // KillRoblox
            // 
            this.KillRoblox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.KillRoblox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KillRoblox.FlatAppearance.BorderSize = 0;
            this.KillRoblox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillRoblox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillRoblox.ForeColor = System.Drawing.Color.White;
            this.KillRoblox.Location = new System.Drawing.Point(229, 69);
            this.KillRoblox.Name = "KillRoblox";
            this.KillRoblox.Size = new System.Drawing.Size(128, 31);
            this.KillRoblox.TabIndex = 26;
            this.KillRoblox.TabStop = false;
            this.KillRoblox.Text = "Kill Roblox";
            this.KillRoblox.UseVisualStyleBackColor = false;
            this.KillRoblox.Click += new System.EventHandler(this.KillRoblox_Click);
            // 
            // DiscordServer
            // 
            this.DiscordServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.DiscordServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordServer.FlatAppearance.BorderSize = 0;
            this.DiscordServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordServer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordServer.ForeColor = System.Drawing.Color.White;
            this.DiscordServer.Location = new System.Drawing.Point(229, 106);
            this.DiscordServer.Name = "DiscordServer";
            this.DiscordServer.Size = new System.Drawing.Size(128, 31);
            this.DiscordServer.TabIndex = 27;
            this.DiscordServer.TabStop = false;
            this.DiscordServer.Text = "Discord Server";
            this.DiscordServer.UseVisualStyleBackColor = false;
            this.DiscordServer.Click += new System.EventHandler(this.DiscordServer_Click);
            // 
            // Obfuscater
            // 
            this.Obfuscater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Obfuscater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Obfuscater.FlatAppearance.BorderSize = 0;
            this.Obfuscater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Obfuscater.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obfuscater.ForeColor = System.Drawing.Color.White;
            this.Obfuscater.Location = new System.Drawing.Point(229, 143);
            this.Obfuscater.Name = "Obfuscater";
            this.Obfuscater.Size = new System.Drawing.Size(128, 31);
            this.Obfuscater.TabIndex = 28;
            this.Obfuscater.TabStop = false;
            this.Obfuscater.Text = "Obfuscator";
            this.Obfuscater.UseVisualStyleBackColor = false;
            this.Obfuscater.Click += new System.EventHandler(this.Obfuscater_Click);
            // 
            // Changelog
            // 
            this.Changelog.AcceptsTab = true;
            this.Changelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Changelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Changelog.Cursor = System.Windows.Forms.Cursors.Default;
            this.Changelog.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.Changelog.ForeColor = System.Drawing.Color.White;
            this.Changelog.Location = new System.Drawing.Point(10, 256);
            this.Changelog.Name = "Changelog";
            this.Changelog.ReadOnly = true;
            this.Changelog.Size = new System.Drawing.Size(358, 154);
            this.Changelog.TabIndex = 29;
            this.Changelog.Text = resources.GetString("Changelog.Text");
            // 
            // BloxsploitChangelog
            // 
            this.BloxsploitChangelog.AutoSize = true;
            this.BloxsploitChangelog.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.BloxsploitChangelog.ForeColor = System.Drawing.Color.White;
            this.BloxsploitChangelog.Location = new System.Drawing.Point(70, 223);
            this.BloxsploitChangelog.Name = "BloxsploitChangelog";
            this.BloxsploitChangelog.Size = new System.Drawing.Size(238, 30);
            this.BloxsploitChangelog.TabIndex = 8;
            this.BloxsploitChangelog.Text = "Bloxsploit Changelog";
            // 
            // Themes
            // 
            this.Themes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Themes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Themes.FlatAppearance.BorderSize = 0;
            this.Themes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Themes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Themes.ForeColor = System.Drawing.Color.White;
            this.Themes.Location = new System.Drawing.Point(10, 481);
            this.Themes.Name = "Themes";
            this.Themes.Size = new System.Drawing.Size(358, 39);
            this.Themes.TabIndex = 31;
            this.Themes.TabStop = false;
            this.Themes.Text = "UI Theme Customization";
            this.Themes.UseVisualStyleBackColor = false;
            this.Themes.Click += new System.EventHandler(this.Themes_Click);
            // 
            // AutoAttach
            // 
            this.AutoAttach.AutoSize = true;
            this.AutoAttach.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoAttach.ForeColor = System.Drawing.Color.White;
            this.AutoAttach.Location = new System.Drawing.Point(12, 105);
            this.AutoAttach.Name = "AutoAttach";
            this.AutoAttach.Size = new System.Drawing.Size(153, 32);
            this.AutoAttach.TabIndex = 25;
            this.AutoAttach.TabStop = false;
            this.AutoAttach.Text = "Auto Attach";
            this.AutoAttach.UseVisualStyleBackColor = true;
            this.AutoAttach.CheckedChanged += new System.EventHandler(this.AutoAttach_CheckedChanged);
            // 
            // AlwaysOnTop
            // 
            this.AlwaysOnTop.AutoSize = true;
            this.AlwaysOnTop.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwaysOnTop.ForeColor = System.Drawing.Color.White;
            this.AlwaysOnTop.Location = new System.Drawing.Point(12, 69);
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            this.AlwaysOnTop.Size = new System.Drawing.Size(127, 32);
            this.AlwaysOnTop.TabIndex = 23;
            this.AlwaysOnTop.TabStop = false;
            this.AlwaysOnTop.Text = "Top Most";
            this.AlwaysOnTop.UseVisualStyleBackColor = true;
            this.AlwaysOnTop.CheckedChanged += new System.EventHandler(this.AlwaysOnTop_CheckedChanged);
            // 
            // AltGen
            // 
            this.AltGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.AltGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AltGen.FlatAppearance.BorderSize = 0;
            this.AltGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AltGen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltGen.ForeColor = System.Drawing.Color.White;
            this.AltGen.Location = new System.Drawing.Point(229, 180);
            this.AltGen.Name = "AltGen";
            this.AltGen.Size = new System.Drawing.Size(128, 31);
            this.AltGen.TabIndex = 34;
            this.AltGen.TabStop = false;
            this.AltGen.Text = "Alt Generator";
            this.AltGen.UseVisualStyleBackColor = false;
            this.AltGen.Click += new System.EventHandler(this.FPSUnlocker_Click);
            // 
            // WeAreDevs
            // 
            this.WeAreDevs.AutoSize = true;
            this.WeAreDevs.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.WeAreDevs.ForeColor = System.Drawing.Color.White;
            this.WeAreDevs.Location = new System.Drawing.Point(12, 450);
            this.WeAreDevs.Name = "WeAreDevs";
            this.WeAreDevs.Size = new System.Drawing.Size(115, 25);
            this.WeAreDevs.TabIndex = 35;
            this.WeAreDevs.Text = "WeAreDevs";
            this.WeAreDevs.UseVisualStyleBackColor = true;
            this.WeAreDevs.CheckedChanged += new System.EventHandler(this.WeAreDevs_CheckedChanged);
            // 
            // APISettings
            // 
            this.APISettings.AutoSize = true;
            this.APISettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APISettings.ForeColor = System.Drawing.Color.White;
            this.APISettings.Location = new System.Drawing.Point(115, 416);
            this.APISettings.Name = "APISettings";
            this.APISettings.Size = new System.Drawing.Size(153, 31);
            this.APISettings.TabIndex = 33;
            this.APISettings.Text = "API Settings";
            // 
            // EasyXploits
            // 
            this.EasyXploits.AutoSize = true;
            this.EasyXploits.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.EasyXploits.ForeColor = System.Drawing.Color.White;
            this.EasyXploits.Location = new System.Drawing.Point(129, 450);
            this.EasyXploits.Name = "EasyXploits";
            this.EasyXploits.Size = new System.Drawing.Size(119, 25);
            this.EasyXploits.TabIndex = 36;
            this.EasyXploits.Text = "EasyExploits";
            this.EasyXploits.UseVisualStyleBackColor = true;
            this.EasyXploits.CheckedChanged += new System.EventHandler(this.EasyXploits_CheckedChanged);
            // 
            // Fade
            // 
            this.Fade.AutoSize = true;
            this.Fade.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fade.ForeColor = System.Drawing.Color.White;
            this.Fade.Location = new System.Drawing.Point(12, 143);
            this.Fade.Name = "Fade";
            this.Fade.Size = new System.Drawing.Size(163, 32);
            this.Fade.TabIndex = 38;
            this.Fade.TabStop = false;
            this.Fade.Text = "Fade In / Out";
            this.Fade.UseVisualStyleBackColor = true;
            this.Fade.CheckedChanged += new System.EventHandler(this.Fade_CheckedChanged);
            // 
            // BoostFPS
            // 
            this.BoostFPS.AutoSize = true;
            this.BoostFPS.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoostFPS.ForeColor = System.Drawing.Color.White;
            this.BoostFPS.Location = new System.Drawing.Point(12, 181);
            this.BoostFPS.Name = "BoostFPS";
            this.BoostFPS.Size = new System.Drawing.Size(130, 32);
            this.BoostFPS.TabIndex = 39;
            this.BoostFPS.TabStop = false;
            this.BoostFPS.Text = "Boost FPS";
            this.BoostFPS.UseVisualStyleBackColor = true;
            this.BoostFPS.CheckedChanged += new System.EventHandler(this.BoostFPS_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CheatSquad
            // 
            this.CheatSquad.AutoSize = true;
            this.CheatSquad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.CheatSquad.ForeColor = System.Drawing.Color.White;
            this.CheatSquad.Location = new System.Drawing.Point(254, 450);
            this.CheatSquad.Name = "CheatSquad";
            this.CheatSquad.Size = new System.Drawing.Size(121, 25);
            this.CheatSquad.TabIndex = 40;
            this.CheatSquad.Text = "CheatSquad";
            this.CheatSquad.UseVisualStyleBackColor = true;
            this.CheatSquad.CheckedChanged += new System.EventHandler(this.CheatSquad_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CancelButton = this.CloseWindow;
            this.ClientSize = new System.Drawing.Size(380, 533);
            this.Controls.Add(this.CheatSquad);
            this.Controls.Add(this.BoostFPS);
            this.Controls.Add(this.Fade);
            this.Controls.Add(this.EasyXploits);
            this.Controls.Add(this.APISettings);
            this.Controls.Add(this.WeAreDevs);
            this.Controls.Add(this.AltGen);
            this.Controls.Add(this.Themes);
            this.Controls.Add(this.BloxsploitChangelog);
            this.Controls.Add(this.Changelog);
            this.Controls.Add(this.Obfuscater);
            this.Controls.Add(this.DiscordServer);
            this.Controls.Add(this.KillRoblox);
            this.Controls.Add(this.AutoAttach);
            this.Controls.Add(this.AlwaysOnTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(863, 530);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SHTitle;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Button KillRoblox;
        private System.Windows.Forms.Button DiscordServer;
        private System.Windows.Forms.Button Obfuscater;
        private System.Windows.Forms.RichTextBox Changelog;
        private System.Windows.Forms.Label BloxsploitChangelog;
        private System.Windows.Forms.Button Themes;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.CheckBox AutoAttach;
        private System.Windows.Forms.CheckBox AlwaysOnTop;
        private System.Windows.Forms.Button AltGen;
        private System.Windows.Forms.RadioButton WeAreDevs;
        private System.Windows.Forms.Label APISettings;
        private System.Windows.Forms.RadioButton EasyXploits;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.CheckBox Fade;
        private System.Windows.Forms.CheckBox BoostFPS;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton CheatSquad;
    }
}