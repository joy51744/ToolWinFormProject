using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolWinFormProject
{
    public partial class Media4 : Form
    {
        public string initialFileName = string.Empty;//传入的参数
        public int playState = 1;//播放状态
        public string defaultExeName = "mp4";//默认文件类型

        public Media4()
        {
            InitializeComponent();
        }

        public Media4(string fileName)
        {
            InitializeComponent();
            this.initialFileName = fileName;
        }

        private void ToolStripLabel3_Click(object sender, EventArgs e)
        {
        }

        private void addFileName(string fileName)
        {
            int index = fileName.LastIndexOf(@"\");
            string exeName = fileName.Substring(index + 1);
            //如果播放列表已经有这个文件,就选中列表里的项
            foreach (TreeNode t in this.tvList.Nodes[0].Nodes)
            {
                string name = t.Text;
                if (name.Contains(exeName))
                {
                    this.tvList.SelectedNode = t;
                    play();
                    return;
                }
            }
            TreeNode tn = AddTreeNode(fileName, exeName);
            this.tvList.Nodes[0].ExpandAll();
            this.tvList.SelectedNode = tn;
            play();
        }

        private void play()
        {
            TreeNode tn = this.tvList.SelectedNode;
            if (tn.Level == 1)
            {
                //文件不存在
                if (!File.Exists(tn.Tag.ToString()))
                {
                    MessageBox.Show("系統找不到文件,可能已經刪除或移動到期他位置!", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.axWindowsMediaPlayer1.URL != tn.Tag.ToString())
                {
                    this.axWindowsMediaPlayer1.URL = tn.Tag.ToString();
                }
            }
        }

        private TreeNode AddTreeNode(string fileName, string exeName)
        {
            int count = this.tvList.Nodes[0].Nodes.Count + 1;
            string showCount = count.ToString();
            if (count < 10)
            {
                showCount = "0" + count;
            }
            TreeNode tn = new TreeNode(showCount + " " + exeName);
            tn.Tag = fileName;
            tn.ToolTipText = exeName;
            this.tvList.Nodes[0].Nodes.Add(tn);
            return tn;
        }

        private void Media4_Load(object sender, EventArgs e)
        {
            InitialPlayList();
            GetDefaultExeName();
            GetState();
            if (this.initialFileName != string.Empty)
            {
                addFileName(this.initialFileName);
            }
        }

        private void GetState()
        {
            if (!File.Exists("config/State.popMusic"))
            {
                return;
            }
            FileStream fs = new FileStream("config/State.popMusic", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            this.playState = int.Parse(sr.ReadLine());
            sr.Close();
            fs.Close();
        }

        private void GetDefaultExeName()
        {
            if (!File.Exists("config/DefaultExeName.popMusic"))
            {
                return;
            }
            FileStream fs = new FileStream("config/DefaultExeName.popMusic", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            this.defaultExeName = sr.ReadLine().ToLower();
            sr.Close();
            fs.Close();
            if (this.defaultExeName == "mp3")
            {
                this.openFileDialog1.Filter = "音頻文件|*.mp3|視頻文件|*.mp4";
                this.openFileDialog1.DefaultExt = "mp3";
            }
            else
            {
                this.openFileDialog1.Filter = "視頻文件|*.mp4|音頻文件|*.mp3";
                this.openFileDialog1.DefaultExt = "mp4";
            }
        }

        private void InitialPlayList()
        {
            if (!File.Exists("config/PlayList.popMusic"))
            {
                return;
            }
            this.tvList.Nodes[0].Nodes.Clear();
            FileStream fs = new FileStream("config/PlayList.popMusic", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string fileName = sr.ReadLine();
            //从文本中读取
            while (fileName != null)
            {
                int index = fileName.LastIndexOf(@"\");
                string exeName = fileName.Substring(index + 1);
                AddTreeNode(fileName, exeName);
                fileName = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            this.tvList.Nodes[0].ExpandAll();
        }

        public bool isOne = false;//列表里是否只剩一首歌

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            isOne = false;
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                bool isPaly = true;//是否进行下次播放
                //顺序播放
                if (this.playState == 1)
                {
                    //如果当前不是最后一项
                    if (tvList.SelectedNode.Index != tvList.Nodes[0].Nodes.Count - 1)
                    {
                        this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index + 1];
                    }
                    else
                    {
                        isPaly = false;
                    }
                }
                //循环
                else if (this.playState == 2)
                {
                    //如果当前是最后一项
                    if (tvList.SelectedNode.Index == tvList.Nodes[0].Nodes.Count - 1)
                    {
                        this.tvList.SelectedNode = tvList.Nodes[0].Nodes[0];
                        int maxIndex = tvList.Nodes[0].Nodes.Count;
                        if (maxIndex <= 1)
                        {
                            isOne = true;
                        }
                    }
                    //不是最后一项
                    else
                    {
                        this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index + 1];
                    }
                }
                //随机
                else if (this.playState == 3)
                {
                    int maxIndex = tvList.Nodes[0].Nodes.Count;
                    if (maxIndex <= 1)
                    {
                        this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index];
                        isOne = true;
                    }
                    else
                    {
                        Random rd = new Random();
                        int index = rd.Next(0, maxIndex);
                        //随机数不能与当前index相等
                        while (index == tvList.SelectedNode.Index)
                        {
                            index = rd.Next(0, maxIndex);
                        }
                        this.tvList.SelectedNode = tvList.Nodes[0].Nodes[index];
                    }
                }
                //单曲
                else if (this.playState == 4)
                {
                    this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index];
                }
                if (isPaly)
                {
                    play();
                    //多线程
                    Thread thread = new Thread(new ThreadStart(PlayThread));
                    thread.Start();
                }
            }
        }

        private void PlayThread()
        {
            if (this.playState == 4 || this.isOne == false)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                //这里是判断播放器准备好没有
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsReady)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();//处于准备好状态就开始播放
                }
            }
        }

        public bool playNext()
        {
            if (this.tvList.Nodes[0].Nodes.Count <= 1)
            {
                return false;
            }
            if (this.tvList.SelectedNode == null || this.tvList.SelectedNode == this.tvList.Nodes[0])
            {
                this.tvList.SelectedNode = tvList.Nodes[0].Nodes[0];
            }
            bool isPaly = true;//是否进行下次播放
            //顺序播放
            if (this.playState == 1)
            {
                //如果当前不是最后一项
                if (tvList.SelectedNode.Index != tvList.Nodes[0].Nodes.Count - 1)
                {
                    this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index + 1];
                }
                else
                {
                    isPaly = false;
                }
            }
            //循环 ||单曲
            else if (this.playState == 2 || this.playState == 4)
            {
                //如果当前是最后一项
                if (tvList.SelectedNode.Index == tvList.Nodes[0].Nodes.Count - 1)
                {
                    this.tvList.SelectedNode = tvList.Nodes[0].Nodes[0];
                }
                //不是最后一项
                else
                {
                    this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index + 1];
                }
            }
            //随机
            else if (this.playState == 3)
            {
                int maxIndex = tvList.Nodes[0].Nodes.Count;
                Random rd = new Random();
                int index = rd.Next(0, maxIndex);
                //随机数不能与当前index相等
                while (index == tvList.SelectedNode.Index)
                {
                    index = rd.Next(0, maxIndex);
                }
                this.tvList.SelectedNode = tvList.Nodes[0].Nodes[index];
            }
            return isPaly;
        }

        public bool playPrev()
        {
            if (this.tvList.Nodes[0].Nodes.Count <= 1)
            {
                return false;
            }
            if (this.tvList.SelectedNode == null || this.tvList.SelectedNode == this.tvList.Nodes[0])
            {
                this.tvList.SelectedNode = tvList.Nodes[0].Nodes[0];
            }
            bool isPaly = true;//是否进行下次播放
            //顺序播放
            if (this.playState == 1)
            {
                //如果当前不是第一项
                if (tvList.SelectedNode.Index != 0)
                {
                    this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index - 1];
                }
                else
                {
                    isPaly = false;
                }
            }
            //循环||单曲
            else if (this.playState == 2 || this.playState == 4)
            {
                //如果当前是第一项
                if (tvList.SelectedNode.Index == 0)
                {
                    this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.Nodes[0].Nodes.Count - 1];
                }
                //不是第一项
                else
                {
                    this.tvList.SelectedNode = tvList.Nodes[0].Nodes[tvList.SelectedNode.Index - 1];
                }
            }
            //随机
            else if (this.playState == 3)
            {
                int maxIndex = tvList.Nodes[0].Nodes.Count;
                Random rd = new Random();
                int index = rd.Next(0, maxIndex);
                //随机数不能与当前index相等
                while (index == tvList.SelectedNode.Index)
                {
                    index = rd.Next(0, maxIndex);
                }
                this.tvList.SelectedNode = tvList.Nodes[0].Nodes[index];
            }
            return isPaly;
        }

        private void TvList_DoubleClick(object sender, EventArgs e)
        {
            play();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (playPrev())
            {
                play();
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (playNext())
            {
                play();
            }
        }

        private void Media4_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveList();
            SaveDefaultExeName();
            SaveState();
        }

        private void SaveState()
        {
            FileStream fs = new FileStream("config/State.popMusic", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(this.playState);
            sw.Close();
            fs.Close();
        }

        private void SaveDefaultExeName()
        {
            FileStream fs = new FileStream("config/DefaultExeName.popMusic", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(this.defaultExeName.ToLower());
            sw.Close();
            fs.Close();
        }

        private void SaveList()
        {
            FileStream fs = new FileStream("config/PlayList.popMusic", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach (TreeNode tn in this.tvList.Nodes[0].Nodes)
            {
                sw.WriteLine(tn.Tag.ToString());
            }
            sw.Close();
            fs.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = this.openFileDialog1.FileName;
            addFileName(fileName);
            int index = fileName.LastIndexOf(@".");
            string exeName = fileName.Substring(index + 1);
            this.defaultExeName = exeName.ToLower();
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            ToolMainForm main = new ToolMainForm();
            this.Visible = false;
            main.Show();
        }

        private void 順序播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.playState = 1;
        }

        private void 列表播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.playState = 2;
        }

        private void 隨機播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.playState = 3;
        }

        private void 單部播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.playState = 4;
        }

        private void 音樂播放器1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media media = new Media();
            this.Visible = false;
            media.Show();
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
    }
}