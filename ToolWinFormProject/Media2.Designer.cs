namespace ToolWinFormProject
{
    partial class Media2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media2));
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonBrosewer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
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
            this.音樂播放器1ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.音樂播放器1ToolStripMenuItem.Text = "音樂播放器1";
            this.音樂播放器1ToolStripMenuItem.Click += new System.EventHandler(this.音樂播放器1ToolStripMenuItem_Click);
            // 
            // 音樂播放器2ToolStripMenuItem
            // 
            this.音樂播放器2ToolStripMenuItem.Name = "音樂播放器2ToolStripMenuItem";
            this.音樂播放器2ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.音樂播放器2ToolStripMenuItem.Text = "音樂播放器2";
            // 
            // 視頻播放器1ToolStripMenuItem
            // 
            this.視頻播放器1ToolStripMenuItem.Name = "視頻播放器1ToolStripMenuItem";
            this.視頻播放器1ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.視頻播放器1ToolStripMenuItem.Text = "視頻播放器1";
            this.視頻播放器1ToolStripMenuItem.Click += new System.EventHandler(this.視頻播放器1ToolStripMenuItem_Click);
            // 
            // 視頻播放器2ToolStripMenuItem
            // 
            this.視頻播放器2ToolStripMenuItem.Name = "視頻播放器2ToolStripMenuItem";
            this.視頻播放器2ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.視頻播放器2ToolStripMenuItem.Text = "視頻播放器2";
            this.視頻播放器2ToolStripMenuItem.Click += new System.EventHandler(this.視頻播放器2ToolStripMenuItem_Click);
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
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 25);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(534, 277);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // buttonBrosewer
            // 
            this.buttonBrosewer.Location = new System.Drawing.Point(459, 279);
            this.buttonBrosewer.Name = "buttonBrosewer";
            this.buttonBrosewer.Size = new System.Drawing.Size(75, 23);
            this.buttonBrosewer.TabIndex = 4;
            this.buttonBrosewer.Text = "Brosewer";
            this.buttonBrosewer.UseVisualStyleBackColor = true;
            this.buttonBrosewer.Click += new System.EventHandler(this.ButtonBrosewer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Media2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 302);
            this.Controls.Add(this.buttonBrosewer);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Media2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C#小工具專案 | 多媒體播放器";
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
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonBrosewer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}