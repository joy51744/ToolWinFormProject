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
using Microsoft.VisualBasic;

namespace ToolWinFormProject
{
    public partial class Remind : Form
    {
        [DllImport("kernel32", EntryPoint = "Beep")]
        public extern static int Beep(int dwfreq, int dwduration);

        public int intHour, intMouit, intSecon;

        public Remind()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime get_time1 = Convert.ToDateTime(DateTime.Now.ToString());
            DateTime sta_ontime1 = Convert.ToDateTime(Convert.ToDateTime(textBox2.Text.Trim().ToString()));
            long dat = DateAndTime.DateDiff("s", get_time1, sta_ontime1, FirstDayOfWeek.Sunday, FirstWeekOfYear.FirstFourDays);
            if (dat > 0)
            {
                if (timer2.Enabled != true)
                {
                    timer2.Enabled = true;
                    label4.Text = "鬧鐘已啟動";
                    label1.Text = "剩餘" + dat.ToString() + "秒";
                }
                else
                {
                    MessageBox.Show("時鐘已經啟動，請取消後再啟動");
                }
            }
            else
            {
                long hour = 24 * 3600 + dat;
                timer2.Enabled = true;
                label4.Text = "鬧鐘已啟動";
                label1.Text = "剩餘" + hour.ToString() + "秒";
            }
        }

