namespace Bloxsploit
{
    partial class PastebinRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastebinRequest));
            this.PasteTitleBox = new System.Windows.Forms.TextBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.PasteTitle = new System.Windows.Forms.Label();
            this.Syntax = new System.Windows.Forms.Label();
            this.SyntaxBox = new System.Windows.Forms.ComboBox();
            this.Username = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.MaskedTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasteTitleBox
            // 
            this.PasteTitleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.PasteTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasteTitleBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.PasteTitleBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PasteTitleBox.Location = new System.Drawing.Point(12, 80);
            this.PasteTitleBox.Name = "PasteTitleBox";
            this.PasteTitleBox.Size = new System.Drawing.Size(123, 20);
            this.PasteTitleBox.TabIndex = 0;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.TitleBar.Controls.Add(this.pictureBox1);
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Controls.Add(this.CloseWindow);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(289, 51);
            this.TitleBar.TabIndex = 11;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(148, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(61, 19);
            this.Title.TabIndex = 3;
            this.Title.Text = "Pastebin";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 14.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bloxsploit";
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.CloseWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseWindow.BackgroundImage")));
            this.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseWindow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.Color.White;
            this.CloseWindow.Location = new System.Drawing.Point(253, 12);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(24, 23);
            this.CloseWindow.TabIndex = 6;
            this.CloseWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseWindow.UseVisualStyleBackColor = false;
            // 
            // PasteTitle
            // 
            this.PasteTitle.AutoSize = true;
            this.PasteTitle.BackColor = System.Drawing.Color.Transparent;
            this.PasteTitle.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.PasteTitle.ForeColor = System.Drawing.Color.White;
            this.PasteTitle.Location = new System.Drawing.Point(38, 58);
            this.PasteTitle.Name = "PasteTitle";
            this.PasteTitle.Size = new System.Drawing.Size(71, 19);
            this.PasteTitle.TabIndex = 15;
            this.PasteTitle.Text = "Paste Title";
            this.PasteTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Syntax
            // 
            this.Syntax.AutoSize = true;
            this.Syntax.BackColor = System.Drawing.Color.Transparent;
            this.Syntax.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Syntax.ForeColor = System.Drawing.Color.White;
            this.Syntax.Location = new System.Drawing.Point(193, 58);
            this.Syntax.Name = "Syntax";
            this.Syntax.Size = new System.Drawing.Size(49, 19);
            this.Syntax.TabIndex = 17;
            this.Syntax.Text = "Syntax";
            this.Syntax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SyntaxBox
            // 
            this.SyntaxBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.SyntaxBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyntaxBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyntaxBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SyntaxBox.FormattingEnabled = true;
            this.SyntaxBox.Items.AddRange(new object[] {
            "",
            "Lua"});
            this.SyntaxBox.Location = new System.Drawing.Point(156, 80);
            this.SyntaxBox.Name = "SyntaxBox";
            this.SyntaxBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SyntaxBox.Size = new System.Drawing.Size(121, 21);
            this.SyntaxBox.TabIndex = 18;
            this.SyntaxBox.Text = "Lua";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(8, 114);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(133, 19);
            this.Username.TabIndex = 20;
            this.Username.Text = "Username (optional)";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.UsernameBox.ForeColor = System.Drawing.SystemColors.Window;
            this.UsernameBox.Location = new System.Drawing.Point(13, 136);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(123, 20);
            this.UsernameBox.TabIndex = 19;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(153, 114);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(129, 19);
            this.Password.TabIndex = 22;
            this.Password.Text = "Password (optional)";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            this.PasswordBox.AsciiOnly = true;
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PasswordBox.Location = new System.Drawing.Point(157, 136);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.Size = new System.Drawing.Size(120, 19);
            this.PasswordBox.TabIndex = 23;
            this.PasswordBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Submit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(13, 182);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(264, 29);
            this.Submit.TabIndex = 24;
            this.Submit.Text = "Paste";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Error
            // 
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Error.ForeColor = System.Drawing.Color.White;
            this.Error.Location = new System.Drawing.Point(12, 161);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(265, 19);
            this.Error.TabIndex = 25;
            this.Error.Text = "Error";
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PastebinRequest
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CancelButton = this.CloseWindow;
            this.ClientSize = new System.Drawing.Size(289, 223);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.SyntaxBox);
            this.Controls.Add(this.Syntax);
            this.Controls.Add(this.PasteTitle);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.PasteTitleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PastebinRequest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upload File to Pastebin";
            this.TopMost = true;
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasteTitleBox;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Label PasteTitle;
        private System.Windows.Forms.Label Syntax;
        private System.Windows.Forms.ComboBox SyntaxBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.MaskedTextBox PasswordBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}