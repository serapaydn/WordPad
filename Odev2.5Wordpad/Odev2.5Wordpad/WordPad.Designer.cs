namespace Odev2._5Wordpad
{
    partial class WordPad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordPad));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.TSB_kaydet = new System.Windows.Forms.ToolStripButton();
            this.TSB_gerial = new System.Windows.Forms.ToolStripButton();
            this.TSB_yenile = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSMI_dosya = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ac = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_yazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_giris = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_gorunum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_kes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_kopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_yapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.RTB_metinyazma = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_harfsayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WordPad";
            this.notifyIcon1.Visible = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1203, 10);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1203, 10);
            this.toolStripContainer1.TabIndex = 10;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // TSB_kaydet
            // 
            this.TSB_kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("TSB_kaydet.Image")));
            this.TSB_kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_kaydet.Name = "TSB_kaydet";
            this.TSB_kaydet.Size = new System.Drawing.Size(27, 24);
            this.TSB_kaydet.Text = "Kaydet";
            this.TSB_kaydet.Click += new System.EventHandler(this.TSB_kaydet_Click);
            // 
            // TSB_gerial
            // 
            this.TSB_gerial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_gerial.Image = ((System.Drawing.Image)(resources.GetObject("TSB_gerial.Image")));
            this.TSB_gerial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_gerial.Name = "TSB_gerial";
            this.TSB_gerial.Size = new System.Drawing.Size(27, 24);
            this.TSB_gerial.Text = "Geri Al";
            this.TSB_gerial.Click += new System.EventHandler(this.TSB_gerial_Click);
            // 
            // TSB_yenile
            // 
            this.TSB_yenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_yenile.Image = ((System.Drawing.Image)(resources.GetObject("TSB_yenile.Image")));
            this.TSB_yenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_yenile.Name = "TSB_yenile";
            this.TSB_yenile.Size = new System.Drawing.Size(27, 24);
            this.TSB_yenile.Text = "Yenile";
            this.TSB_yenile.Click += new System.EventHandler(this.TSB_yenile_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_kaydet,
            this.TSB_gerial,
            this.TSB_yenile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 656);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSMI_dosya
            // 
            this.TSMI_dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_yeni,
            this.TSMI_ac,
            this.TSMI_kaydet,
            this.toolStripSeparator1,
            this.TSMI_yazdir,
            this.toolStripSeparator2,
            this.TSMI_cikis});
            this.TSMI_dosya.Name = "TSMI_dosya";
            this.TSMI_dosya.Size = new System.Drawing.Size(64, 24);
            this.TSMI_dosya.Text = "Dosya";
            // 
            // TSMI_yeni
            // 
            this.TSMI_yeni.Image = global::Odev2._5Wordpad.Properties.Resources.paper_2;
            this.TSMI_yeni.Name = "TSMI_yeni";
            this.TSMI_yeni.Size = new System.Drawing.Size(138, 26);
            this.TSMI_yeni.Text = "Yeni ";
            this.TSMI_yeni.ToolTipText = "Yeni Sayfa";
            this.TSMI_yeni.Click += new System.EventHandler(this.TSMI_yeni_Click);
            // 
            // TSMI_ac
            // 
            this.TSMI_ac.Image = global::Odev2._5Wordpad.Properties.Resources.folder_3;
            this.TSMI_ac.Name = "TSMI_ac";
            this.TSMI_ac.Size = new System.Drawing.Size(138, 26);
            this.TSMI_ac.Text = "Aç";
            this.TSMI_ac.ToolTipText = "Yeni Dosya Aç";
            this.TSMI_ac.Click += new System.EventHandler(this.TSMI_ac_Click);
            // 
            // TSMI_kaydet
            // 
            this.TSMI_kaydet.Image = global::Odev2._5Wordpad.Properties.Resources.save_1;
            this.TSMI_kaydet.Name = "TSMI_kaydet";
            this.TSMI_kaydet.Size = new System.Drawing.Size(138, 26);
            this.TSMI_kaydet.Text = "Kaydet";
            this.TSMI_kaydet.ToolTipText = "Kaydet";
            this.TSMI_kaydet.Click += new System.EventHandler(this.TSMI_kaydet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // TSMI_yazdir
            // 
            this.TSMI_yazdir.Image = global::Odev2._5Wordpad.Properties.Resources.print;
            this.TSMI_yazdir.Name = "TSMI_yazdir";
            this.TSMI_yazdir.Size = new System.Drawing.Size(138, 26);
            this.TSMI_yazdir.Text = "Yazdır";
            this.TSMI_yazdir.ToolTipText = "Yazdır";
            this.TSMI_yazdir.Click += new System.EventHandler(this.TSMI_yazdir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // TSMI_cikis
            // 
            this.TSMI_cikis.Image = global::Odev2._5Wordpad.Properties.Resources.arrow_simple_2;
            this.TSMI_cikis.Name = "TSMI_cikis";
            this.TSMI_cikis.Size = new System.Drawing.Size(138, 26);
            this.TSMI_cikis.Text = "Çıkış";
            this.TSMI_cikis.ToolTipText = "Çıkış";
            this.TSMI_cikis.Click += new System.EventHandler(this.TSMI_cikis_Click);
            // 
            // TSMI_giris
            // 
            this.TSMI_giris.Name = "TSMI_giris";
            this.TSMI_giris.Size = new System.Drawing.Size(52, 24);
            this.TSMI_giris.Text = "Giris";
            this.TSMI_giris.Click += new System.EventHandler(this.TSMI_giris_Click);
            // 
            // TSMI_gorunum
            // 
            this.TSMI_gorunum.Name = "TSMI_gorunum";
            this.TSMI_gorunum.Size = new System.Drawing.Size(84, 24);
            this.TSMI_gorunum.Text = "Görünüm";
            this.TSMI_gorunum.Click += new System.EventHandler(this.TSMI_gorunum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_dosya,
            this.TSMI_giris,
            this.TSMI_gorunum});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_kes,
            this.TSMI_kopyala,
            this.TSMI_yapistir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 82);
            // 
            // TSMI_kes
            // 
            this.TSMI_kes.Image = global::Odev2._5Wordpad.Properties.Resources.cut;
            this.TSMI_kes.Name = "TSMI_kes";
            this.TSMI_kes.Size = new System.Drawing.Size(136, 26);
            this.TSMI_kes.Text = "Kes";
            this.TSMI_kes.Click += new System.EventHandler(this.TSMI_kes_Click);
            // 
            // TSMI_kopyala
            // 
            this.TSMI_kopyala.Image = global::Odev2._5Wordpad.Properties.Resources.copy_1;
            this.TSMI_kopyala.Name = "TSMI_kopyala";
            this.TSMI_kopyala.Size = new System.Drawing.Size(136, 26);
            this.TSMI_kopyala.Text = "Kopyala";
            this.TSMI_kopyala.Click += new System.EventHandler(this.TSMI_kopyala_Click);
            // 
            // TSMI_yapistir
            // 
            this.TSMI_yapistir.Image = global::Odev2._5Wordpad.Properties.Resources.paper_3;
            this.TSMI_yapistir.Name = "TSMI_yapistir";
            this.TSMI_yapistir.Size = new System.Drawing.Size(136, 26);
            this.TSMI_yapistir.Text = "Yapıştır";
            this.TSMI_yapistir.Click += new System.EventHandler(this.TSMI_yapistir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // RTB_metinyazma
            // 
            this.RTB_metinyazma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_metinyazma.Location = new System.Drawing.Point(375, 165);
            this.RTB_metinyazma.Name = "RTB_metinyazma";
            this.RTB_metinyazma.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTB_metinyazma.Size = new System.Drawing.Size(445, 500);
            this.RTB_metinyazma.TabIndex = 16;
            this.RTB_metinyazma.Text = "";
            this.RTB_metinyazma.TextChanged += new System.EventHandler(this.RTB_metinyazma_TextChanged);
            this.RTB_metinyazma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RTB_metinyazma_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_harfsayisi});
            this.statusStrip1.Location = new System.Drawing.Point(30, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1173, 26);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_harfsayisi
            // 
            this.TSSL_harfsayisi.Name = "TSSL_harfsayisi";
            this.TSSL_harfsayisi.Size = new System.Drawing.Size(108, 20);
            this.TSSL_harfsayisi.Text = "Karakter Sayısı:";
            // 
            // WordPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1203, 694);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RTB_metinyazma);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "WordPad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordPad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordPad_FormClosing);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripButton TSB_kaydet;
        private System.Windows.Forms.ToolStripButton TSB_gerial;
        private System.Windows.Forms.ToolStripButton TSB_yenile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_dosya;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yeni;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ac;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yazdir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_cikis;
        private System.Windows.Forms.ToolStripMenuItem TSMI_giris;
        private System.Windows.Forms.ToolStripMenuItem TSMI_gorunum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kes;
        private System.Windows.Forms.ToolStripMenuItem TSMI_kopyala;
        private System.Windows.Forms.ToolStripMenuItem TSMI_yapistir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RichTextBox RTB_metinyazma;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_harfsayisi;
    }
}