using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;

namespace ToolWinFormProject
{
    public partial class CHTConvertCHS : Form
    {
        public CHTConvertCHS()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void CHTConvertCHS_Load(object sender, EventArgs e)
        {
            this.txbSourdeString.Text = "資料來源";
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            this.txbConvertString.Text = Convert(this.txbSourdeString.Text, "Big5");
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            this.txbConvertString.Text = Convert(this.txbSourdeString.Text, "GB2312");
        }

        private string Convert(string SourceString, string Language)
        {
            string newString = string.Empty;
            switch (Language)
            {
                case "Big5":
                    newString = ChineseConverter.Convert(SourceString, ChineseConversionDirection.SimplifiedToTraditional);
                    break;

                case "GB2312":
                    newString = ChineseConverter.Convert(SourceString, ChineseConversionDirection.TraditionalToSimplified);
                    break;

                default:
                    newString = SourceString;
                    break;
            }
            return newString;
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

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}