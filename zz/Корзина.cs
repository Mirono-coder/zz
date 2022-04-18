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
    public partial class Корзина : Form
    {
        public Корзина()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Корзина.ActiveForm.Hide();//переход к следующему окну
            глав f2 = new глав();
            f2.ShowDialog();
            Close();
        }
    }
}
