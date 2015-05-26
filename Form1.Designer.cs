namespace JobTimer
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
            this.btnStopMsg = new System.Windows.Forms.Button();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.Exits = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartMsg = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStopMsg
            // 
            this.btnStopMsg.Location = new System.Drawing.Point(152, 63);
            this.btnStopMsg.Name = "btnStopMsg";
            this.btnStopMsg.Size = new System.Drawing.Size(91, 23);
            this.btnStopMsg.TabIndex = 1;
            this.btnStopMsg.Text = "停止群发服务";
            this.btnStopMsg.UseVisualStyleBackColor = true;
            this.btnStopMsg.Click += new System.EventHandler(this.btnStopMsg_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(34, 152);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(88, 23);
            this.btnStartScan.TabIndex = 2;
            this.btnStartScan.Text = "开始扫描";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(152, 152);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(91, 23);
            this.btnStopScan.TabIndex = 3;
            this.btnStopScan.Text = "停止扫描";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
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
            // btnStartMsg
            // 
            this.btnStartMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartMsg.Location = new System.Drawing.Point(34, 63);
            this.btnStartMsg.Name = "btnStartMsg";
            this.btnStartMsg.Size = new System.Drawing.Size(88, 23);
            this.btnStartMsg.TabIndex = 0;
            this.btnStartMsg.Text = "开始群发服务";
            this.btnStartMsg.UseVisualStyleBackColor = true;
            this.btnStartMsg.Click += new System.EventHandler(this.btnStartMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnStopScan);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.btnStopMsg);
            this.Controls.Add(this.btnStartMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时服务";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopMsg;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowMainWindow;
        private System.Windows.Forms.ToolStripMenuItem Exits;
        private System.Windows.Forms.Button btnStartMsg;
    }
}

