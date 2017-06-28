using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace UpdateClient
{
    public partial class Form1 : Form
    {
        private Process curProcess = new Process();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //curProcess.CancelOutputRead();//取消異步操作
            //curProcess.Kill();
            //如果需要手動關閉，則關閉后再進行初始化
            UpdateUIBtn(false, btnStart);
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
                    progBar.Value += 10;
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
                    ReadVersionTxt();
                }
                else if (text.Contains("You already have the latest version"))
                {
                    UpdateUIText("你已經是最新版本了。", txtUpdLnk);
                    progBar.Value = 100;
                    UpdateUIBtn(true, btnStart);
                }
                else if (text.Contains("全部確認"))
                {
                    progBar.Value = 80;
                }
            }
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Ragexe.exe "1free1 /account:clientinfo1.xml"
            ProcessStartInfo Ragexe = new ProcessStartInfo();
            // FileName 是要執行的檔案
            Ragexe.FileName = "Ragexe.exe";
            Ragexe.Arguments = "1free1 /account:clientinfo1.xml";
            Ragexe.WorkingDirectory = Application.StartupPath + @"\..\";//檔案所在的目錄

            try
            {
                Process.Start(Ragexe);
                Application.Exit();
            }
            catch(Exception error)
            {
                //Console.WriteLine(err.ToString());
                MessageBox.Show(
                    "找不到 Ragexe.exe \n 於：\n" + Application.StartupPath + @"\..\", 
                    "錯誤", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            // Ragexe.exe "1free1 /account:clientinfo1.xml"
            ProcessStartInfo Ragexe = new ProcessStartInfo();
            // FileName 是要執行的檔案
            Ragexe.FileName = "Setup.exe";
            Ragexe.WorkingDirectory = Application.StartupPath + @"\..\";//檔案所在的目錄

            try
            {
                Process.Start(Ragexe);
                Application.Exit();
            }
            catch (Exception error)
            {
                //Console.WriteLine(err.ToString());
                MessageBox.Show(
                    "找不到 Setup.exe \n 於：\n" + Application.StartupPath + @"\..\", 
                    "錯誤", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
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

        private void btnRunRO_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Ragnarok = new ProcessStartInfo();
            // FileName 是要執行的檔案
            Ragnarok.FileName = "Ragnarok.exe";
            Ragnarok.WorkingDirectory = Application.StartupPath + @"\..\";//檔案所在的目錄

            try
            {
                Process.Start(Ragnarok);
                Application.Exit();
            }
            catch (Exception error)
            {
                //Console.WriteLine(err.ToString());
                MessageBox.Show(
                    "找不到 Ragnarok.exe \n 於：\n" + Application.StartupPath + @"\..\",
                    "錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
