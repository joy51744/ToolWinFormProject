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
    public partial class FinanceConvert : Form
    {
        public FinanceConvert()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                this.textBox2.Text = ConvertToCn(Convert.ToDecimal(this.textBox1.Text));
            }
        }

        public static string ConvertToCn(decimal num)
        {
            string str1 = "零壹貳叁肆伍陸柒捌玖"; //0-9所對應的漢字
            string str2 = "萬仟佰拾億仟佰拾萬仟佰拾元角分"; //數字位所對應的漢字
            string str3 = ""; //從原num值中取出的值
            string str4 = ""; //數字的字符串形式
            string str5 = ""; //人民幣大寫金額形式
            int i; //循環變量
            int j; //num的值乘以100的字符串長度
            string ch1 = ""; //數字的漢語讀法
            string ch2 = ""; //數字位的漢字讀法
            int nzero = 0; //用來計算連續的零值是幾個
            int temp; //從原num值中取出的值

            num = Math.Round(Math.Abs​​(num), 2); //將num取絕對值並四捨五入取2位小數
            str4 = ((long)(num * 100)).ToString(); //將num乘100並轉換成字符串形式
            j = str4.Length; //找出最高位
            if (j > 15) { return "溢出"; }
            str2 = str2.Substring(15 - j); //取出對應位數的str2的值。如：200.55,j為5所以str2=佰拾元角分

            //循環取出每一位需要轉換的值
            for (i = 0; i < j; i++)
            {
                str3 = str4.Substring(i, 1); //取出需轉換的某一位的值
                temp = Convert.ToInt32(str3); //轉換為數字
                if (i != (j - 3) && i != (j - 7) && i != (j - 11) && i != (j - 15))
                {
                    //當所取位數不為元、萬、億、萬億上的數字時
                    if (str3 == "0")
                    {
                        ch1 = "";
                        ch2 = "";
                        nzero = nzero + 1;
                    }
                    else
                    {
                        if (str3 != "0" && nzero != 0)
                        {
                            ch1 = "零" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                    }
                }
                else
                {
                    //該位是萬億，億，萬，元位等關鍵位
                    if (str3 != "0" && nzero != 0)
                    {
                        ch1 = "零" + str1.Substring(temp * 1, 1);
                        ch2 = str2.Substring(i, 1);
                        nzero = 0;
                    }
                    else
                    {
                        if (str3 != "0" && nzero == 0)
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3 == "0" && nzero >= 3)
                            {
                                ch1 = "";
                                ch2 = "";
                                nzero = nzero + 1;
                            }
                            else
                            {
                                if (j >= 11)
                                {
                                    ch1 = "";
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    ch1 = "";
                                    ch2 = str2.Substring(i, 1);
                                    nzero = nzero + 1;
                                }
                            }
                        }
                    }
                }
                if (i == (j - 11) || i == (j - 3))
                {
                    //如果該位是億位或元位，則必須寫上
                    ch2 = str2.Substring(i, 1);
                }
                str5 = str5 + ch1 + ch2;

                if (i == j - 1 && str3 == "0")
                {
                    //最後一位（分）為0時，加上“整”
                    str5 = str5 + '整';
                }
            }
            if (num == 0)
            {
                str5 = "零元整";
            }
            return str5;
        }

        public static string ConvertToCn(string numstr)
        {
            decimal num = 0;
            if (decimal.TryParse(numstr, out num))
            {
                return ConvertToCn(num);
            }
            else
            {
                return "非數字形式！";
            }
        }

        private void 圖片格式轉換toolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureFormatConvert main = new PictureFormatConvert();
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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}