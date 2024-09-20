using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2._5Wordpad
{
    public partial class WordPad : Form
    {
        public WordPad()
        {
            InitializeComponent(); 
            this.Load += new EventHandler(WordPad_Load); 
        }

        private void WordPad_Load(object sender, EventArgs e)
        {
            OpenGirisForm();
            
        }
        private void TSMI_giris_Click(object sender, EventArgs e)
        {
            OpenGirisForm();
        }

        private void OpenGirisForm()
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == typeof(Giris))
                {
                    item.Activate();
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                Giris grs = new Giris(RTB_metinyazma);
                grs.MdiParent = this;
                grs.WindowState = FormWindowState.Maximized;
                grs.Show();
            }
        }
    

        private void TSMI_gorunum_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.GetType() == typeof(Gorunum))
                {
                    item.Activate();
                    isOpen = true;
                    break;
                }
            }
            if (!isOpen)
            {
                Gorunum grm = new Gorunum(RTB_metinyazma); 
                grm.MdiParent = this;
                grm.WindowState = FormWindowState.Maximized;
                grm.Show();
            }
        }

        private void RTB_metinyazma_TextChanged(object sender, EventArgs e)
        {

            KaraktersayisiGuncelle();
        }

        private void KaraktersayisiGuncelle()
        {
            int karaktersayisi = RTB_metinyazma.Text.Length;
            TSSL_harfsayisi .Text = $"Karakter Sayısı: {karaktersayisi}";
        }

        private void TSB_kaydet_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.rtx)|*.rtx|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, RTB_metinyazma.Text);
                }
            }
        }
        private void TSB_gerial_Click(object sender, EventArgs e)
        {
            if (RTB_metinyazma.Text.Length > 0)
            {
                RTB_metinyazma.Text = RTB_metinyazma.Text.Substring(0, RTB_metinyazma.Text.Length - 1);
            }
        }

        private void TSB_yenile_Click(object sender, EventArgs e)
        {
            RTB_metinyazma.Clear(); 
            TSSL_harfsayisi.Text = "Karakter Sayısı: 0";
        }

        private void TSMI_yeni_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_ac_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "RTF Dosyaları (*.rtx)|*.rtx|Tüm Dosyalar (*.*)|*.*";
                openFileDialog.DefaultExt = "rtx";
                openFileDialog.FileName = "YeniDosya.rtx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    if (!File.Exists(fileName))
                    {
                        using (File.Create(fileName)) { }
                    }

                    RTB_metinyazma.Text = File.ReadAllText(fileName);
                }
            }
        }

        private void TSMI_kaydet_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.rtx)|*.rtx|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, RTB_metinyazma.Text);
                }
            }
        }

        private void TSMI_yazdir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(RTB_metinyazma.Text, new Font("Arial", 12), Brushes.Black, 0, 0);
            };

            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print(); 
            }
        }

        private void TSMI_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RTB_metinyazma_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button ==MouseButtons .Right)
            {
                contextMenuStrip1.Show(RTB_metinyazma, new Point(e.X, e.Y));
            }
        }

        private void TSMI_kes_Click(object sender, EventArgs e)
        {
            RTB_metinyazma.Cut();
        }

        private void TSMI_kopyala_Click(object sender, EventArgs e)
        {
            RTB_metinyazma.Copy();
        }

        private void TSMI_yapistir_Click(object sender, EventArgs e)
        {
            RTB_metinyazma.Paste();
        }
        private void WordPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RTB_metinyazma.Text.Length > 0) 
            {
                DialogResult sonuc = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (sonuc == DialogResult.Yes)
                {
                    TSB_kaydet.PerformClick();
                    e.Cancel = false;
                }
                else if (sonuc == DialogResult.No)
                {
                    e.Cancel = false; 
                }
                else if (sonuc == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = false; 
            }
        }
    }
}
