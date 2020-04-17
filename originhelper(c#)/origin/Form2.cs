using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;//dll必要
using System.Diagnostics;

namespace origin
{
    public partial class From2 : Form
    {
        public From2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="section">节点名称[如[TypeName]]</param>
        /// <param name="key">键</param>
        /// <param name="val">值</param>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string val, string filepath);

     

        private void check_btn_Click(object sender, EventArgs e)
        {
            RegistryKey SVNKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts\EADM");
            if (SVNKey == null)
            {
                MessageBox.Show("没有找到Origin");
                Environment.Exit(1);
            }
            string originfile = SVNKey.GetValue("ClientPath") as string;
            string inifile = Path.GetDirectoryName(originfile) + "\\EACore.ini";
            if (radioButton1.Checked)
            {
                WritePrivateProfileString("Feature", "CdnOverride", "akamai", inifile);
                MessageBox.Show("Cdn已切换为：Akamai");
            }
            if (radioButton2.Checked)
            {
                WritePrivateProfileString("Feature", "CdnOverride", "level3", inifile);
                MessageBox.Show("Cdn已切换为：Level3");
            }
            if (radioButton3.Checked)
            {
                WritePrivateProfileString("Feature", "CdnOverride", "", inifile);
                MessageBox.Show("Cdn已切换为：自动");
            }
        }
    }
}
