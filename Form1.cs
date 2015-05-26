﻿using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JobTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate bool MethodCaller();
        Thread _sendMsgThread;
        Thread _getUserInfo;

        private void btnStartMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnStopMsg_Click(object sender, EventArgs e)
        {
            _sendMsgThread.Abort();
            btnStopMsg.Enabled = false;
            btnStartMsg.Enabled = true;
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            _getUserInfo = new Thread(new ThreadStart(IsAvailable));
            _getUserInfo.Start();
            btnStartScan.Enabled = false;
            btnStopScan.Enabled = true;
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            _getUserInfo.Abort();
            btnStartScan.Enabled = true;
            btnStopScan.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = @"HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;
            notifyIcon1.Visible = false;
            btnStopMsg.Enabled = false;
            btnStopScan.Enabled = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void ShowMainWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
            }
        }

        private void Exits_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Close();
            Dispose();
            Application.Exit();
        }

        public void IsAvailable()
        {
            while (true)
            {
                var response = GetResponse("http://117.36.53.122:9088/jsrwsyy/wsyy.do", "http://117.36.53.122:9088/jsrwsyy/wsyy.do?actiontype=gryy_gg&kskm=1");
                if (!string.IsNullOrEmpty(response) && !response.Contains("alert(\"抱歉，该科目各考场两天后的科目考试安排预约人数已满，不能进行预约！\");"))
                {
                    MessageBox.Show("Appointment Is Available!");
                    _getUserInfo.Abort();
                    btnStartScan.Enabled = true;
                    btnStopScan.Enabled = false;
                }
                Thread.Sleep(10000);
            }
        }

        private string GetResponse(string url, string refererUrl)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            //webRequest.CookieContainer = this.cookieContainer; //登录时得到的缓存
            webRequest.Referer = refererUrl;
            webRequest.Method = "POST";
            webRequest.UserAgent = "Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/4.0.1";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            string postData = "chbox=on&mac=74%3A2F%3A68%3AE4%3A71%3AF7&actiontype=gryyks&kskm=1";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData); // 转化
            webRequest.ContentLength = byteArray.Length;
            Stream requestStream = webRequest.GetRequestStream();
            requestStream.Write(byteArray, 0, byteArray.Length);    //写入参数    
            requestStream.Close();

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream(), Encoding.GetEncoding("GBK"));
            return reader.ReadToEnd();
        }

    }
}