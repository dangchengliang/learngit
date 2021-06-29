using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test0624
{
    public partial class Activex : Form
    {
        public Activex()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载触发方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Activex_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        /// <summary>
        /// 按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void black_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否打开新窗口？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                NewForm newForm = new NewForm();
                newForm.Show();
            }
            else if(dr == DialogResult.No)
            {
                this.Close();
            }
            
        }

        /// <summary>
        /// 单击窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sigle_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.Show();
            
        }

        /// <summary>
        /// 双击窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Double_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = label1.Text;
            label1.Text = label2.Text;
            label2.Text = temp;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// 登录
        /// </summary>
        public  void Login()
        {
            if (textBox1.Text == "dcl" && textBox2.Text == "123456")
            {
                DialogResult drs = MessageBox.Show("登录成功");
                MonthCalenderForm newForm = new MonthCalenderForm();
                newForm.Show();
            }
            else
            {
                DialogResult drs = MessageBox.Show("账号或密码输入错误！");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
