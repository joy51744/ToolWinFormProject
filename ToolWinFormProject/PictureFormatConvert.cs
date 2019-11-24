using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolWinFormProject
{
    public partial class PictureFormatConvert : Form
    {
        public PictureFormatConvert()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.FileName.Trim() == "")
                return;
            try
            {
                this.pictureBox1.Image = System.Drawing.Bitmap.FromFile(this.openFileDialog1.FileName);
            }
            catch (Exception Err)
            {
                MessageBox.Show(this, "打開圖片文件錯誤！", "訊息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            System.String StrFileName = this.saveFileDialog1.FileName;
            if (StrFileName.Trim() == "")
                return;
            try
            {
                if (this.radioButton1.Checked)
                {
                    this.pictureBox1.Image.Save(StrFileName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (this.radioButton2.Checked)
                {
                    this.pictureBox1.Image.Save(StrFileName + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                }
                if (this.radioButton3.Checked)
                {
                    this.pictureBox1.Image.Save(StrFileName + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                }
                if (this.radioButton4.Checked)
                {
                    this.pictureBox1.Image.Save(StrFileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                if (this.radioButton5.Checked)
                {
                    this.pictureBox1.Image.Save(StrFileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(this, "保存圖片時發生錯誤！", "訊息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 金額大小寫轉換toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinanceConvert main = new FinanceConvert();
            this.Visible = false;
            main.Show();
        }

        private void 漢字拼音轉換toolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHTConvertPinYin main = new CHTConvertPinYin();
            this.Visible = false;
            main.Show();
        }

        private void 簡體繁體轉換toolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHTConvertCHS main = new CHTConvertCHS();
            this.Visible = false;
            main.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}