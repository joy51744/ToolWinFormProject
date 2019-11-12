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
    public partial class Media3 : Form
    {
        public Media3()
        {
            InitializeComponent();
        }

        private void Media3_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
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

        private void 音樂播放器2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media2 media = new Media2();
            this.Visible = false;
            media.Show();
        }

        private void 視頻播放器2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media4 media = new Media4();
            this.Visible = false;
            media.Show();
        }
    }
}