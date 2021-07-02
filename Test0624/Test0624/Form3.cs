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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //将选择的爱好存入list中用于页面传值
        public List<string> habitdata = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string habits = string.Empty;
            foreach(Control cb in Controls)
            {
                if(cb is CheckBox)
                {
                    if (((CheckBox)cb).Checked)
                    {
                        habits += cb.Text + "、";
                        habitdata.Add(cb.Text);
                    }
                }
                
            }
            if (habits.Equals(""))
            {
                MessageBox.Show("请选择您的爱好");
            }
            else
            {
                MessageBox.Show("您的爱好为：" +habits.Substring(0,habits.Length-1));
                ComboBoxForm lb = new ComboBoxForm();
                DCLCommon.habits = habits;
                lb.Show();
            }
        }
    }
}
