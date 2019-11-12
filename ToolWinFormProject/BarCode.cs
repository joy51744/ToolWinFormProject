using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace ToolWinFormProject
{
    public partial class BarCode : Form
    {
        public BarCode()
        {
            InitializeComponent();
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void QRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRCode code = new QRCode();
            this.Visible = false;
            code.Show();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Barcode barCode = new Barcode();
            Color forecolor = Color.Black;
            Color backcolor = Color.Transparent;
            Image img = barCode.Encode(TYPE.UPCA, textBox1.Text, forecolor, backcolor, (int)(pictureBox1.Width * 0.8), (int)(pictureBox1.Height * 0.8));
            pictureBox1.Image = img;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            using (SaveFileDialog save = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(save.FileName);
                }
            }
        }
    }
}