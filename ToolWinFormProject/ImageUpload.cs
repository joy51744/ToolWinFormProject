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
    public partial class ImageUpload : Form
    {
        public ImageUpload()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.gif; *.bmp) | *.jpg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text, Path.Combine(@"C:\Users\pc\source\repos\ToolWinFormProject\ToolWinFormProject\Upload\", Path.GetFileName(textBox1.Text)), true);
            labelMessage.Text = "Image file save successfully.";
        }
    }
}