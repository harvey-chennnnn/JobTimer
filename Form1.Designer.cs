﻿namespace JobTimer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.Exits = new System.Windows.Forms.ToolStripMenuItem();
            this.sub1 = new System.Windows.Forms.CheckBox();
            this.sub2 = new System.Windows.Forms.CheckBox();
            this.sub3 = new System.Windows.Forms.CheckBox();
            this.sub4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labSub1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(35, 97);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(88, 23);
            this.btnStartScan.TabIndex = 2;
            this.btnStartScan.Text = "开始扫描";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(149, 97);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(91, 23);
            this.btnStopScan.TabIndex = 3;
            this.btnStopScan.Text = "停止扫描";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "时间设置:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "定时服务";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMainWindow,
            this.Exits});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 48);
            // 
            // ShowMainWindow
            // 
            this.ShowMainWindow.Name = "ShowMainWindow";
            this.ShowMainWindow.Size = new System.Drawing.Size(139, 22);
            this.ShowMainWindow.Text = "显示主界面";
            this.ShowMainWindow.Click += new System.EventHandler(this.ShowMainWindow_Click);
            // 
            // Exits
            // 
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(139, 22);
            this.Exits.Text = "退出";
            this.Exits.Click += new System.EventHandler(this.Exits_Click);
            // 
            // sub1
            // 
            this.sub1.AutoSize = true;
            this.sub1.Checked = true;
            this.sub1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sub1.Location = new System.Drawing.Point(35, 25);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(51, 17);
            this.sub1.TabIndex = 6;
            this.sub1.Text = "Sub1";
            this.sub1.UseVisualStyleBackColor = true;
            // 
            // sub2
            // 
            this.sub2.AutoSize = true;
            this.sub2.Checked = true;
            this.sub2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sub2.Location = new System.Drawing.Point(92, 25);
            this.sub2.Name = "sub2";
            this.sub2.Size = new System.Drawing.Size(51, 17);
            this.sub2.TabIndex = 6;
            this.sub2.Text = "Sub2";
            this.sub2.UseVisualStyleBackColor = true;
            // 
            // sub3
            // 
            this.sub3.AutoSize = true;
            this.sub3.Location = new System.Drawing.Point(149, 25);
            this.sub3.Name = "sub3";
            this.sub3.Size = new System.Drawing.Size(51, 17);
            this.sub3.TabIndex = 6;
            this.sub3.Text = "Sub3";
            this.sub3.UseVisualStyleBackColor = true;
            // 
            // sub4
            // 
            this.sub4.AutoSize = true;
            this.sub4.Location = new System.Drawing.Point(206, 25);
            this.sub4.Name = "sub4";
            this.sub4.Size = new System.Drawing.Size(51, 17);
            this.sub4.TabIndex = 6;
            this.sub4.Text = "Sub4";
            this.sub4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labSub1
            // 
            this.labSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labSub1.Location = new System.Drawing.Point(0, 0);
            this.labSub1.Name = "labSub1";
            this.labSub1.Size = new System.Drawing.Size(233, 59);
            this.labSub1.TabIndex = 7;
            this.labSub1.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labSub1);
            this.panel1.Location = new System.Drawing.Point(24, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 59);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sub4);
            this.Controls.Add(this.sub3);
            this.Controls.Add(this.sub2);
            this.Controls.Add(this.sub1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnStopScan);
            this.Controls.Add(this.btnStartScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时服务";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowMainWindow;
        private System.Windows.Forms.ToolStripMenuItem Exits;
        private System.Windows.Forms.CheckBox sub1;
        private System.Windows.Forms.CheckBox sub2;
        private System.Windows.Forms.CheckBox sub3;
        private System.Windows.Forms.CheckBox sub4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labSub1;
        private System.Windows.Forms.Panel panel1;
    }
}

