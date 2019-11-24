namespace ToolWinFormProject
{
    partial class CHTConvertPinYin
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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.圖片格式轉換toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圖片格式轉換ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.金額大小寫轉換toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.漢字拼音轉換toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.簡體繁體轉換toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(220, 162);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(152, 22);
            this.textBoxOutput.TabIndex = 13;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(220, 77);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(152, 22);
            this.textBoxInput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(95, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "轉換的拼音:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "需要轉換的漢字:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(199, 218);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 14;
            this.buttonConvert.Text = "轉換";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 15;
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.圖片格式轉換toolStripMenuItem,
            this.toolStripSeparator7,
            this.金額大小寫轉換toolStripMenuItem,
            this.漢字拼音轉換toolStripMenuItem,
            this.簡體繁體轉換toolStripMenuItem});
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "專案";
            // 
            // 圖片格式轉換toolStripMenuItem
            // 
            this.圖片格式轉換toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.圖片格式轉換ToolStripMenuItem1});
            this.圖片格式轉換toolStripMenuItem.Name = "圖片格式轉換toolStripMenuItem";
            this.圖片格式轉換toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.圖片格式轉換toolStripMenuItem.Text = "格式轉換";
            // 
            // 圖片格式轉換ToolStripMenuItem1
            // 
            this.圖片格式轉換ToolStripMenuItem1.Name = "圖片格式轉換ToolStripMenuItem1";
            this.圖片格式轉換ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.圖片格式轉換ToolStripMenuItem1.Text = "圖片格式轉換";
            this.圖片格式轉換ToolStripMenuItem1.Click += new System.EventHandler(this.圖片格式轉換toolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // 金額大小寫轉換toolStripMenuItem
            // 
            this.金額大小寫轉換toolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.金額大小寫轉換toolStripMenuItem.Name = "金額大小寫轉換toolStripMenuItem";
            this.金額大小寫轉換toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.金額大小寫轉換toolStripMenuItem.Text = "金額大小寫轉換";
            this.金額大小寫轉換toolStripMenuItem.Click += new System.EventHandler(this.金額大小寫轉換toolStripMenuItem_Click);
            // 
            // 漢字拼音轉換toolStripMenuItem
            // 
            this.漢字拼音轉換toolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.漢字拼音轉換toolStripMenuItem.Name = "漢字拼音轉換toolStripMenuItem";
            this.漢字拼音轉換toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.漢字拼音轉換toolStripMenuItem.Text = "漢字拼音轉換";
            // 
            // 簡體繁體轉換toolStripMenuItem
            // 
            this.簡體繁體轉換toolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.簡體繁體轉換toolStripMenuItem.Name = "簡體繁體轉換toolStripMenuItem";
            this.簡體繁體轉換toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.簡體繁體轉換toolStripMenuItem.Text = "簡體繁體轉換";
            this.簡體繁體轉換toolStripMenuItem.Click += new System.EventHandler(this.簡體繁體轉換toolStripMenuItem_Click);
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
            // CHTConvertPinYin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CHTConvertPinYin";
            this.Text = "C#小工具專案 | 漢字拼音轉換";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem 圖片格式轉換toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圖片格式轉換ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 金額大小寫轉換toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 漢字拼音轉換toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 簡體繁體轉換toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}