        private void Remind_Load(object sender, EventArgs e)
        {
            string strHour = DateTime.Now.TimeOfDay.Hours.ToString();
            string strMouit = DateTime.Now.TimeOfDay.Minutes.ToString();
            string strSecon = DateTime.Now.TimeOfDay.Seconds.ToString();
            if (Convert.ToInt32(strHour) < 10)
            {
                strHour = "0" + strHour;
            }
            if (Convert.ToInt32(strMouit) < 10)
            {
                strMouit = "0" + strMouit;
            }
            if (Convert.ToInt32(strSecon) < 10)
            {
                strSecon = "0" + strSecon;
            }
            textBox2.Text = strHour + ":" + strMouit + ":" + strSecon;
            intHour = Convert.ToInt32(strHour);
            intMouit = Convert.ToInt32(strMouit);
            intSecon = Convert.ToInt32(strSecon);
            numericUpDown3.Value = Convert.ToInt32(strHour);
            numericUpDown2.Value = Convert.ToInt32(strMouit);
            numericUpDown1.Value = Convert.ToInt32(strSecon);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strHour = DateTime.Now.TimeOfDay.Hours.ToString();
            string strMouit = DateTime.Now.TimeOfDay.Minutes.ToString();
            string strSecon = DateTime.Now.TimeOfDay.Seconds.ToString();
            if (Convert.ToInt32(strHour) < 10)
            {
                strHour = "0" + strHour;
            }
            if (Convert.ToInt32(strMouit) < 10)
            {
                strMouit = "0" + strMouit;
            }
            if (Convert.ToInt32(strSecon) < 10)
            {
                strSecon = "0" + strSecon;
            }
            textBox1.Text = strHour + ":" + strMouit + ":" + strSecon;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string Hour, Minute, second;
            if (numericUpDown1.Value == 60)
            {
                numericUpDown1.Value = 0;
                numericUpDown2.Value = Convert.ToInt32(numericUpDown2.Value) + 1;
                intMouit = Convert.ToInt32(numericUpDown2.Value);
                intSecon = Convert.ToInt32(numericUpDown1.Value);
                if (Convert.ToInt32(intHour) < 10)
                {
                    Hour = "0" + intHour.ToString() + ":";
                }
                else
                {
                    Hour = intHour.ToString() + ":";
                }
                if (Convert.ToInt32(intMouit) < 10)
                {
                    Minute = "0" + intMouit.ToString() + ":";
                }
                else
                {
                    Minute = intMouit.ToString() + ":";
                }
                if (Convert.ToInt32(intSecon) < 10)
                {
                    second = "0" + intSecon.ToString();
                }
                else
                {
                    second = intSecon.ToString();
                }
                textBox2.Text = Hour + Minute + second;
            }
            else
            {
                intSecon = Convert.ToInt32(numericUpDown1.Value);
                if (Convert.ToInt32(intHour) < 10)
                {
                    Hour = "0" + intHour.ToString() + ":";
                }
                else
                {
                    Hour = intHour.ToString() + ":";
                }
                if (Convert.ToInt32(intMouit) < 10)
                {
                    Minute = "0" + intMouit.ToString() + ":";
                }
                else
                {
                    Minute = intMouit.ToString() + ":";
                }
                if (Convert.ToInt32(intSecon) < 10)
                {
                    second = "0" + intSecon.ToString();
                }
                else
                {
                    second = intSecon.ToString();
                }
                textBox2.Text = Hour + Minute + second;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            string Hour, Minute, second;
            if (numericUpDown2.Value == 60)
            {
                numericUpDown2.Value = 0;
                numericUpDown3.Value = Convert.ToInt32(numericUpDown2.Value) + 1;
                intMouit = Convert.ToInt32(numericUpDown2.Value);
                intHour = Convert.ToInt32(numericUpDown3.Value);
                if (Convert.ToInt32(intHour) < 10)
                {
                    Hour = "0" + intHour.ToString() + ":";
                }
                else
                {
                    Hour = intHour.ToString() + ":";
                }
                if (Convert.ToInt32(intMouit) < 10)
                {
                    Minute = "0" + intMouit.ToString() + ":";
                }
                else
                {
                    Minute = intMouit.ToString() + ":";
                }
                if (Convert.ToInt32(intSecon) < 10)
                {
                    second = "0" + intSecon.ToString();
                }
                else
                {
                    second = intSecon.ToString();
                }
                textBox2.Text = Hour + Minute + second;
            }
            else
            {
                intMouit = Convert.ToInt32(numericUpDown2.Value);
                if (Convert.ToInt32(intHour) < 10)
                {
                    Hour = "0" + intHour.ToString() + ":";
                }
                else
                {
                    Hour = intHour.ToString() + ":";
                }
                if (Convert.ToInt32(intMouit) < 10)
                {
                    Minute = "0" + intMouit.ToString() + ":";
                }
                else
                {
                    Minute = intMouit.ToString() + ":";
                }
                if (Convert.ToInt32(intSecon) < 10)
                {
                    second = "0" + intSecon.ToString();
                }
                else
                {
                    second = intSecon.ToString();
                }
                textBox2.Text = Hour + Minute + second;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            string Hour, Minute, second;
            if (numericUpDown3.Value == 24)
            {
                numericUpDown3.Value = 0;
                intHour = Convert.ToInt32(numericUpDown3.Value);
                if (Convert.ToInt32(intHour) < 10)
                {
                    Hour = "0" + intHour.ToString() + ":";
                }
                else
                {
                    Hour = intHour.ToString() + ":";
                }
                if (Convert.ToInt32(intMouit) < 10)
                {
                    Minute = "0" + intMouit.ToString() + ":";
                }
                else
                {
                    Minute = intMouit.ToString() + ":";
                }
                if (Convert.ToInt32(intSecon) < 10)
                {
                    second = "0" + intSecon.ToString();
                }
                else
                {
                    second = intSecon.ToString();
                }
                textBox2.Text = Hour + Minute + second;
            }
            else
            {
                intHour = Convert.ToInt32(numericUpDown3.Value);
                if (Convert.ToInt32(intHour) < 10)
                {
                    Hour = "0" + intHour.ToString() + ":";
                }
                else
                {
                    Hour = intHour.ToString() + ":";
                }
                if (Convert.ToInt32(intMouit) < 10)
                {
                    Minute = "0" + intMouit.ToString() + ":";
                }
                else
                {
                    Minute = intMouit.ToString() + ":";
                }
                if (Convert.ToInt32(intSecon) < 10)
                {
                    second = "0" + intSecon.ToString();
                }
                else
                {
                    second = intSecon.ToString();
                }
                textBox2.Text = Hour + Minute + second;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime get_time1 = Convert.ToDateTime(DateTime.Now.ToString());
            DateTime sta_ontime1 = Convert.ToDateTime(Convert.ToDateTime(textBox2.Text.Trim().ToString()));
            long dat = DateAndTime.DateDiff("s", get_time1, sta_ontime1, FirstDayOfWeek.Sunday, FirstWeekOfYear.FirstFourDays);
            if (dat == 0)
            {
                Beep(200, 500);
                label4.Text = "時間已到";
                timer2.Enabled = false;
                MessageBox.Show("您設定的定時時間已到");
            }
            else
            {
                label1.Text = "剩余" + dat.ToString() + "秒";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            label4.Text = "鬧鐘已取消";
            label1.Text = "";
        }
    }
}