using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zz
{
    
    public partial class маг : Form
    {
        

        public маг()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {
        
       
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            маг.ActiveForm.Hide();//переход к следующему окну
            гл_2 f2 = new гл_2();
            f2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            маг.ActiveForm.Hide();//переход к следующему окну
            глав f2 = new глав();
            f2.ShowDialog();
            Close();
        }
    }
}
