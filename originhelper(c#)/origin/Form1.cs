﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace origin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void open_btn_Click(object sender, EventArgs e) //更新指定
        {
            MessageBox.Show("选择修改日期最新的更新文件\r\n格式:OriginUpdate_XX_X_XX_XXX.zip.part");
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.InitialDirectory = "C:\\ProgramData\\Origin\\SelfUpdate";
            openfiledialog.Filter = "part文件(*.part)|*.part";
            openfiledialog.FilterIndex = 1;
            openfiledialog.RestoreDirectory = true;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string dowupdata ="https://download.dm.origin.com/origin/live/" + System.IO.Path.GetFileNameWithoutExtension(openfiledialog.FileName);//下载地址
                if (MessageBox.Show("是:用默认浏览器下载?\r\n否:复制下载地址", "功能选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", dowupdata);
                    MessageBox.Show("正在下载,下载完毕后请将文件拖入程序", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    Clipboard.SetDataObject(dowupdata);
                    MessageBox.Show("下载地址已复制,下载完毕后请将文件拖入程序", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)                                         //获得“信息”
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)                                          //解析信息
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();       //获得路径
            lujing_lab.Text = path;                                                                            //由一个textBox显示路径
        }

        private void updata_btn_Click(object sender, EventArgs e)
        {
            //假设从窗体的TextBox中取得文件路径
            string filepath = @lujing_lab.Text.Trim();
            string name = Path.GetFileName(filepath);
            string dname = @"C:\ProgramData\Origin\SelfUpdate\"+Path.GetFileName(filepath)+".part";
            string destinationPath = @"C:\ProgramData\Origin\SelfUpdate\"+name;
            //利用File类的Exists()方法判断给顶的文件是否存在
            if (File.Exists(filepath))
            {
                //若存在，则剪切到指定文件夹下
                File.Move(filepath, destinationPath);
                //判断是否剪切成功
                if (File.Exists(destinationPath))
                {
                    MessageBox.Show("操作成功", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    File.Delete(dname);
                }
            }
        }

        private void clrom_btn_Click(object sender, EventArgs e)
        {
            string orlocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+"\\Origin";
            DeleteDir(@orlocal);

        }

        public static void DeleteDir(string file)
        {
            try
            {
                //去除文件夹和子文件的只读属性
                //去除文件夹的只读属性
                System.IO.DirectoryInfo fileInfo = new DirectoryInfo(file);
                fileInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;

                //去除文件的只读属性
                System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal);

                //判断文件夹是否还存在
                if (Directory.Exists(file))
                {
                    foreach (string f in Directory.GetFileSystemEntries(file))
                    {
                        if (File.Exists(f))
                        {
                            //如果有子文件删除文件
                            File.Delete(f);
                            Console.WriteLine(f);
                        }
                        else
                        {
                            //循环递归删除子文件夹
                            DeleteDir(f);
                        }
                    }

                    //删除空文件夹
                    Directory.Delete(file);
                    Console.WriteLine(file);
                }

            }
            catch (Exception ex) // 异常处理
            {
                Console.WriteLine(ex.Message.ToString());// 异常信息
            }
        }

        private void 帮助说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("①选择更新文件：选择文件获取文件名整合得下载地址\r\n使用浏览器下载或复制下载地址手动下载\r\n②装载更新文件：将更新文件拖入程序获取路径后剪切到C:\\ProgramData\\Origin\\SelfUpdate\r\n③删除缓存：删除C:\\Users\\用户名\\AppData\\Local\\Origin文件夹\r\n能解决大部分origin界面白屏的情况\r\n④切换CDN：加速游戏下载","帮助说明");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Fancok/BOX-with-Study");
        }

        private void swicdn_btn_Click(object sender, EventArgs e)
        {
            From2 f2 = new From2();
            f2.Show();
        }
    }
}


