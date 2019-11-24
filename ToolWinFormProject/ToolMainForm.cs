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
    public partial class ToolMainForm : Form
    {
        public ToolMainForm()
        {
            InitializeComponent();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            Converter timer = new Converter();
            this.Visible = false;
            timer.Show();
        }

        private void buttonRemind_Click(object sender, EventArgs e)
        {
            Remind remind = new Remind();
            this.Visible = false;
            remind.Show();
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            this.Visible = false;
            password.Show();
        }

        private void buttonBarCode_Click(object sender, EventArgs e)
        {
            BarCode barCode = new BarCode();
            this.Visible = false;
            barCode.Show();
        }

        private void buttonID_Click(object sender, EventArgs e)
        {
            ID id = new ID();
            this.Visible = false;
            id.Show();
        }

        private void buttonWatermark_Click(object sender, EventArgs e)
        {
            Watermark watermark = new Watermark();
            this.Visible = false;
            watermark.Show();
        }

        private void buttonScreenShot_Click(object sender, EventArgs e)
        {
            ScreenShot screen = new ScreenShot();
            this.Visible = false;
            screen.Show();
        }

        private void buttonNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            this.Visible = false;
            note.Show();
        }

        private void buttonMagnifyingGlass_Click(object sender, EventArgs e)
        {
            MagnifyingGlass compress = new MagnifyingGlass();
            this.Visible = false;
            compress.Show();
        }

        private void buttonMedia_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            this.Visible = false;
            media.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PortfolioMainForm.exe");
            this.Visible = false;
        }

        private void buttonPictureCut_Click(object sender, EventArgs e)
        {
            PictureCut cut = new PictureCut();
            this.Visible = false;
            cut.Show();
        }
    }
}