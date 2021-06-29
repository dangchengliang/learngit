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
    public partial class ListBoxl : Form
    {
        public ListBoxl(List<string> habitsdata)
        {
            InitializeComponent();
            foreach(var i in habitsdata)
            {
                LB.Items.Add(i);
            }
            
        }

      
        private void ListBoxl_Load(object sender, EventArgs e)
        {
            
            
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text.ToString();
            if (text.Equals(""))
            {
                MessageBox.Show("请确定您想要添加的爱好");
            }
            else
            {
                LB.Items.Add(this.textBox1.Text);
            }
            
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(LB.SelectedItems.Count > 0)
            {
                List<string> removevalue = new List<string>();
                for(int i=0; i < LB.SelectedItems.Count; i++)
                {
                    removevalue.Add(LB.SelectedItems[i].ToString());
                }
                foreach(var item in removevalue)
                {
                    LB.Items.Remove(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("请选择需要删除的爱好");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
