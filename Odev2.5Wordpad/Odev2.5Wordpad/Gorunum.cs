using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2._5Wordpad
{
    public partial class Gorunum : Form
    {
        private RichTextBox _RTBMetin;
        public Gorunum(RichTextBox rtb)
        {
            InitializeComponent();
            _RTBMetin = rtb;
        }

        private void TSB_yakinlastir_Click(object sender, EventArgs e)
        {
            float mevcutboyut = _RTBMetin.Font.Size;
            if (mevcutboyut < 72)
            {
                _RTBMetin.Font = new Font(_RTBMetin.Font.FontFamily, mevcutboyut + 2);
            }
        }

        private void TSB_uzaklastir_Click(object sender, EventArgs e)
        {
            float mevcutboyut = _RTBMetin.Font.Size;
            if (mevcutboyut > 8)
            {
                _RTBMetin.Font = new Font(_RTBMetin.Font.FontFamily, mevcutboyut - 2);
            }
        }

        private bool isCetvelVisible = false;
        private void TSB_cetvel_Click(object sender, EventArgs e)
        {
            isCetvelVisible = !isCetvelVisible;
            panelcetvel.Visible = isCetvelVisible; 
            panelcetvel.Invalidate();
        }
        private void panelcetvel_Paint(object sender, PaintEventArgs e)
        {
            if (!isCetvelVisible) return; 

            Graphics g = e.Graphics;
            g.Clear(Color.White); 

            g.DrawLine(new Pen(Color.Black, 2), 0, 25, panelcetvel.Width, 25);

            for (int i = 0; i <= panelcetvel.Width; i += 10)
            {
                g.DrawLine(Pens.Black, i, 25, i, 20);

                if (i % 50 == 0)
                {
                    g.DrawLine(Pens.Black, i, 25, i, 10);
                    g.DrawString((i / 10).ToString(), this.Font, Brushes.Black, i - 5, 5);
                }
            }

        
        }
    }
}

