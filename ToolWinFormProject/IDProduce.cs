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
    public partial class IDProduce : Form
    {
        private void IDProduce_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 22; i++)
            {
                comboBox1.Items.Add(address[i]);
            }
        }

        private int[] id = new int[11];

        private string[] address = new string[] { "A.台北市","B.台中市","C.基隆市","D.台南市",
        "E.高雄市","F.新北市","G.宜蘭縣","H.桃園縣","I.嘉義市","J.新竹縣","K.苗栗縣",
        "M.南投縣","N.彰化縣","O.新竹市","P.雲林縣","Q.嘉義縣","T.屏東縣","U.花蓮縣",
        "V.台東縣","W.金門縣","X.澎湖縣","Z.連江縣" };

        public IDProduce()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void ButtonProduce_Click(object sender, EventArgs e)
        {
            int rnd, remainder; //remainder為身分證產生時的餘數
            textBox1.Text = "";
            Random rnd1 = new Random();
            rnd = rnd1.Next(0, 100000000); //決定身分證字號A1XXXXXXXX中，8個X的數字

            produce();

            if (radioButton1.Checked == true) { id[1] = 1; } //判斷第二碼點選是男生or女生
            else if (radioButton2.Checked == true) { id[1] = 2; }
            else if (radioButton3.Checked == true) { id[1] = (rnd % 2) + 1; }

            for (int i = 2; i <= 9; i++)
            {
                id[i] = Convert.ToInt16(rnd.ToString("D8").Substring(i - 2, 1));
                //id[i]=Convert.ToInt16(rnd.ToString().PadLeft(8,'0').Substring(i-2, 1));
                //以上兩種，皆可將未滿8個字元的rnd亂數補至8字元(以0增加)
                //ex:rnd=238則會變成00000238
            }

            remainder = (id[0] / 10 + id[0] % 10 * 9 + id[1] * 8 + id[2] * 7
            + id[3] * 6 + id[4] * 5 + id[5] * 4 + id[6] * 3 + id[7] * 2
            + id[8] * 1 + id[9] * 1) % 10;

            if (remainder == 0)
            {
                textBox1.Text = textBox1.Text.Replace(" ", "") + id[10].ToString().Replace(id[10].ToString(), Convert.ToChar(id[10]).ToString());
                for (int i = 1; i <= 9; i++)
                { textBox1.Text += id[i].ToString().Replace(" ", ""); }
            }
            else if (remainder > 0)
            {
                id[9] = (id[9] + (10 - remainder)) % 10; //檢查碼還原

                textBox1.Text = textBox1.Text.Replace(" ", "") + id[10].ToString().Replace(id[10].ToString(), Convert.ToChar(id[10]).ToString());

                for (int i = 1; i <= 9; i++)
                {
                    //按下身分證產生按鈕,產生的身分證號碼會顯示在textbox上面
                    textBox1.Text += id[i].ToString().Replace(" ", "");
                }
            }
        }

        private void produce()
        {
            if (comboBox1.Text == address[0]) { id[0] = 10; id[10] = 65; }
            else if (comboBox1.Text == address[1]) { id[0] = 11; id[10] = 66; }
            else if (comboBox1.Text == address[2]) { id[0] = 12; id[10] = 67; }
            else if (comboBox1.Text == address[3]) { id[0] = 13; id[10] = 68; }
            else if (comboBox1.Text == address[4]) { id[0] = 14; id[10] = 69; }
            else if (comboBox1.Text == address[5]) { id[0] = 15; id[10] = 70; }
            else if (comboBox1.Text == address[6]) { id[0] = 16; id[10] = 71; }
            else if (comboBox1.Text == address[7]) { id[0] = 17; id[10] = 72; }
            else if (comboBox1.Text == address[8]) { id[0] = 34; id[10] = 73; }
            else if (comboBox1.Text == address[9]) { id[0] = 18; id[10] = 74; }
            else if (comboBox1.Text == address[10]) { id[0] = 19; id[10] = 75; }
            else if (comboBox1.Text == address[11]) { id[0] = 21; id[10] = 77; }
            else if (comboBox1.Text == address[12]) { id[0] = 22; id[10] = 78; }
            else if (comboBox1.Text == address[13]) { id[0] = 35; id[10] = 79; }
            else if (comboBox1.Text == address[14]) { id[0] = 23; id[10] = 80; }
            else if (comboBox1.Text == address[15]) { id[0] = 24; id[10] = 81; }
            else if (comboBox1.Text == address[16]) { id[0] = 27; id[10] = 84; }
            else if (comboBox1.Text == address[17]) { id[0] = 28; id[10] = 85; }
            else if (comboBox1.Text == address[18]) { id[0] = 29; id[10] = 86; }
            else if (comboBox1.Text == address[19]) { id[0] = 32; id[10] = 87; }
            else if (comboBox1.Text == address[20]) { id[0] = 30; id[10] = 88; }
            else if (comboBox1.Text == address[21]) { id[0] = 33; id[10] = 90; }
        }

        private void 身分證驗證ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ID id = new ID();
            this.Visible = false;
            id.Show();
        }
    }
}