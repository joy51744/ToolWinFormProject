﻿namespace ToolWinFormProject
{
    partial class CHTConvertCHS
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
            this.btnCS = new System.Windows.Forms.Button();
            this.btnCT = new System.Windows.Forms.Button();
            this.txbConvertString = new System.Windows.Forms.TextBox();
            this.txbSourdeString = new System.Windows.Forms.TextBox();
            this.lblConvertString = new System.Windows.Forms.Label();
            this.lblSourceString = new System.Windows.Forms.Label();
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
            // btnCS
            // 
            this.btnCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(205)))), ((int)(((byte)(252)))));
            this.btnCS.Location = new System.Drawing.Point(384, 243);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(75, 39);
            this.btnCS.TabIndex = 11;
            this.btnCS.Text = "轉簡體";
            this.btnCS.UseVisualStyleBackColor = false;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // btnCT
            // 
            this.btnCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(205)))), ((int)(((byte)(252)))));
            this.btnCT.Location = new System.Drawing.Point(303, 243);
            this.btnCT.Name = "btnCT";
            this.btnCT.Size = new System.Drawing.Size(75, 39);
            this.btnCT.TabIndex = 10;
            this.btnCT.Text = "轉繁體";
            this.btnCT.UseVisualStyleBackColor = false;
            this.btnCT.Click += new System.EventHandler(this.btnCT_Click);
            // 
            // txbConvertString
            // 
            this.txbConvertString.Location = new System.Drawing.Point(83, 144);
            this.txbConvertString.Multiline = true;
            this.txbConvertString.Name = "txbConvertString";
            this.txbConvertString.Size = new System.Drawing.Size(376, 93);
            this.txbConvertString.TabIndex = 9;
            // 
            // txbSourdeString
            // 
            this.txbSourdeString.Location = new System.Drawing.Point(83, 31);
            this.txbSourdeString.Multiline = true;
            this.txbSourdeString.Name = "txbSourdeString";
            this.txbSourdeString.Size = new System.Drawing.Size(376, 93);
            this.txbSourdeString.TabIndex = 8;
            // 
            // lblConvertString
            // 
            this.lblConvertString.AutoSize = true;
            this.lblConvertString.Location = new System.Drawing.Point(12, 147);
            this.lblConvertString.Name = "lblConvertString";
            this.lblConvertString.Size = new System.Drawing.Size(65, 12);
            this.lblConvertString.TabIndex = 7;
            this.lblConvertString.Text = "轉換字串：";
            // 
            // lblSourceString
            // 
            this.lblSourceString.AutoSize = true;
            this.lblSourceString.Location = new System.Drawing.Point(12, 34);
            this.lblSourceString.Name = "lblSourceString";
            this.lblSourceString.Size = new System.Drawing.Size(65, 12);
            this.lblSourceString.TabIndex = 6;
            this.lblSourceString.Text = "原始字串：";
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
            this.toolStrip1.Size = new System.Drawing.Size(472, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click_1);
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
            this.toolStripSeparator7.Size = new System.Drawing.Size(155, 6);
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
            this.漢字拼音轉換toolStripMenuItem.Click += new System.EventHandler(this.漢字拼音轉換toolStripMenuItem_Click);
            // 
            // 簡體繁體轉換toolStripMenuItem
            // 
            this.簡體繁體轉換toolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.簡體繁體轉換toolStripMenuItem.Name = "簡體繁體轉換toolStripMenuItem";
            this.簡體繁體轉換toolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.簡體繁體轉換toolStripMenuItem.Text = "簡體繁體轉換";
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
            // CHTConvertCHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(472, 291);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.btnCT);
            this.Controls.Add(this.txbConvertString);
            this.Controls.Add(this.txbSourdeString);
            this.Controls.Add(this.lblConvertString);
            this.Controls.Add(this.lblSourceString);
            this.Name = "CHTConvertCHS";
            this.Text = "C#小工具專案 | 轉換器 | 簡體繁體轉換";
            this.Load += new System.EventHandler(this.CHTConvertCHS_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCS;
        private System.Windows.Forms.Button btnCT;
        private System.Windows.Forms.TextBox txbConvertString;
        private System.Windows.Forms.TextBox txbSourdeString;
        private System.Windows.Forms.Label lblConvertString;
        private System.Windows.Forms.Label lblSourceString;
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