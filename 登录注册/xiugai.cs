using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录注册
{
    public partial class xiugai : Form
    {
        Form3 f3;
        Form4 f4;
        public xiugai()
        {
            InitializeComponent();
        }
        public xiugai(Form3 f3):this()
        {
            this.f3 = f3;
            textBox1.Text = f3.StringValue2;
            textBox1.ReadOnly = true;
            textBox2.Text = "学生";
            textBox2.ReadOnly = true;
        }
        public xiugai(Form4 f4) : this()
        {
            this.f4 = f4;
            textBox1.Text = f4.StringValue3;
            textBox1.ReadOnly = true;
            textBox2.Text = "教师";
            textBox2.ReadOnly = true;
        }

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
        private void xiugai_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;";
            strConnection += @"Data Source =Database1.accdb ";
            string password = "";
            string name = "";
            string style = "";
            //加密后的结果
            String nami = strToPass(textBox1.Text);
            String pami = strToPass(textBox3.Text);
            String sty = textBox2.Text;
            String pami2 = strToPass(textBox4.Text);
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
                    }
                }
                //更新操作

                if (name != nami || password != pami)
                {
                    MessageBox.Show("用户或密码错误！", "警告");
                }

                else
                {
                    if (sty != style)
                    {
                        MessageBox.Show("用户类型错误！", "警告");
                    }
                    else
                    {
                        if (textBox4.Text == textBox3.Text)
                        {
                            MessageBox.Show("新密码与原密码相同！！！", "警告");
                        }
                        else
                        {
                            if (textBox4.Text != textBox5.Text) { MessageBox.Show("两次密码不一致！", "警告"); }
                            else
                            {

                                string sql = "update 注册 set [password]='" + pami2 + "' where [name]='" + nami + "'";

                                using (OleDbConnection conn = new OleDbConnection(strConnection))
                                {
                                    conn.Open();
                                    OleDbCommand cmd = conn.CreateCommand();
                                    cmd.CommandText = sql;
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                }
                                MessageBox.Show("修改成功", "提示");
                            }

                        }

                    
                }

                     } 
               
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
