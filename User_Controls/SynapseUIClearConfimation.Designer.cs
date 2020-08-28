namespace Bloxsploit.User_Controls
{
    partial class SynapseUIClearConfimation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynapseUIClearConfimation));
            this.Header = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Bloxsploit.GradientPanel();
            this.Body = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.PictureBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(181, 127);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(211, 32);
            this.Header.TabIndex = 3;
            this.Header.Text = "Bloxapse Warning";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 53);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(575, 28);
            this.gradientPanel1.TabIndex = 5;
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Body.ForeColor = System.Drawing.Color.White;
            this.Body.Location = new System.Drawing.Point(17, 164);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(539, 50);
            this.Body.TabIndex = 4;
            this.Body.Text = "Are you sure you want to clear the editor? All unsaved changes will\r\nbe lost!";
            this.Body.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Warning
            // 
            this.Warning.Image = ((System.Drawing.Image)(resources.GetObject("Warning.Image")));
            this.Warning.Location = new System.Drawing.Point(261, 70);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(49, 50);
            this.Warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Warning.TabIndex = 2;
            this.Warning.TabStop = false;
            // 
            // Title
            // 
            this.Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Title.BackgroundImage")));
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Title.Location = new System.Drawing.Point(5, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(182, 47);
            this.Title.TabIndex = 1;
            this.Title.TabStop = false;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(60)))), ((int)(((byte)(154)))));
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(575, 52);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_Paint);
            // 
            // SynapseUIClearConfimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Header);
            this.Name = "SynapseUIClearConfimation";
            this.Size = new System.Drawing.Size(576, 305);
            ((System.ComponentModel.ISupportInitialize)(this.Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.PictureBox Warning;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.Panel TitleBar;
    }
}
