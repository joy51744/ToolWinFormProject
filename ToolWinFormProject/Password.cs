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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            int minLength = 8;
            int maxLength = 12;

            string charAvailiable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            int passwordLength = random.Next(minLength, maxLength + 1);

            while (passwordLength-- > 0)
            {
                password.Append(charAvailiable[random.Next(charAvailiable.Length)]);
            }
            label1.Text = password.ToString();
        }
    }
}