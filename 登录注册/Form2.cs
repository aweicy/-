using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录注册
{
    public partial class Form2 : Form
    {
        登录 f1 ;

        public Form2()
        {
            InitializeComponent();
        }
        private string[] ti_mu;   //存放题目
        private string[,] Item;    //存放A、B、C、D四个选择项
        private char[] Answer;     //存放题库题目答案
        private char[] MyAnswer;   //存放测试者的答案
        private int s;                //题号
        private int Total;           //题目总数
        private int N;



        private void chu_ti()
        {
            label1.Text = ti_mu[s];         //显示题目
            radioButton1.Text = Item[s, 1]; //以下显示４个选项
            radioButton2.Text = Item[s, 2];
            radioButton3.Text = Item[s, 3];
            radioButton4.Text = Item[s, 4];
            if (MyAnswer[s] == 0)
                radioButton5.Checked = true;//  选中radioButton5按钮          
            else
            {
                if (MyAnswer[s] == 'A')
                    radioButton1.Checked = true;//选中radioButton1按钮
                if (MyAnswer[s] == 'B')
                    radioButton2.Checked = true;//选中radioButton2按钮
                if (MyAnswer[s] == 'C')
                    radioButton3.Checked = true;//选中radioButton3按钮
                if (MyAnswer[s] == 'D')
                    radioButton4.Checked = true;//选中radioButton4按钮    
            }
        }
        private void show_Answer()
        {
            String[] subItem;
            subItem = new string[3];
            subItem[0] = s.ToString();            //题号
            subItem[1] = Answer[s].ToString();     //正确答案
            subItem[2] = MyAnswer[s].ToString();   //用户答案
            ListViewItem item = listView1.FindItemWithText(subItem[0]);
            if (item == null)                     //如果此题未加入 
                listView1.Items.Add(new ListViewItem(subItem));
         
        }
        public Form2(登录 f1):this()
        {
            this.f1 = f1;
            string aa = f1.StringValue;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {       
            string Connstr;       //连接数据库字符串
            Connstr = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source =Databaseaa.accdb;";
            OleDbConnection con = new OleDbConnection(Connstr);
            con.Open();
            string sqlstr = "select count(*) from choise";
            OleDbCommand cmd = new OleDbCommand(sqlstr, con);
            //this.Text = Convert.ToString(cmd.ExecuteScalar());
            Total = (int)cmd.ExecuteScalar();//获取题目总数

            sqlstr = "select * from choise";
            cmd = new OleDbCommand(sqlstr, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            N = Total + 1;
            ti_mu = new string[N];
            Item = new string[N, 5];
            Answer = new char[N];
            MyAnswer = new char[N];
            s = 1;
            while (dr.Read())  //读取试题库
            {
                //题目列的下标0，选项列的下标1-4，答案列的下标5
                ti_mu[s] = s.ToString() + "." + Convert.ToString(dr[0]);//读取题目列的值
                Item[s, 1] = "A." + Convert.ToString(dr[1]);//读取选项A的值
                Item[s, 2] = "B." + Convert.ToString(dr[2]);//读取选项B的值
                Item[s, 3] = "C." + Convert.ToString(dr[3]);//读取选项C的值
                Item[s, 4] = "D." + Convert.ToString(dr[4]);//读取选项D的值
                Answer[s] = Convert.ToChar(dr[5]);//读取答案列的值
                s++;
            }
            dr.Close();
            con.Close();
            s = 1;
            chu_ti();
            btnFirst.Enabled = false;
            btnPre.Enabled = false;
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 文件保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog file1 = new SaveFileDialog();
            file1.Filter = "文本文件|*.txt";
            if (file1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(file1.FileName);
                sw.Write(listView1.Text);
                sw.Close();
            }
        }

        private void 文件打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file2 = new OpenFileDialog();
            file2.Filter = "文本文件|*.txt";
            if (file2.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = File.OpenText(file2.FileName);
                while (sr.EndOfStream != true)
                {
                    listView1.Text = sr.ReadLine();
                }
            }
        }

        private void 新用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhuce zhuce = new zhuce();
            zhuce.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiugai xiugai = new xiugai();
            xiugai.Show();                  
            
        }

        private void 用户注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            注销 zx = new 注销();
            zx.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 文件备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            信息查询 xin = new 信息查询();
            xin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = 1;
            chu_ti();
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
            btnFirst.Enabled = false;
            btnPre.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == 1)
            { btnPre.Enabled = false; btnFirst.Enabled = false; }
            chu_ti();
            btnNext.Enabled = true;
            btnEnd.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            show_Answer();
            s = s + 1;
            if (s == Total)
            { btnNext.Enabled = false; btnEnd.Enabled = false; }
            chu_ti();
            btnFirst.Enabled = true;
            btnPre.Enabled = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            s = Total;
            chu_ti();
            btnFirst.Enabled = true;
            btnPre.Enabled = true;
            btnEnd.Enabled = false;
            btnNext.Enabled = false;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            int score = 0;
            for (int i = 1; i <= Total; i++)
            {
                if (Answer[i] == MyAnswer[i])
                    score++;
            }
            score = score * 100 / Total;
            MessageBox.Show(score.ToString(), "你的成绩");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)//选中A
                MyAnswer[s] = 'A';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)//选中B
                MyAnswer[s] = 'B';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)//选中C
                MyAnswer[s] = 'C';
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)//选中D
                MyAnswer[s] = 'D';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void 文件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
