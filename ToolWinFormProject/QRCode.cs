using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace ToolWinFormProject
{
    public partial class QRCode : Form
    {
        public QRCode()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw qr = new CodeQrBarcodeDraw();
            pictureBox1.Image = qr.Draw(textBox1.Text, 100);
        }

        private void BarCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarCode code = new BarCode();
            this.Visible = false;
            code.Show();
        }
    }
}