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
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void 圖片格式轉換toolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureFormatConvert main = new PictureFormatConvert();
            this.Visible = false;
            main.Show();
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
    }
}