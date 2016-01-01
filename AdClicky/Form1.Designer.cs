﻿namespace AdClicky
{
    partial class Form1
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnActionBrowser = new System.Windows.Forms.Button();
            this.grpConfigs = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkConfigSimulateBrowser = new System.Windows.Forms.CheckBox();
            this.lblTotalCalls = new System.Windows.Forms.Label();
            this.txtLogger = new System.Windows.Forms.TextBox();
            this.lblLogger = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.grpConfigs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(53, 27);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(219, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proxy";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(478, 200);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(432, 399);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // btnActionBrowser
            // 
            this.btnActionBrowser.Location = new System.Drawing.Point(356, 154);
            this.btnActionBrowser.Name = "btnActionBrowser";
            this.btnActionBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnActionBrowser.TabIndex = 6;
            this.btnActionBrowser.Text = "Use browser";
            this.btnActionBrowser.UseVisualStyleBackColor = true;
            this.btnActionBrowser.Click += new System.EventHandler(this.btnActionBrowser_Click);
            // 
            // grpConfigs
            // 
            this.grpConfigs.Controls.Add(this.checkBox3);
            this.grpConfigs.Controls.Add(this.checkBox2);
            this.grpConfigs.Controls.Add(this.chkConfigSimulateBrowser);
            this.grpConfigs.Location = new System.Drawing.Point(548, 12);
            this.grpConfigs.Name = "grpConfigs";
            this.grpConfigs.Size = new System.Drawing.Size(310, 182);
            this.grpConfigs.TabIndex = 7;
            this.grpConfigs.TabStop = false;
            this.grpConfigs.Text = "Configurations";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(6, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(6, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkConfigSimulateBrowser
            // 
            this.chkConfigSimulateBrowser.AutoSize = true;
            this.chkConfigSimulateBrowser.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConfigSimulateBrowser.Checked = true;
            this.chkConfigSimulateBrowser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConfigSimulateBrowser.Location = new System.Drawing.Point(6, 19);
            this.chkConfigSimulateBrowser.Name = "chkConfigSimulateBrowser";
            this.chkConfigSimulateBrowser.Size = new System.Drawing.Size(112, 17);
            this.chkConfigSimulateBrowser.TabIndex = 0;
            this.chkConfigSimulateBrowser.Text = "Simulate Browsers";
            this.chkConfigSimulateBrowser.UseVisualStyleBackColor = true;
            // 
            // lblTotalCalls
            // 
            this.lblTotalCalls.AutoSize = true;
            this.lblTotalCalls.Location = new System.Drawing.Point(437, 159);
            this.lblTotalCalls.Name = "lblTotalCalls";
            this.lblTotalCalls.Size = new System.Drawing.Size(31, 13);
            this.lblTotalCalls.TabIndex = 8;
            this.lblTotalCalls.Tag = "Total: ";
            this.lblTotalCalls.Text = "Total";
            // 
            // txtLogger
            // 
            this.txtLogger.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLogger.Location = new System.Drawing.Point(12, 337);
            this.txtLogger.Multiline = true;
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogger.Size = new System.Drawing.Size(460, 262);
            this.txtLogger.TabIndex = 9;
            // 
            // lblLogger
            // 
            this.lblLogger.AutoSize = true;
            this.lblLogger.Location = new System.Drawing.Point(12, 321);
            this.lblLogger.Name = "lblLogger";
            this.lblLogger.Size = new System.Drawing.Size(171, 13);
            this.lblLogger.TabIndex = 11;
            this.lblLogger.Text = "What\'s happening under the hood:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Load file...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblLogger);
            this.Controls.Add(this.txtLogger);
            this.Controls.Add(this.lblTotalCalls);
            this.Controls.Add(this.grpConfigs);
            this.Controls.Add(this.btnActionBrowser);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpConfigs.ResumeLayout(false);
            this.grpConfigs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnActionBrowser;
        private System.Windows.Forms.GroupBox grpConfigs;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkConfigSimulateBrowser;
        private System.Windows.Forms.Label lblTotalCalls;
        private System.Windows.Forms.TextBox txtLogger;
        private System.Windows.Forms.Label lblLogger;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

