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
    public partial class zhuce : Form
    {
        public zhuce()
        {
            InitializeComponent();
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
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox4.Text != textBox3.Text)
            {
                MessageBox.Show("两次密码不相符", "警告");
            }

            String nami = strToPass(textBox1.Text);
            String sty = textBox2.Text;
            String pami = strToPass(textBox3.Text);
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;";
            strConnection += @"Data Source =Database1.accdb ";




            string password = "";
            string name = "";
            string style = "";

            using (OleDbConnection objConnection = new OleDbConnection(strConnection))
            {
                objConnection.Open();
                OleDbCommand sqlcmd = new OleDbCommand(@"select * from 注册 where name='" + nami + "'", objConnection);
                using (OleDbDataReader reader = sqlcmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader["name"].ToString();
                    }
                }
                if (name == nami) { MessageBox.Show("用户已存在！", "提示"); }
                else
                {
                    string sql = "Insert into 注册([name],[password],[style]) values ('" + nami + "','" + pami + "','" + sty + "')";
                    using (OleDbConnection conn = new OleDbConnection(strConnection))
                    {
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    MessageBox.Show("注册成功", "提示");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
