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
    
    public partial  class StatusStripForm : Form
    {
        
        public StatusStripForm()
        {
            InitializeComponent();
           
        }

        private void StatusStripForm_Load(object sender, EventArgs e)
        {
            string habits = DCLCommon.habits.ToString();
            toolStripStatusLabel1.Text = "用户：" + DCLCommon.userName;
            toolStripStatusLabel2.Text = "爱好：" + habits.Substring(0, habits.Length-1);
            toolStripStatusLabel3.Text = "特长：" +  DCLCommon.skills.ToString();
        }
    }
}
