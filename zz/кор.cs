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
    public partial class кор : Form
    {
        public кор()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            кор.ActiveForm.Hide();//переход к следующему окну
            глав f2 = new глав();
            f2.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            кор.ActiveForm.Hide();//переход к следующему окну
            Корзина f2 = new Корзина();
            f2.ShowDialog();
            Close();
        }
    }
}
