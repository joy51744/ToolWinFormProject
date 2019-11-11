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
    public partial class ID : Form
    {
        public ID()
        {
            InitializeComponent();
        }

        private int[] id = new int[11];

        private string[] address = new string[] { "A.台北市","B.台中市","C.基隆市","D.台南市",
                                                  "E.高雄市","F.新北市","G.宜蘭縣","H.桃園縣","I.嘉義市","J.新竹縣","K.苗栗縣","L.台中縣",
                                                  "M.南投縣","N.彰化縣","O.新竹市","P.雲林縣","Q.嘉義縣","R.台南縣","S.高雄縣","T.屏東縣",
                                                  "U.花蓮縣","V.台東縣","W.金門縣","X.澎湖縣","Y.陽明山管理局","Z.連江縣","+隨機挑選出生地+" };

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            double check;
            double a;

            a = Convert.ToDouble(textBoxID.Text.Length.ToString());

            if (textBoxID.Text.Length == 0)
            {
                MessageBox.Show("請輸入身分證字號哦^^");
            }
            else if (textBoxID.Text.Length < 10)
            {
                MessageBox.Show("你輸入的內容不能少於10個字,你還欠 " + (10 - a) + "個字");
            }
            else if (textBoxID.Text.Length > 10)
            {
                MessageBox.Show("你輸入的內容超過10個字,你多打 " + (a - 10) + "個字");
            }
            else if (textBoxID.Text.Length == 10)
            {//將英文轉成大寫,並已char儲存至id[0]
                id[0] = Convert.ToChar(textBoxID.Text.Substring(0, 1).ToUpper());

                if ((id[0] < 65) || (id[0] > 90))
                {
                    MessageBox.Show("第一個字只能輸入英文字母");
                }
                else if ((id[0] >= 65) && (id[0] <= 90))
                {
                    trans();
                    id[1] = Convert.ToChar(textBoxID.Text.Substring(1, 1).ToUpper());

                    if (id[1] < 49 || id[1] > 50)
                    {//判斷第二個字是否為1或2
                        MessageBox.Show("第二個字只能輸入1或2");
                        id[1] = -1;
                    }
                    else if (id[1] == 49 || id[1] == 50)
                    {
                        id[1] = Convert.ToInt32(textBoxID.Text.Substring(1, 1));

                        //將輸入的身分證字號分別存在id[i],取出i開始長度為1的字串
                        for (int i = 2; i <= textBoxID.Text.Length - 1; i++)
                        {
                            id[i] = Convert.ToChar(textBoxID.Text.Substring(i, 1));

                            //判斷3-10個字是否輸入為0-9,沒有則跳出視窗並停止
                            if (id[i] < 48 || id[i] > 57)
                            {
                                MessageBox.Show("你第 " + (i + 1) + " 個字,請打0-9的數字");
                                id[i] = -8;
                                break;//進行for迴圈運算時,運作到此行,程式便停止動作
                            }
                            else
                            {
                                //當輸入為0-9已內有效數字時,各項數字會分別存入各項陣列id[i]裡
                                //並將陣列id[i]帶入判別式(check),最後印出正確性與否
                                id[i] = Convert.ToInt32(textBoxID.Text.Substring(i, 1));
                                check = (id[0] / 10 + id[0] % 10 * 9 + id[1] * 8 + id[2] * 7 + id[3] * 6 + id[4] * 5 + id[5] * 4 + id[6] * 3 + id[7] * 2 + id[8] * 1 + id[9] * 1) % 10;

                                if (check == 0 && i == 9)
                                {
                                    MessageBox.Show("身分證字號有效哦^^");
                                }
                                else if (check > 0 && i == 9)
                                {
                                    MessageBox.Show("此組身分證無效!!");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ID_Load(object sender, EventArgs e)
        {
            buttonCheck.Text = "身分證驗證";
            comboBox1.Text = "請選擇身分證出生地";

            label2.Text = "目前輸入字數為:" + textBoxID.Text.Length.ToString().ToString();

            textBoxID.MaxLength = 10;
            for (int i = 0; i <= 26; i++)
            {
                comboBox1.Items.Add(address[i]);
            }
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "目前輸入字數為: " + textBoxID.Text.Length.ToString().ToString();
        }

        private void trans()
        {
            if (id[0] == 65)
            {
                comboBox1.Text = address[0];
                id[0] = 10;
            }
            else if (id[0] == 66)
            {
                comboBox1.Text = address[1];
                id[0] = 11;
            }
            else if (id[0] == 67)
            {
                comboBox1.Text = address[2];
                id[0] = 12;
            }
            else if (id[0] == 68)
            {
                comboBox1.Text = address[3];
                id[0] = 13;
            }
            else if (id[0] == 69)
            {
                comboBox1.Text = address[4];
                id[0] = 14;
            }
            else if (id[0] == 70)
            {
                comboBox1.Text = address[5];
                id[0] = 15;
            }
            else if (id[0] == 71)
            {
                comboBox1.Text = address[6];
                id[0] = 16;
            }
            else if (id[0] == 72)
            {
                comboBox1.Text = address[7];
                id[0] = 17;
            }
            else if (id[0] == 73)
            {
                comboBox1.Text = address[8];
                id[0] = 34;
            }
            else if (id[0] == 74)
            {
                comboBox1.Text = address[9];
                id[0] = 18;
            }
            else if (id[0] == 75)
            {
                comboBox1.Text = address[10];
                id[0] = 19;
            }
            else if (id[0] == 76)
            {
                comboBox1.Text = address[11];
                id[0] = 20;
            }
            else if (id[0] == 77)
            {
                comboBox1.Text = address[12];
                id[0] = 21;
            }
            else if (id[0] == 78)
            {
                comboBox1.Text = address[13];
                id[0] = 22;
            }
            else if (id[0] == 79)
            {
                comboBox1.Text = address[14];
                id[0] = 35;
            }
            else if (id[0] == 80)
            {
                comboBox1.Text = address[15];
                id[0] = 23;
            }
            else if (id[0] == 81)
            {
                comboBox1.Text = address[16];
                id[0] = 24;
            }
            else if (id[0] == 82)
            {
                comboBox1.Text = address[17];
                id[0] = 25;
            }
            else if (id[0] == 83)
            {
                comboBox1.Text = address[18];
                id[0] = 26;
            }
            else if (id[0] == 84)
            {
                comboBox1.Text = address[19];
                id[0] = 27;
            }
            else if (id[0] == 85)
            {
                comboBox1.Text = address[20];
                id[0] = 28;
            }
            else if (id[0] == 86)
            {
                comboBox1.Text = address[21];
                id[0] = 29;
            }
            else if (id[0] == 87)
            {
                comboBox1.Text = address[22];
                id[0] = 30;
            }
            else if (id[0] == 88)
            {
                comboBox1.Text = address[23];
                id[0] = 31;
            }
            else if (id[0] == 89)
            {
                comboBox1.Text = address[24];
                id[0] = 32;
            }
            else if (id[0] == 90)
            {
                comboBox1.Text = address[25];
                id[0] = 33;
            }
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}