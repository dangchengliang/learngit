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
    public partial class ContexMenuForm : Form
    {
        public ContexMenuForm()
        {
            InitializeComponent();
        }

        private void OpenNewFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
            MonthCalenderForm form = new MonthCalenderForm();
            form.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContexMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
