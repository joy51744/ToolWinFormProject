using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.International.Converters.PinYinConverter;

namespace ToolWinFormProject
{
    public partial class CHTConvertPinYin : Form
    {
        public CHTConvertPinYin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 漢字轉拼音
        /// </summary>
        /// <param name="str">要轉換的文字</param>
        /// <returns>返回拼音結果(小寫)</returns>
        public string GetPinYin(string str)
        {
            StringBuilder strResult = new StringBuilder();
            foreach (var item in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(item);
                    string t = chineseChar.Pinyins[0].ToString();
                    //由于返回的结果t是拼音加序号的字符串，故要去掉后面的序号
                    strResult.Append(t.Substring(0, t.Length - 1));
                }
                catch (Exception)
                {
                    strResult.Append(item.ToString());
                }
            }
            //因为转换得到的结果是全部大写，故在这里全部转换成小写
            return strResult.ToString().ToLower();
        }

        /// <summary>
        /// 获取拼音的首字母
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetFirstPinYin(string str)
        {
            StringBuilder strResult = new StringBuilder();
            foreach (var item in str)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(item);
                    string t = chineseChar.Pinyins[0].ToString();
                    strResult.Append(t.Substring(0, 1));
                }
                catch (Exception)
                {
                    strResult.Append(item.ToString());
                }
            }
            return strResult.ToString().ToLower();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {            //取得输入汉字输入框TextBox的文本
            string chineseInputStr = this.textBoxInput.Text;
            //取得拼音的结果
            string resultStr = GetPinYin(chineseInputStr);
            //把取得拼音的结果赋值给拼音输出文本框TextBox中
            this.textBoxOutput.Text = resultStr;
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