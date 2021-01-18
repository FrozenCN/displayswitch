using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn_Local_Click(object sender, EventArgs e)
        {
            ExecCmd("displayswitch.exe /internal");

        }
        private void Btn_clone_Click(object sender, EventArgs e)
        {
            ExecCmd("displayswitch.exe /clone");
        }

        private void Btn_extend_Click(object sender, EventArgs e)
        {
            ExecCmd("displayswitch.exe /extend");
        }
        private void Btn_external_Click(object sender, EventArgs e)
        {
            ExecCmd("displayswitch.exe /external");
           // ExecCmd(@"C:\Windows\System32\displayswitch.exe /external");
        }

        /// <summary>
        /// 执行Cmd命令
        /// </summary>
        public void ExecCmd(string cmdstr)
        {
            Process p = new Process();
            string str = Environment.GetEnvironmentVariable("windir");//获取系统目录
            string dir = "System32";
            if (!Environment.Is64BitProcess)
            {
                dir = "SysNative";//非64位进程的使用这个目录
            }
            p.StartInfo.WorkingDirectory = System.IO.Path.Combine(str, dir);
           
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;
            //启动程序
            p.Start();
            //向cmd窗口发送输入信息
            //p.StartInfo.Arguments = cmdstr; 
            p.StandardInput.WriteLine(cmdstr+"&exit");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    p.StandardInput.WriteLine("输入的信息为"+cmdstr);
            p.StandardInput.AutoFlush = true;
            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();
        }
    }
}
