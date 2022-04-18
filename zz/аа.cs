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
    public partial class аа : Form
    {
        public аа()
        {
            InitializeComponent();
        }

        private void е_Click(object sender, EventArgs e)
        {
            String ConnStr = (@"Data Source=KING-ПК\SQL; Initial Catalog=zz2; Integrated Security=True");//подключение
            SqlConnection dbConnection = new SqlConnection(ConnStr);
            dbConnection.Open();
            bool succes = false;
            try
            {
                const string comand = "Select [ФИО], [Пароль] from Польз where [ФИО]=@Log And [Пароль]=@Par";//запрос
                    SqlCommand check = new SqlCommand(comand, dbConnection);
                check.Parameters.AddWithValue("@Log", тт.Text);
                check.Parameters.AddWithValue("@Par", т.Text);
                using (SqlDataReader dataReader=check.ExecuteReader())
                {
                    succes = dataReader.Read();
                }
            }
            finally
            {
                dbConnection.Close();
            }
            if (succes)
            {
                MessageBox.Show("все верно-проходите");//результат
                аа.ActiveForm.Hide();
                глав f2 = new глав();
                f2.ShowDialog();
                Close();

            }
        }
    }
}
