using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录注册
{
    public partial class 登录 : Form
    {
        public 登录()
        {
            InitializeComponent();
            
        }
        public string StringValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        int count=0;//计数器，当用户名和密码错误时，自加 1
        //凯撒算法 字符串转化为字符数组，数组元素自加5，再输出为字符串
        private string strToPass(string str)
        {
            string strAfter = "";
            char[] c = str.ToCharArray();
            int n = str.Length;
            int[] cInt = new int[n];
            int[] cPass = new int[n];
            for (int i = 0; i < n; i++)
            {
                cInt[i] = (int)c[i];
                cPass[i] = cInt[i] + 5;
                strAfter = strAfter + (char)cPass[i];
            }
            return strAfter;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //连接字符串
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;";
            strConnection += @"Data Source =Database1.accdb ";
            string password = ""; 
            string name = "";
            string style = "";
            //加密后的结果
            String nami= strToPass(textBox1.Text);
            String pami= strToPass(textBox2.Text);
            //与数据库中的属性进行比较
            using (OleDbConnection objConnection = new OleDbConnection(strConnection))
            {
                objConnection.Open();
                OleDbCommand sqlcmd = new OleDbCommand(@"select * from 注册 where name='" + nami + "'and password='" + pami + "'", objConnection);
                using (OleDbDataReader reader = sqlcmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader["name"].ToString();
                        password = reader["password"].ToString();
                        style = reader["style"].ToString();
                        objConnection.Close();

                    }
                }
                //用户名密码为空
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    count++;
                    MessageBox.Show("用户名和密码不能为空","警告");

                }
                //用户名密码正确
                else if (nami == name && pami == password)
                {
                            //登录类型
                            if (style == "管理员")
                            {
                              StringValue = textBox1.Text;
                            Form2 form2 = new Form2();
                                form2.Show();
                                this.Hide();
                            }
                            else if (style == "学生")
                            {                                
                                Form3 form3 = new Form3(this);
                                form3.Show();
                                this.Hide();
                             
                        
                                                                                               
                                                                                                       
                    }
                            else if (style == "教师")
                            {
                                Form4 form4 = new Form4(this);
                                form4.Show();
                                this.Hide();
                        
                    }
                }
                //用户名密码错误
                else
                {
                    count++;
                    MessageBox.Show("登录失败，用户名或密码错误请注册您的用户名密码！","警告");                 
                }
              
            }
            //用户名或密码错误3次退出程序
            if (count == 3)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清除textbox1和textbox2
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
