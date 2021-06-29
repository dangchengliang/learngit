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
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        bool flag = true;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddSelectItem();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSelectItem();
        }

        /// <summary>
        /// 向列表中增加选项
        /// </summary>
        private void AddSelectItem()
        {
            string AddItem = textBox1.Text.ToString();
            if (AddItem.Equals(""))
            {
                MessageBox.Show("请输入需要增加的技能");
            }
            else if (comboBox1.Items.Contains(AddItem))
            {
                MessageBox.Show("列表中已有该技能");
            }
            else
            {
                comboBox1.Items.Add(AddItem);
                MessageBox.Show("添加成功");
                textBox1.Text = string.Empty;
            }
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string DeleteItem = textBox1.Text.ToString();
            if (DeleteItem.Equals(""))
            {
                MessageBox.Show("请输入需要删除的技能");
            }
            else if (!comboBox1.Items.Contains(DeleteItem))
            {
                MessageBox.Show("列表中没有该技能");
            }
            else
            {
                comboBox1.Items.Remove(DeleteItem);
                MessageBox.Show("删除成功");
                textBox1.Text = string.Empty;
            }
        }

        private void TimeTick()
        {
            if (flag)
            {
                button1.Text = "不添加";
                flag = false;
            }
            else
            {
                button1.Text = "添加";
                flag = true;
            }
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
   
            timer.Start();
            
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeTick();
        }
    }
}
