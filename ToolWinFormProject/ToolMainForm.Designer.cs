namespace ToolWinFormProject
{
    partial class ToolMainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonNote = new System.Windows.Forms.Button();
            this.buttonMedia = new System.Windows.Forms.Button();
            this.buttonScreenShot = new System.Windows.Forms.Button();
            this.buttonBarCode = new System.Windows.Forms.Button();
            this.buttonIDVerification = new System.Windows.Forms.Button();
            this.buttonID = new System.Windows.Forms.Button();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.buttonRemind = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
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
            // buttonNote
            // 
            this.buttonNote.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNote.Location = new System.Drawing.Point(645, 374);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(130, 45);
            this.buttonNote.TabIndex = 102;
            this.buttonNote.Text = "桌面便條";
            this.buttonNote.UseVisualStyleBackColor = true;
            this.buttonNote.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonMedia
            // 
            this.buttonMedia.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMedia.Location = new System.Drawing.Point(645, 231);
            this.buttonMedia.Name = "buttonMedia";
            this.buttonMedia.Size = new System.Drawing.Size(130, 45);
            this.buttonMedia.TabIndex = 101;
            this.buttonMedia.Text = "多媒體播放器";
            this.buttonMedia.UseVisualStyleBackColor = true;
            this.buttonMedia.Click += new System.EventHandler(this.buttonMedia_Click);
            // 
            // buttonScreenShot
            // 
            this.buttonScreenShot.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonScreenShot.Location = new System.Drawing.Point(645, 89);
            this.buttonScreenShot.Name = "buttonScreenShot";
            this.buttonScreenShot.Size = new System.Drawing.Size(130, 45);
            this.buttonScreenShot.TabIndex = 100;
            this.buttonScreenShot.Text = "截圖";
            this.buttonScreenShot.UseVisualStyleBackColor = true;
            this.buttonScreenShot.Click += new System.EventHandler(this.buttonScreenShot_Click);
            // 
            // buttonBarCode
            // 
            this.buttonBarCode.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonBarCode.Location = new System.Drawing.Point(334, 374);
            this.buttonBarCode.Name = "buttonBarCode";
            this.buttonBarCode.Size = new System.Drawing.Size(130, 45);
            this.buttonBarCode.TabIndex = 99;
            this.buttonBarCode.Text = "條碼產生器";
            this.buttonBarCode.UseVisualStyleBackColor = true;
            this.buttonBarCode.Click += new System.EventHandler(this.buttonBarCode_Click);
            // 
            // buttonIDVerification
            // 
            this.buttonIDVerification.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonIDVerification.Location = new System.Drawing.Point(334, 231);
            this.buttonIDVerification.Name = "buttonIDVerification";
            this.buttonIDVerification.Size = new System.Drawing.Size(130, 45);
            this.buttonIDVerification.TabIndex = 98;
            this.buttonIDVerification.Text = "身分證認證";
            this.buttonIDVerification.UseVisualStyleBackColor = true;
            this.buttonIDVerification.Click += new System.EventHandler(this.buttonIDVerification_Click);
            // 
            // buttonID
            // 
            this.buttonID.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonID.Location = new System.Drawing.Point(334, 89);
            this.buttonID.Name = "buttonID";
            this.buttonID.Size = new System.Drawing.Size(130, 45);
            this.buttonID.TabIndex = 97;
            this.buttonID.Text = "身分證產生器";
            this.buttonID.UseVisualStyleBackColor = true;
            this.buttonID.Click += new System.EventHandler(this.buttonID_Click);
            // 
            // buttonPassword
            // 
            this.buttonPassword.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPassword.Location = new System.Drawing.Point(25, 373);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(130, 45);
            this.buttonPassword.TabIndex = 96;
            this.buttonPassword.Text = "密碼產生器";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // buttonRemind
            // 
            this.buttonRemind.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRemind.Location = new System.Drawing.Point(25, 231);
            this.buttonRemind.Name = "buttonRemind";
            this.buttonRemind.Size = new System.Drawing.Size(130, 45);
            this.buttonRemind.TabIndex = 95;
            this.buttonRemind.Text = "提醒小工具";
            this.buttonRemind.UseVisualStyleBackColor = true;
            this.buttonRemind.Click += new System.EventHandler(this.buttonRemind_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTimer.Location = new System.Drawing.Point(25, 89);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(130, 45);
            this.buttonTimer.TabIndex = 94;
            this.buttonTimer.Text = "定時器";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.label1.Location = new System.Drawing.Point(292, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 34);
            this.label1.TabIndex = 93;
            this.label1.Text = "C# Tool Project";
            // 
            // ToolMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNote);
            this.Controls.Add(this.buttonMedia);
            this.Controls.Add(this.buttonScreenShot);
            this.Controls.Add(this.buttonBarCode);
            this.Controls.Add(this.buttonIDVerification);
            this.Controls.Add(this.buttonID);
            this.Controls.Add(this.buttonPassword);
            this.Controls.Add(this.buttonRemind);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToolMainForm";
            this.Text = "馬顥心 | C#小工具專案";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonNote;
        private System.Windows.Forms.Button buttonMedia;
        private System.Windows.Forms.Button buttonScreenShot;
        private System.Windows.Forms.Button buttonBarCode;
        private System.Windows.Forms.Button buttonIDVerification;
        private System.Windows.Forms.Button buttonID;
        private System.Windows.Forms.Button buttonPassword;
        private System.Windows.Forms.Button buttonRemind;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Label label1;
    }
}

