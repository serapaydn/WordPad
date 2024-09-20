using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Odev2._5Wordpad
{
    public partial class Giris : Form
    {
        private RichTextBox _RTBMetin;
        public Giris(RichTextBox rtb)
        {
            InitializeComponent();
            _RTBMetin = rtb;
        }

        private void TSCB_yazitipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = TSCB_yazitipi.SelectedItem.ToString();
            _RTBMetin.Font = new Font(selectedFont, _RTBMetin.Font.Size);
        }
        private void TSCB_yazitipiboyutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TSCB_yazitipiboyutu.SelectedItem.ToString(), out int fontSize))
            {
                _RTBMetin.Font = new Font(_RTBMetin.Font.FontFamily, fontSize);
            }
        }

        private void TSB_kalin_Click(object sender, EventArgs e)
        {
            Font mevcutYaziTipi = _RTBMetin.SelectionFont;
            FontStyle newFontStyle;

            if (mevcutYaziTipi != null)
            {
                newFontStyle = mevcutYaziTipi.Style ^ FontStyle.Bold;
                _RTBMetin.SelectionFont = new Font(mevcutYaziTipi, newFontStyle);
            }
        }

        private void TSB_italik_Click(object sender, EventArgs e)
        {
            Font mevcutYaziTipi = _RTBMetin.SelectionFont;
            FontStyle newFontStyle;

            if (mevcutYaziTipi != null)
            {
                newFontStyle = mevcutYaziTipi.Style ^ FontStyle.Italic;
                _RTBMetin.SelectionFont = new Font(mevcutYaziTipi, newFontStyle);
            }
        }

        private void TSB_altiçizili_Click(object sender, EventArgs e)
        {
            Font mevcutYaziTipi = _RTBMetin.SelectionFont;
            FontStyle newFontStyle;

            if (mevcutYaziTipi != null)
            {
                newFontStyle = mevcutYaziTipi.Style ^ FontStyle.Underline;
                _RTBMetin.SelectionFont = new Font(mevcutYaziTipi, newFontStyle);
            }
        }

        private void TSB_ustuçizili_Click(object sender, EventArgs e)
        {
            Font mevcutYaziTipi = _RTBMetin.SelectionFont;
            FontStyle newFontStyle;

            if (mevcutYaziTipi != null)
            {
                newFontStyle = mevcutYaziTipi.Style ^ FontStyle.Strikeout;
                _RTBMetin.SelectionFont = new Font(mevcutYaziTipi, newFontStyle);
            }
        }

        private void TSB_renk_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _RTBMetin.SelectionColor = colorDialog1.Color;
            }
        }

        private void TSB_solahizala_Click(object sender, EventArgs e)
        {
            _RTBMetin.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void TSB_ortala_Click(object sender, EventArgs e)
        {
            _RTBMetin.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void TSB_sagahizala_Click(object sender, EventArgs e)
        {
            _RTBMetin.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void TSB_listele_Click(object sender, EventArgs e)
        {
            _RTBMetin.AppendText("• " + _RTBMetin.SelectedText + Environment.NewLine);
        }
        private void TSCB_satiraraligi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void TSB_resimekle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Resim Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    try
                    {
                        Image img = Image.FromFile(imagePath);
                        Clipboard.SetDataObject(img);
                        _RTBMetin.Paste();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim eklenirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void TSB_tarihekle_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            _RTBMetin.AppendText(currentDate + Environment.NewLine);
        }
        private void TSB_nesneekle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Tüm Dosyalar|*.*";
                openFileDialog.Title = "Dosya Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    _RTBMetin.AppendText(filePath + Environment.NewLine);
                }
            }
        }

        private void TSB_yapistir_Click(object sender, EventArgs e)
        {
            _RTBMetin.Paste();
        }

        private void TSB_kes_Click(object sender, EventArgs e)
        {
            _RTBMetin.Cut();

        }

        private void TSB_kopyala_Click(object sender, EventArgs e)
        {
            _RTBMetin.Copy();
        }


    }
}
