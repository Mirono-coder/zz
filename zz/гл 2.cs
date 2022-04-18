using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zz
{
    public partial class гл_2 : Form
    {
        public гл_2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            гл_2.ActiveForm.Hide();
            маг f2 = new маг();
            f2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            гл_2.ActiveForm.Hide();
            глав f2 = new глав();
            f2.ShowDialog();
            Close();
        }
    }
}
