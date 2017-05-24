namespace 登录注册
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.命题管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新用户注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.抽取试题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.评阅成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.命题管理ToolStripMenuItem,
            this.抽取试题ToolStripMenuItem,
            this.评阅成绩ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 命题管理ToolStripMenuItem
            // 
            this.命题管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新用户注册ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.用户注销ToolStripMenuItem});
            this.命题管理ToolStripMenuItem.Name = "命题管理ToolStripMenuItem";
            this.命题管理ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.命题管理ToolStripMenuItem.Text = "命题管理";
            this.命题管理ToolStripMenuItem.Click += new System.EventHandler(this.命题管理ToolStripMenuItem_Click);
            // 
            // 新用户注册ToolStripMenuItem
            // 
            this.新用户注册ToolStripMenuItem.Name = "新用户注册ToolStripMenuItem";
            this.新用户注册ToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.新用户注册ToolStripMenuItem.Text = "新用户注册";
            this.新用户注册ToolStripMenuItem.Click += new System.EventHandler(this.新用户注册ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 用户注销ToolStripMenuItem
            // 
            this.用户注销ToolStripMenuItem.Name = "用户注销ToolStripMenuItem";
            this.用户注销ToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.用户注销ToolStripMenuItem.Text = "用户注销";
            this.用户注销ToolStripMenuItem.Click += new System.EventHandler(this.用户注销ToolStripMenuItem_Click);
            // 
            // 抽取试题ToolStripMenuItem
            // 
            this.抽取试题ToolStripMenuItem.Name = "抽取试题ToolStripMenuItem";
            this.抽取试题ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.抽取试题ToolStripMenuItem.Text = "抽取试题";
            // 
            // 评阅成绩ToolStripMenuItem
            // 
            this.评阅成绩ToolStripMenuItem.Name = "评阅成绩ToolStripMenuItem";
            this.评阅成绩ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.评阅成绩ToolStripMenuItem.Text = "评阅成绩";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1330, 764);
            this.textBox1.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师界面";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 命题管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 抽取试题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 评阅成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新用户注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户注销ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}