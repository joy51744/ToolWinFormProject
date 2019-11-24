using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToolWinFormProject
{
    public partial class Watermark : Form
    {
        public Watermark()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxPicture.Text = this.openFileDialog1.FileName;
            }

            if (textBoxPicture.Text.Trim() == "")
            {
                MessageBox.Show("原圖不存在！");
                return;
            }
            else
            {
                string SourceImagePath = textBoxPicture.Text.Trim();

                string strPath = Path.GetFullPath(SourceImagePath).Replace(Path.GetFileName(SourceImagePath), "");

                string sExt = SourceImagePath.Substring(
          SourceImagePath.LastIndexOf(".")).ToLower();

                string ThumbnailImage = strPath + DateTime.Now.Ticks.ToString() + sExt;

                WaterMarkBll objWMB = new WaterMarkBll();
                objWMB.ToThumbnailImages(SourceImagePath, ThumbnailImage, pictureBoxSource.Width);

                pictureBoxSource.Image = Image.FromFile(ThumbnailImage);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxPicture.Text.Trim() == "")
            {
                MessageBox.Show("原圖不存在！");
                return;
            }
            if (textBoxWatermark.Text.Trim() == "")
            {
                MessageBox.Show("水印内容不存在！");
                return;
            }
            if (!radioButtonFont.Checked && !radioButtonPicture.Checked)
            {
                MessageBox.Show("水印類型未選擇！");
                return;
            }
            if (comboBoxPosition.Text.Trim() == "")
            {
                MessageBox.Show("水印位置未選擇！");
                return;
            }

            string SourceImagePath = textBoxPicture.Text.Trim();

            string strPath = Path.GetFullPath(SourceImagePath).Replace(Path.GetFileName(SourceImagePath), "");

            string sExt = SourceImagePath.Substring(
      SourceImagePath.LastIndexOf(".")).ToLower();

            string SaveImagePath = strPath + DateTime.Now.Ticks.ToString() + sExt;
            WaterMarkBll objWMB = new WaterMarkBll();

            WaterMarkPosition wmpPosition = new WaterMarkPosition();
            switch (comboBoxPosition.Text)
            {
                case "左上角":
                    wmpPosition = WaterMarkPosition.WMP_Left_Top;
                    break;

                case "右上角":
                    wmpPosition = WaterMarkPosition.WMP_Right_Top;
                    break;

                case "居中":
                    wmpPosition = WaterMarkPosition.WMP_Center;
                    break;

                case "左下角":
                    wmpPosition = WaterMarkPosition.WMP_Left_Bottom;
                    break;

                case "右下角":
                    wmpPosition = WaterMarkPosition.WMP_Right_Bottom;
                    break;
            }

            if (radioButtonFont.Checked)
            {
                objWMB.addWaterMark(SourceImagePath, SaveImagePath, wmpPosition, WaterMarkType.TextMark, textBoxWatermark.Text);
            }
            else
            {
                objWMB.addWaterMark(SourceImagePath, SaveImagePath, wmpPosition, WaterMarkType.ImageMark, textBoxWatermark.Text);
            }

            string ThumbnailImage = strPath + DateTime.Now.Ticks.ToString() + sExt;
            objWMB.ToThumbnailImages(SaveImagePath, ThumbnailImage, pictureBoxWatermark.Width);

            pictureBoxWatermark.Image = Image.FromFile(ThumbnailImage);
        }

        private void buttonWatermarkFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.textBoxWatermark.Text = this.openFileDialog2.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image files (*.jpg)|*.jpg";
            save.FilterIndex = 0;
            save.RestoreDirectory = true;
            save.Title = "導出文件儲存路徑";
            save.FileName = null;
            save.ShowDialog();
            string path = save.FileName;
            Image image = pictureBoxWatermark.Image;
            image.Save(path);
        }
    }
}