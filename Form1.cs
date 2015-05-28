using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JobTimer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public delegate bool MethodCaller();
        Thread _sendMsgThread;
        Thread _getUserInfo;
        System.Media.SoundPlayer sPlay = new System.Media.SoundPlayer();
        private bool IsStop = false;

        private void btnStartScan_Click(object sender, EventArgs e) {
            _getUserInfo = new Thread(new ThreadStart(IsAvailable));
            _getUserInfo.IsBackground = true;
            _getUserInfo.Start();
            btnStartScan.Enabled = false;
            btnStopScan.Enabled = true;
        }

        private void btnStopScan_Click(object sender, EventArgs e) {
            IsStop = true;
            _getUserInfo.Abort();
            btnStartScan.Enabled = true;
            btnStopScan.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = @"HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;
            notifyIcon1.Visible = false;
            btnStopScan.Enabled = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Visible = true;
                WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void ShowMainWindow_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Visible = true;
                WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void Exits_Click(object sender, EventArgs e) {
            sPlay.Stop();
            notifyIcon1.Visible = false;
            Close();
            Dispose();
            System.Environment.Exit(0);
        }

        public void CheckData(int sub) {
            var result = "Network Error or No response";
            var response = GetResponse("http://117.36.53.122:9088/jsrwsyy/wsyy.do", "chbox=on&mac=74%3A2F%3A68%3AE4%3A71%3AF7&actiontype=gryyks&kskm=" + sub, "http://117.36.53.122:9088/jsrwsyy/wsyy.do?actiontype=gryy_gg&kskm=" + sub);
            if (!string.IsNullOrEmpty(response)) {
                if (!response.Contains("alert(\"抱歉，该科目各考场两天后的科目考试安排预约人数已满，不能进行预约！\");")) {
                    //sPlay.SoundLocation = System.AppDomain.CurrentDomain.BaseDirectory + "邓紫棋 - 喜欢你.wav";
                    //sPlay.Load();
                    //sPlay.Play();
                    notifyIcon1.ShowBalloonTip(3000, "",
                        "Examine Subject " + sub + " Is Available at:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        ToolTipIcon.Info);
                    var fs =
                        new FileStream(
                            System.AppDomain.CurrentDomain.BaseDirectory + "Logs\\Examine_Subject_" + sub + "_" +
                            DateTime.Now.Ticks + ".txt", FileMode.Create, FileAccess.Write);
                    var sw = new StreamWriter(fs);
                    sw.WriteLine("Examine Subject " + sub + " Is Available at:" +
                                 DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    var appointmentData = GetResponse("http://117.36.53.122:9088/jsrwsyy/wsyy.do?actiontype=init", "",
                        "");
                    sw.Write(appointmentData);
                    sw.Close();
                    result = "Available";
                }
                else {
                    result = "No Schedules";
                }
            }
            labSub1.Text = " Check Data Subject " + sub + " \n\r Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\r Result: " + result;
        }
        public void IsAvailable() {
            while (true) {
                if (sub1.Checked) {
                    CheckData(1);
                }
                if (sub2.Checked) {
                    CheckData(2);
                }
                if (sub3.Checked) {
                    CheckData(3);
                }
                if (sub4.Checked) {
                    CheckData(4);
                }
                Thread.Sleep(10000);
            }
        }

        private string GetResponse(string url, string postData, string refererUrl) {
            try {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                //webRequest.CookieContainer = this.cookieContainer; //登录时得到的缓存
                webRequest.Referer = refererUrl;
                webRequest.Method = "POST";
                webRequest.UserAgent = "Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/4.0.1";
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Timeout = 10000;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData); // 转化
                webRequest.ContentLength = byteArray.Length;
                Stream requestStream = webRequest.GetRequestStream();
                requestStream.Write(byteArray, 0, byteArray.Length);    //写入参数    
                requestStream.Close();

                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
                StreamReader reader = new StreamReader(webResponse.GetResponseStream(), Encoding.GetEncoding("GBK"));
                return reader.ReadToEnd();

            }
            catch (Exception) {
                return "";
            }
        }

        protected virtual void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
        }
    }
}
