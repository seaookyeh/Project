using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] temp = Process.GetProcessesByName("WindowsFormsApp1");
            if (temp.Length > 0)  // 如果不是未运行状态
            {
                MessageBox.Show("程序已在运行");
                Environment.Exit(1);
            }
            MessageBox.Show("欢迎使用本软件");
            DirectoryInfo infoexe = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            textBox1.Text = infoexe.ToString();
        }

    }
}