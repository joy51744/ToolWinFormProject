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
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddMusicToListBox(listBox1);
        }

        private void AddMusicToListBox(ListBox listBox)
        {
            string[] files = GetMusicFiles();
            if (files != null && files.Length > 0)
            {
                foreach (string file in files)
                {
                    if (!listBox.Items.Contains(file))
                    {
                        listBox.Items.Add(file);
                    }
                }
            }
        }

        private string[] GetMusicFiles()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;//设置 选择多个文件
            ofd.InitialDirectory = @"D:\Music";
            ofd.Filter = "(MP3文件)|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileNames;
            }
            else
            {
                return null;
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.currentPlaylist.clear();
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            WMPLib.IWMPMedia song = axWindowsMediaPlayer1.newMedia(listBox1.SelectedItem.ToString());
            axWindowsMediaPlayer1.currentPlaylist.appendItem(song);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            RemoveMusicFromListBox(listBox1);
        }

        private void RemoveMusicFromListBox(ListBox listBox)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            label1.Text = "重複播放已開啟";
        }

        private void 音樂播放器2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media2 media = new Media2();
            this.Visible = false;
            media.Show();
        }

        private void 視頻播放器1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media3 media = new Media3();
            this.Visible = false;
            media.Show();
        }

        private void 視頻播放器2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media4 media = new Media4();
            this.Visible = false;
            media.Show();
        }
    }
}