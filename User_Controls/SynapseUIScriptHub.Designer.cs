namespace Bloxsploit.User_Controls
{
    partial class SynapseUIScriptHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynapseUIScriptHub));
            this.Dex = new System.Windows.Forms.PictureBox();
            this.DexCaption = new System.Windows.Forms.Label();
            this.Scripts = new System.Windows.Forms.Label();
            this.InfiniteYieldCaption = new System.Windows.Forms.Label();
            this.InfiniteYield = new System.Windows.Forms.PictureBox();
            this.RevizCaption = new System.Windows.Forms.Label();
            this.Reviz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfiniteYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reviz)).BeginInit();
            this.SuspendLayout();
            // 
            // Dex
            // 
            this.Dex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dex.BackgroundImage")));
            this.Dex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dex.Location = new System.Drawing.Point(7, 42);
            this.Dex.Name = "Dex";
            this.Dex.Size = new System.Drawing.Size(248, 147);
            this.Dex.TabIndex = 0;
            this.Dex.TabStop = false;
            this.Dex.Click += new System.EventHandler(this.Dex_Click);
            // 
            // DexCaption
            // 
            this.DexCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DexCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.DexCaption.ForeColor = System.Drawing.Color.White;
            this.DexCaption.Location = new System.Drawing.Point(7, 175);
            this.DexCaption.Name = "DexCaption";
            this.DexCaption.Size = new System.Drawing.Size(248, 37);
            this.DexCaption.TabIndex = 1;
            this.DexCaption.Text = "Dark Dex";
            // 
            // Scripts
            // 
            this.Scripts.AutoSize = true;
            this.Scripts.Font = new System.Drawing.Font("Microsoft YaHei UI", 17F);
            this.Scripts.ForeColor = System.Drawing.Color.White;
            this.Scripts.Location = new System.Drawing.Point(12, 6);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(88, 30);
            this.Scripts.TabIndex = 24;
            this.Scripts.Text = "Scripts";
            // 
            // InfiniteYieldCaption
            // 
            this.InfiniteYieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InfiniteYieldCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.InfiniteYieldCaption.ForeColor = System.Drawing.Color.White;
            this.InfiniteYieldCaption.Location = new System.Drawing.Point(270, 175);
            this.InfiniteYieldCaption.Name = "InfiniteYieldCaption";
            this.InfiniteYieldCaption.Size = new System.Drawing.Size(248, 37);
            this.InfiniteYieldCaption.TabIndex = 26;
            this.InfiniteYieldCaption.Text = "Infinite Yield";
            // 
            // InfiniteYield
            // 
            this.InfiniteYield.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfiniteYield.BackgroundImage")));
            this.InfiniteYield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InfiniteYield.Location = new System.Drawing.Point(270, 42);
            this.InfiniteYield.Name = "InfiniteYield";
            this.InfiniteYield.Size = new System.Drawing.Size(248, 134);
            this.InfiniteYield.TabIndex = 27;
            this.InfiniteYield.TabStop = false;
            this.InfiniteYield.Click += new System.EventHandler(this.InfiniteYield_Click);
            // 
            // RevizCaption
            // 
            this.RevizCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RevizCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F);
            this.RevizCaption.ForeColor = System.Drawing.Color.White;
            this.RevizCaption.Location = new System.Drawing.Point(534, 175);
            this.RevizCaption.Name = "RevizCaption";
            this.RevizCaption.Size = new System.Drawing.Size(248, 37);
            this.RevizCaption.TabIndex = 28;
            this.RevizCaption.Text = "Reviz Admin";
            // 
            // Reviz
            // 
            this.Reviz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Reviz.BackgroundImage")));
            this.Reviz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Reviz.Location = new System.Drawing.Point(534, 42);
            this.Reviz.Name = "Reviz";
            this.Reviz.Size = new System.Drawing.Size(248, 134);
            this.Reviz.TabIndex = 29;
            this.Reviz.TabStop = false;
            this.Reviz.Click += new System.EventHandler(this.Reviz_Click);
            // 
            // SynapseUIScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.RevizCaption);
            this.Controls.Add(this.Reviz);
            this.Controls.Add(this.InfiniteYieldCaption);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.DexCaption);
            this.Controls.Add(this.Dex);
            this.Controls.Add(this.InfiniteYield);
            this.Name = "SynapseUIScriptHub";
            this.Size = new System.Drawing.Size(790, 363);
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfiniteYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reviz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dex;
        private System.Windows.Forms.Label DexCaption;
        private System.Windows.Forms.Label Scripts;
        private System.Windows.Forms.Label InfiniteYieldCaption;
        private System.Windows.Forms.PictureBox InfiniteYield;
        private System.Windows.Forms.Label RevizCaption;
        private System.Windows.Forms.PictureBox Reviz;
    }
}
