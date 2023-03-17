namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.шифрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрRSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эЦКElToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // шифрToolStripMenuItem
            // 
            this.шифрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифрRSAToolStripMenuItem,
            this.эЦКElToolStripMenuItem});
            this.шифрToolStripMenuItem.Name = "шифрToolStripMenuItem";
            this.шифрToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.шифрToolStripMenuItem.Text = "Криптография ";
            // 
            // шифрRSAToolStripMenuItem
            // 
            this.шифрRSAToolStripMenuItem.Name = "шифрRSAToolStripMenuItem";
            this.шифрRSAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.шифрRSAToolStripMenuItem.Text = "ЭЦК RSA";
            this.шифрRSAToolStripMenuItem.Click += new System.EventHandler(this.шифрRSAToolStripMenuItem_Click);
            // 
            // эЦКElToolStripMenuItem
            // 
            this.эЦКElToolStripMenuItem.Name = "эЦКElToolStripMenuItem";
            this.эЦКElToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.эЦКElToolStripMenuItem.Text = "ЭЦК ElGamal";
            this.эЦКElToolStripMenuItem.Click += new System.EventHandler(this.эЦКElToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem шифрToolStripMenuItem;
        private ToolStripMenuItem шифрRSAToolStripMenuItem;
        private ToolStripMenuItem эЦКElToolStripMenuItem;
    }
}