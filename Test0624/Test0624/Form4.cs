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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            for(int i=0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                msg += checkedListBox1.CheckedItems[i].ToString() + "、";
            }
            if (msg.Equals(""))
            {
                MessageBox.Show("请选择您想要选购的商品");
            }
            else
            {
                MessageBox.Show("您选购的商品有：" + msg.Substring(0, msg.Length - 1));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
