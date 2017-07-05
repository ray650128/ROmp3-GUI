using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using System.Drawing;

namespace UpdateClient
{
    public partial class Form1 : Form
    {
        private Process curProcess = new Process();
        private Point mouse_offset;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //curProcess.CancelOutputRead();//取消異步操作
            //curProcess.Kill();

            UpdateUIBtn(false, btnStart);
            UpdateUIBtn(false, btnRunRO);
            ReadVersionTxt();

            if(PingUpdateServer("www.google.com.tw"/*"114.35.135.2"*/))
            {
                RunDataUpdateBatch();
                
                UpdateUIText("讀取更新清單中", txtUpdLnk);
            }
            else
            {
                MessageBox.Show(
                    "無法連接伺服器，\n請檢查網路是否正常", 
                    "沒有連線", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private delegate void UpdateUICallBackTxt(string value, Control ctl);

        private delegate void UpdateUICallBackBtn(Boolean value, Control ctl);

        private void UpdateUIText(string value, Control ctl)
        {
            if (this.InvokeRequired)
            {
                UpdateUICallBackTxt uu = new UpdateUICallBackTxt(UpdateUIText);
                this.Invoke(uu, value, ctl);
            }
            else
            {
                ctl.Text = value;
            }
        }

        private void UpdateUIBtn(Boolean value, Control ctl)
        {
            if (this.InvokeRequired)
            {
                UpdateUICallBackBtn uu = new UpdateUICallBackBtn(UpdateUIBtn);
                this.Invoke(uu, value, ctl);
            }
            else
            {
                ctl.Enabled = value;
            }
        }
        
        private void RunDataUpdateBatch()
        {
            if (File.Exists("data_update.bat"))
            {
                curProcess.OutputDataReceived -= new DataReceivedEventHandler(ProcessOutDataReceived);
                ProcessStartInfo p = new ProcessStartInfo();
                p.FileName = "data_update.bat";
                p.UseShellExecute = false;
                p.WindowStyle = ProcessWindowStyle.Hidden;
                p.CreateNoWindow = true;
                p.RedirectStandardError = true;
                p.RedirectStandardInput = true;
                p.RedirectStandardOutput = true;
                curProcess.StartInfo = p;
                curProcess.Start();

                curProcess.BeginOutputReadLine();
                curProcess.OutputDataReceived += new DataReceivedEventHandler(ProcessOutDataReceived);
            }
            else
            {
                MessageBox.Show(
                    "由於找不到 ROmp3 修正檔套件中的：\n" +
                    "data_update.bat 批次檔\n" +
                    "程式結束。",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Application.Exit();
            }
        }
        
        private void ReadVersionTxt()
        {
            if (File.Exists("Version.txt"))
            {
                StreamReader sr = new StreamReader("Version.txt", System.Text.Encoding.Default);

                textBox2.Clear();

                while (!sr.EndOfStream)
                {               // 每次讀取一行，直到檔尾
                                //string line = sr.ReadLine();            // 讀取文字到 line 變數
                    textBox2.AppendText(sr.ReadLine() + "\r\n");
                }
                sr.Close();                     // 關閉串流

                textBox2.SelectionStart = 0;
                textBox2.ScrollToCaret();
            }
        }

        private Boolean PingUpdateServer(string ipaddress)
        {
            Ping a = new Ping();
            PingReply re = a.Send(ipaddress);//得到PING傳回值

            if (re.Status == IPStatus.Success) //如果ping成功
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 進程接受事件
        public void ProcessOutDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (this.textBox1.InvokeRequired)
            {
                this.textBox1.Invoke(new Action(() =>
                {
                    this.textBox1.AppendText(e.Data + "\r\n");

                    RunTextView(e.Data);
                }));
            }
            else
            {
                this.textBox1.AppendText(e.Data + "\r\n");
            }
        }

        public void RunTextView(string text)
        {
            if (text != null)
            {
                if (text.Contains("Getting update information"))
                {
                    UpdateUIText("正在取得更新資訊．．．", txtUpdLnk);
                    progBar.Value = 10;
                }
                else if (text.Contains("UNRAR"))
                {
                    UpdateUIText("更新檔解壓中．．．", txtUpdLnk);
                    progBar.Value = 20;
                }
                else if (text.Contains("解壓縮"))
                {
                    if (progBar.Value < 80)
                    {
                        progBar.Value = 50;
                    }
                }
                else if (text.Contains("全部確認"))
                {
                    progBar.Value = 80;
                }
                else if (text.Contains("移動"))
                {
                    progBar.Value = 90;
                }
                else if (text.Contains("Data update successful"))
                {
                    UpdateUIText("資料更新完畢。", txtUpdLnk);
                    progBar.Value = 100;
                    UpdateUIBtn(true, btnStart);
                    UpdateUIBtn(true, btnRunRO);
                    ReadVersionTxt();
                }
                else if (text.Contains("You already have the latest version"))
                {
                    UpdateUIText("你已經是最新版本了。", txtUpdLnk);
                    progBar.Value = 100;
                    UpdateUIBtn(true, btnStart);
                    UpdateUIBtn(true, btnRunRO);
                }
            }
        }
        
        private void RunExternalEXE(string exename, string argument)
        {
            ProcessStartInfo RunEXE = new ProcessStartInfo();
            // FileName 是要執行的檔案
            RunEXE.FileName = exename;
            RunEXE.Arguments = argument;
            RunEXE.WorkingDirectory = Application.StartupPath + @"\..\";//檔案所在的目錄

            try
            {
                Process.Start(RunEXE);
                Application.Exit();
            }
            catch (Exception error)
            {
                //Console.WriteLine(err.ToString());
                MessageBox.Show(
                    "找不到 " + exename + " \n 於：\n" + Application.StartupPath + @"\..\",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RunExternalEXE("Ragexe.exe", "1free1 /account:clientinfo1.xml");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            RunExternalEXE("Setup.exe", "");
        }

        private void btnRunRO_Click(object sender, EventArgs e)
        {
            RunExternalEXE("Ragnarok.exe", "");
        }

        private void linkPokepe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
              System.Diagnostics.Process.Start("http://pokepe.myweb.hinet.net/");
            }
            catch {}
        }

        private void linkBahamut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://forum.gamer.com.tw/B.php?bsn=04212");
            }
            catch { }
        }

        private void linkGNJOY_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://ro.gnjoy.com.tw/");
            }
            catch { }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
            this.Opacity = 0.50;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseBtn_MouseMove(object sender, MouseEventArgs e)
        {
            closeBtn.BackgroundImage = Properties.Resources.sys_close_on;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackgroundImage = Properties.Resources.sys_close_off;
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)(sender)).BackgroundImage = Properties.Resources.btn_null_on;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)(sender)).BackgroundImage = Properties.Resources.btn_null_off;
        }

        private void Button_EnabledChanged(object sender, EventArgs e)
        {
            if(((Button)(sender)).Enabled)
            {
                ((Button)(sender)).BackgroundImage = Properties.Resources.btn_null_off;
            }
            else
            {
                ((Button)(sender)).BackgroundImage = Properties.Resources.btn_null_dis;
            }
        }

        private void HyperLink_MouseMove(object sender, MouseEventArgs e)
        {
            ((LinkLabel)(sender)).LinkColor = Color.Aqua;
        }

        private void HyperLink_MouseLeave(object sender, EventArgs e)
        {
            ((LinkLabel)(sender)).LinkColor = Color.Green;
        }
    }
}
