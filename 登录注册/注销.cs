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
    public partial class 注销 : Form
    {
        public 注销()
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
        private void button1_Click(object sender, EventArgs e)
        {
            //连接字符串
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;";
            strConnection += @"Data Source =Database1.accdb ";
            string name = "";
            string style = "";
            
            //加密后的结果
            String nami = strToPass(textBox1.Text);
            String style2 = textBox2.Text;
            using (OleDbConnection objConnection = new OleDbConnection(strConnection))
            {
                objConnection.Open();
                OleDbCommand sqlcmd = new OleDbCommand(@"select * from 注册 where name='" + nami + "'and style='" + style2 + "'", objConnection);
                using (OleDbDataReader reader = sqlcmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader["name"].ToString();
                        style = reader["style"].ToString();                   
                    }
                    if(nami!=name)
                    {
                        MessageBox.Show("用户不存在","警告");                        
                    }
                    else if(nami==name&&style!=textBox2.Text)
                            {
                        MessageBox.Show("用户类型错误！","警告");
                            }
                    else if (nami == name && style == textBox2.Text)
                    {
                        MessageBox.Show("将注销用户？","提示");
                        OleDbCommand sqlcmd2 = new OleDbCommand(@"delete * from 注册 where name='" + nami + "'and style='" + style + "'", objConnection);
                        sqlcmd2.ExecuteReader();
                        objConnection.Close();
                        MessageBox.Show("注销成功！", "提示");
                    }
                    
                }                          
            }
        }

        private void 注销_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
