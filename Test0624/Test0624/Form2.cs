using System;
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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userrole = string.Empty;
            if (radioButton1.Checked)
            {
                userrole = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                userrole = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                userrole = radioButton3.Text;
            }
            else
            {
                MessageBox.Show("请选择用户等级", "提示");
            }
            MessageBox.Show("用户等级为：" + userrole, "提示");
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
