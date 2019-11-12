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
    public partial class Media2 : Form
    {
        public Media2()
        {
            InitializeComponent();
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void 音樂播放器1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            this.Visible = false;
            media.Show();
        }

        private void 視頻播放器1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media3 media = new Media3();
            this.Visible = false;
            media.Show();
        }

        private void 視頻播放器2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media4 media = new Media4();
            this.Visible = false;
            media.Show();
        }

        private void ButtonBrosewer_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "mp3,wav,mp4,mov,wmv,mpg|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }
    }
}