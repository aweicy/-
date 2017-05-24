using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录注册
{
    public partial class Form3 : Form
    {
        登录 f1;
        public Form3()
        {
            InitializeComponent();
        }
        private string stra;
        public string StringValue2
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form3(登录 f1):this()
        {
            this.f1 = f1;
            textBox1.Text = f1.StringValue;
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 考试ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 用户注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            注销 zx = new 注销();
            zx.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiugai xiugai = new xiugai(this);
            xiugai.Show();
            
        }

        private void 用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhuce zhuce = new zhuce();
            zhuce.Show();
           
        }

        private void 退出系统ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
