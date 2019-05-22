namespace Voyage.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otobüslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şoförlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muavinlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otobüslerToolStripMenuItem,
            this.seferlerToolStripMenuItem,
            this.şoförlerToolStripMenuItem,
            this.muavinlerToolStripMenuItem,
            this.biletlerToolStripMenuItem,
            this.rotalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otobüslerToolStripMenuItem
            // 
            this.otobüslerToolStripMenuItem.Name = "otobüslerToolStripMenuItem";
            this.otobüslerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.otobüslerToolStripMenuItem.Text = "Otobüsler";
            this.otobüslerToolStripMenuItem.Click += new System.EventHandler(this.otobüslerToolStripMenuItem_Click);
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.seferlerToolStripMenuItem.Text = "Seferler";
            // 
            // şoförlerToolStripMenuItem
            // 
            this.şoförlerToolStripMenuItem.Name = "şoförlerToolStripMenuItem";
            this.şoförlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.şoförlerToolStripMenuItem.Text = "Şoförler";
            // 
            // muavinlerToolStripMenuItem
            // 
            this.muavinlerToolStripMenuItem.Name = "muavinlerToolStripMenuItem";
            this.muavinlerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.muavinlerToolStripMenuItem.Text = "Muavinler";
            // 
            // biletlerToolStripMenuItem
            // 
            this.biletlerToolStripMenuItem.Name = "biletlerToolStripMenuItem";
            this.biletlerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.biletlerToolStripMenuItem.Text = "Biletler";
            // 
            // rotalarToolStripMenuItem
            // 
            this.rotalarToolStripMenuItem.Name = "rotalarToolStripMenuItem";
            this.rotalarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.rotalarToolStripMenuItem.Text = "Rotalar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otobüslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şoförlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muavinlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotalarToolStripMenuItem;
    }
}