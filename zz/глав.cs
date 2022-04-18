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
    public partial class глав : Form
    {
        public глав()
        {
            InitializeComponent();
        }

        private void в_Click(object sender, EventArgs e)
        {
            Close();//закрытие
        }

        private void м_Click(object sender, EventArgs e)
        {
            глав.ActiveForm.Hide();//переход к следующему окну
            маг f2 = new маг();
            f2.ShowDialog();
            Close();
        }

        private void к_Click(object sender, EventArgs e)
        {
            глав.ActiveForm.Hide();//переход к следующему окну
            кор f2 = new кор();
            f2.ShowDialog();
            Close();
        }
    }
}
