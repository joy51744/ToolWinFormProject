﻿using System;
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
        //https://download.csdn.net/download/xuewuzhijing10/3162530
            Converter timer = new Converter();
            this.Visible = false;
            timer.Show();
        }

        private void buttonRemind_Click(object sender, EventArgs e)
        {
        //https://blog.csdn.net/qq_38261174/article/details/85601645
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

        private void buttonID_Click(object sender, EventArgs e)
        {
            ID id = new ID();
            this.Visible = false;
            id.Show();
        }

        private void buttonIDVerification_Click(object sender, EventArgs e)
        {
            IDProduce id = new IDProduce();
            this.Visible = false;
            id.Show();
        }

        private void buttonBarCode_Click(object sender, EventArgs e)
        {
            BarCode barCode = new BarCode();
            this.Visible = false;
            barCode.Show();
        }

        private void buttonScreenShot_Click(object sender, EventArgs e)
        {
        //https://blog.csdn.net/qq_38261174/article/details/85274325
            ScreenShot screen = new ScreenShot();
            this.Visible = false;
            screen.Show();
        }

        private void buttonMedia_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            this.Visible = false;
            media.Show();
        }

        private void buttonNote_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            this.Visible = false;
            note.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PortfolioMainForm.exe");
            this.Visible = false;
        }
    }
}