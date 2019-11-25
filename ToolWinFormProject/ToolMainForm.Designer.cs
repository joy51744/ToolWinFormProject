namespace ToolWinFormProject
{
    partial class ToolMainForm
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
            this.buttonWatermark = new System.Windows.Forms.Button();
            this.buttonMedia = new System.Windows.Forms.Button();
            this.buttonNote = new System.Windows.Forms.Button();
            this.buttonID = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonBarCode = new System.Windows.Forms.Button();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.buttonRemind = new System.Windows.Forms.Button();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonScreenShot = new System.Windows.Forms.Button();
            this.buttonImageUpload = new System.Windows.Forms.Button();
            this.buttonIDCheck = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonWatermark
            // 
            this.buttonWatermark.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonWatermark.Location = new System.Drawing.Point(437, 89);
            this.buttonWatermark.Name = "buttonWatermark";
            this.buttonWatermark.Size = new System.Drawing.Size(130, 45);
            this.buttonWatermark.TabIndex = 7;
            this.buttonWatermark.Text = "浮水印";
            this.buttonWatermark.UseVisualStyleBackColor = true;
            this.buttonWatermark.Click += new System.EventHandler(this.buttonWatermark_Click);
            // 
            // buttonMedia
            // 
            this.buttonMedia.Font = new System.Drawing.Font("標楷體", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonMedia.Location = new System.Drawing.Point(643, 90);
            this.buttonMedia.Name = "buttonMedia";
            this.buttonMedia.Size = new System.Drawing.Size(130, 45);
            this.buttonMedia.TabIndex = 10;
            this.buttonMedia.Text = "多媒體播放器";
            this.buttonMedia.UseVisualStyleBackColor = true;
            this.buttonMedia.Click += new System.EventHandler(this.buttonMedia_Click);
            // 
            // buttonNote
            // 
            this.buttonNote.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNote.Location = new System.Drawing.Point(643, 230);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(130, 45);
            this.buttonNote.TabIndex = 11;
            this.buttonNote.Text = "桌面便條";
            this.buttonNote.UseVisualStyleBackColor = true;
            this.buttonNote.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonID
            // 
            this.buttonID.Font = new System.Drawing.Font("標楷體", 12.25F, System.Drawing.FontStyle.Bold);
            this.buttonID.Location = new System.Drawing.Point(231, 230);
            this.buttonID.Name = "buttonID";
            this.buttonID.Size = new System.Drawing.Size(130, 45);
            this.buttonID.TabIndex = 5;
            this.buttonID.Text = "身分證產生器";
            this.buttonID.UseVisualStyleBackColor = true;
            this.buttonID.Click += new System.EventHandler(this.buttonID_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonBarCode
            // 
            this.buttonBarCode.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonBarCode.Location = new System.Drawing.Point(231, 90);
            this.buttonBarCode.Name = "buttonBarCode";
            this.buttonBarCode.Size = new System.Drawing.Size(130, 45);
            this.buttonBarCode.TabIndex = 4;
            this.buttonBarCode.Text = "條碼產生器";
            this.buttonBarCode.UseVisualStyleBackColor = true;
            this.buttonBarCode.Click += new System.EventHandler(this.buttonBarCode_Click);
            // 
            // buttonPassword
            // 
            this.buttonPassword.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPassword.Location = new System.Drawing.Point(25, 370);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(130, 45);
            this.buttonPassword.TabIndex = 3;
            this.buttonPassword.Text = "密碼產生器";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // buttonRemind
            // 
            this.buttonRemind.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRemind.Location = new System.Drawing.Point(25, 230);
            this.buttonRemind.Name = "buttonRemind";
            this.buttonRemind.Size = new System.Drawing.Size(130, 45);
            this.buttonRemind.TabIndex = 2;
            this.buttonRemind.Text = "定時提醒";
            this.buttonRemind.UseVisualStyleBackColor = true;
            this.buttonRemind.Click += new System.EventHandler(this.buttonRemind_Click);
            // 
            // buttonConverter
            // 
            this.buttonConverter.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConverter.Location = new System.Drawing.Point(25, 90);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(130, 45);
            this.buttonConverter.TabIndex = 1;
            this.buttonConverter.Text = "轉換器";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
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
            this.toolStrip1.TabIndex = 106;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.Location = new System.Drawing.Point(291, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 107;
            this.label1.Text = "C# Tool Project";
            // 
            // buttonScreenShot
            // 
            this.buttonScreenShot.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonScreenShot.Location = new System.Drawing.Point(437, 230);
            this.buttonScreenShot.Name = "buttonScreenShot";
            this.buttonScreenShot.Size = new System.Drawing.Size(130, 45);
            this.buttonScreenShot.TabIndex = 8;
            this.buttonScreenShot.Text = "螢幕截圖";
            this.buttonScreenShot.UseVisualStyleBackColor = true;
            this.buttonScreenShot.Click += new System.EventHandler(this.buttonScreenShot_Click);
            // 
            // buttonImageUpload
            // 
            this.buttonImageUpload.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonImageUpload.Location = new System.Drawing.Point(437, 370);
            this.buttonImageUpload.Name = "buttonImageUpload";
            this.buttonImageUpload.Size = new System.Drawing.Size(130, 45);
            this.buttonImageUpload.TabIndex = 9;
            this.buttonImageUpload.Text = "圖片上傳";
            this.buttonImageUpload.UseVisualStyleBackColor = true;
            this.buttonImageUpload.Click += new System.EventHandler(this.buttonImageUpload_Click);
            // 
            // buttonIDCheck
            // 
            this.buttonIDCheck.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonIDCheck.Location = new System.Drawing.Point(231, 370);
            this.buttonIDCheck.Name = "buttonIDCheck";
            this.buttonIDCheck.Size = new System.Drawing.Size(130, 45);
            this.buttonIDCheck.TabIndex = 6;
            this.buttonIDCheck.Text = "身分證驗證";
            this.buttonIDCheck.UseVisualStyleBackColor = true;
            this.buttonIDCheck.Click += new System.EventHandler(this.buttonIDCheck_Click);
            // 
            // ToolMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIDCheck);
            this.Controls.Add(this.buttonImageUpload);
            this.Controls.Add(this.buttonScreenShot);
            this.Controls.Add(this.buttonWatermark);
            this.Controls.Add(this.buttonMedia);
            this.Controls.Add(this.buttonNote);
            this.Controls.Add(this.buttonID);
            this.Controls.Add(this.buttonBarCode);
            this.Controls.Add(this.buttonPassword);
            this.Controls.Add(this.buttonRemind);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "ToolMainForm";
            this.Text = "馬顥心 | C#小工具專案";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWatermark;
        private System.Windows.Forms.Button buttonMedia;
        private System.Windows.Forms.Button buttonNote;
        private System.Windows.Forms.Button buttonID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonBarCode;
        private System.Windows.Forms.Button buttonPassword;
        private System.Windows.Forms.Button buttonRemind;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonScreenShot;
        private System.Windows.Forms.Button buttonImageUpload;
        private System.Windows.Forms.Button buttonIDCheck;
    }
}