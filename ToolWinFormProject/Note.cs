using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace ToolWinFormProject
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HTCAPTION = 2;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键
            {
                ReleaseCapture();   // 释放捕获
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);    // 拖动窗体
            }
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            string str;
            str = this.richTextBox1.Text;
            StreamWriter sw = new StreamWriter("memo.txt", false);
            sw.WriteLine(str);
            sw.Close();//写入
            MessageBox.Show("已保存");
        }

        private void Note_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"memo.txt"))
            {
                //存在
                string str;
                StreamReader sr = new StreamReader("memo.txt", false);
                str = sr.ReadLine().ToString();
                sr.Close();
                this.richTextBox1.Text = str;///读取
            }
            else
            {
                //不存在
                string spr;
                spr = this.richTextBox1.Text;
                StreamWriter sw = new StreamWriter("memo.txt", false);
                sw.WriteLine(spr);
                sw.Close();//写入
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }
    }
}