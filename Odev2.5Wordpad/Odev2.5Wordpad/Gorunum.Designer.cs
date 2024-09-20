namespace Odev2._5Wordpad
{
    partial class Gorunum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorunum));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_yakinlastir = new System.Windows.Forms.ToolStripButton();
            this.TSB_uzaklastir = new System.Windows.Forms.ToolStripButton();
            this.TSB_cetvel = new System.Windows.Forms.ToolStripButton();
            this.panelcetvel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_yakinlastir,
            this.TSB_uzaklastir,
            this.TSB_cetvel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1207, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_yakinlastir
            // 
            this.TSB_yakinlastir.Image = ((System.Drawing.Image)(resources.GetObject("TSB_yakinlastir.Image")));
            this.TSB_yakinlastir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_yakinlastir.Name = "TSB_yakinlastir";
            this.TSB_yakinlastir.Size = new System.Drawing.Size(99, 24);
            this.TSB_yakinlastir.Text = "Yakınlaştır";
            this.TSB_yakinlastir.Click += new System.EventHandler(this.TSB_yakinlastir_Click);
            // 
            // TSB_uzaklastir
            // 
            this.TSB_uzaklastir.Image = ((System.Drawing.Image)(resources.GetObject("TSB_uzaklastir.Image")));
            this.TSB_uzaklastir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_uzaklastir.Name = "TSB_uzaklastir";
            this.TSB_uzaklastir.Size = new System.Drawing.Size(97, 24);
            this.TSB_uzaklastir.Text = "Uzaklaştır";
            this.TSB_uzaklastir.Click += new System.EventHandler(this.TSB_uzaklastir_Click);
            // 
            // TSB_cetvel
            // 
            this.TSB_cetvel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_cetvel.Image")));
            this.TSB_cetvel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_cetvel.Name = "TSB_cetvel";
            this.TSB_cetvel.Size = new System.Drawing.Size(74, 24);
            this.TSB_cetvel.Text = "Cetvel";
            this.TSB_cetvel.Click += new System.EventHandler(this.TSB_cetvel_Click);
            // 
            // panelcetvel
            // 
            this.panelcetvel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcetvel.Location = new System.Drawing.Point(338, 87);
            this.panelcetvel.Name = "panelcetvel";
            this.panelcetvel.Size = new System.Drawing.Size(489, 40);
            this.panelcetvel.TabIndex = 21;
            this.panelcetvel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcetvel_Paint);
            // 
            // Gorunum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 763);
            this.Controls.Add(this.panelcetvel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Gorunum";
            this.Text = "Gorunum";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_yakinlastir;
        private System.Windows.Forms.ToolStripButton TSB_uzaklastir;
        private System.Windows.Forms.ToolStripButton TSB_cetvel;
        private System.Windows.Forms.Panel panelcetvel;
    }
}