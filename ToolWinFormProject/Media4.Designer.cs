namespace ToolWinFormProject
{
    partial class Media4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("播放列表");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.音樂播放器1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音樂播放器2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視頻播放器1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視頻播放器2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.順序播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隨機播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.單部播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tvList = new System.Windows.Forms.TreeView();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.toolStripSeparator5,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.音樂播放器1ToolStripMenuItem,
            this.音樂播放器2ToolStripMenuItem,
            this.視頻播放器1ToolStripMenuItem,
            this.視頻播放器2ToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "專案";
            // 
            // 音樂播放器1ToolStripMenuItem
            // 
            this.音樂播放器1ToolStripMenuItem.Name = "音樂播放器1ToolStripMenuItem";
            this.音樂播放器1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.音樂播放器1ToolStripMenuItem.Text = "音樂播放器1";
            this.音樂播放器1ToolStripMenuItem.Click += new System.EventHandler(this.音樂播放器1ToolStripMenuItem_Click);
            // 
            // 音樂播放器2ToolStripMenuItem
            // 
            this.音樂播放器2ToolStripMenuItem.Name = "音樂播放器2ToolStripMenuItem";
            this.音樂播放器2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.音樂播放器2ToolStripMenuItem.Text = "音樂播放器2";
            this.音樂播放器2ToolStripMenuItem.Click += new System.EventHandler(this.音樂播放器2ToolStripMenuItem_Click);
            // 
            // 視頻播放器1ToolStripMenuItem
            // 
            this.視頻播放器1ToolStripMenuItem.Name = "視頻播放器1ToolStripMenuItem";
            this.視頻播放器1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.視頻播放器1ToolStripMenuItem.Text = "視頻播放器1";
            this.視頻播放器1ToolStripMenuItem.Click += new System.EventHandler(this.視頻播放器1ToolStripMenuItem_Click);
            // 
            // 視頻播放器2ToolStripMenuItem
            // 
            this.視頻播放器2ToolStripMenuItem.Name = "視頻播放器2ToolStripMenuItem";
            this.視頻播放器2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.視頻播放器2ToolStripMenuItem.Text = "視頻播放器2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "離開";
            this.toolStripLabel2.Click += new System.EventHandler(this.ToolStripLabel2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.順序播放ToolStripMenuItem,
            this.列表播放ToolStripMenuItem,
            this.隨機播放ToolStripMenuItem,
            this.單部播放ToolStripMenuItem});
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel3.Text = "播放設置";
            // 
            // 順序播放ToolStripMenuItem
            // 
            this.順序播放ToolStripMenuItem.Name = "順序播放ToolStripMenuItem";
            this.順序播放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.順序播放ToolStripMenuItem.Text = "順序播放";
            this.順序播放ToolStripMenuItem.Click += new System.EventHandler(this.順序播放ToolStripMenuItem_Click);
            // 
            // 列表播放ToolStripMenuItem
            // 
            this.列表播放ToolStripMenuItem.Name = "列表播放ToolStripMenuItem";
            this.列表播放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.列表播放ToolStripMenuItem.Text = "列表播放";
            this.列表播放ToolStripMenuItem.Click += new System.EventHandler(this.列表播放ToolStripMenuItem_Click);
            // 
            // 隨機播放ToolStripMenuItem
            // 
            this.隨機播放ToolStripMenuItem.Name = "隨機播放ToolStripMenuItem";
            this.隨機播放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隨機播放ToolStripMenuItem.Text = "隨機播放";
            this.隨機播放ToolStripMenuItem.Click += new System.EventHandler(this.隨機播放ToolStripMenuItem_Click);
            // 
            // 單部播放ToolStripMenuItem
            // 
            this.單部播放ToolStripMenuItem.Name = "單部播放ToolStripMenuItem";
            this.單部播放ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.單部播放ToolStripMenuItem.Text = "單部播放";
            this.單部播放ToolStripMenuItem.Click += new System.EventHandler(this.單部播放ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tvList
            // 
            this.tvList.BackColor = System.Drawing.Color.Lavender;
            this.tvList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tvList.Location = new System.Drawing.Point(3, 68);
            this.tvList.Name = "tvList";
            treeNode3.Name = "节点0";
            treeNode3.Text = "播放列表";
            this.tvList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvList.ShowNodeToolTips = true;
            this.tvList.Size = new System.Drawing.Size(196, 494);
            this.tvList.TabIndex = 14;
            this.tvList.DoubleClick += new System.EventHandler(this.TvList_DoubleClick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(202, 68);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(582, 494);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.AxWindowsMediaPlayer1_PlayStateChange);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(580, 39);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 16;
            this.buttonPrev.Text = "上一部";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(697, 39);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "下一部";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "打開文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Media4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.tvList);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Media4";
            this.Text = "C#小工具專案 | 多媒體播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Media4_FormClosing);
            this.Load += new System.EventHandler(this.Media4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 音樂播放器1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 音樂播放器2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視頻播放器1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視頻播放器2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TreeView tvList;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem 順序播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隨機播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 單部播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}