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
    public partial class 员工维护 : Form
    {
        public 员工维护()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 员工维护_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database1DataSet1.注册”中。您可以根据需要移动或删除它。
            this.注册TableAdapter.Fill(this.database1DataSet1.注册);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
