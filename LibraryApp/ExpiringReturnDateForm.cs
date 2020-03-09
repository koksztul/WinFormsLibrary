using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryApp
{
    public partial class ExpiringReturnDateForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");

        public ExpiringReturnDateForm()
        {
            InitializeComponent();
        }

        private void ShowExpiringButton_Click(object sender, EventArgs e)
        {
            string sql = "", output = "";
            SqlDataReader rdr = null;


            try
            {
                // czyszczenie listboxa
                ExpiringBooksListBox.Items.Clear();

                conn.Open();

                sql = "SELECT books.id, books.name FROM library.dbo.rents INNER JOIN library.dbo.books ON books.id = rents.book_id WHERE DATEDIFF(DAY, planned_return_date, rent_date) < 7";
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                //MessageBox.Show("Prawidlowe polaczenie z baza danych");

                while (rdr.Read())
                {
                    ExpiringBooksListBox.Items.Add("Id: " + rdr[0] + " Nazwa: " + rdr[1]);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);         
            }
        }

        private void ExpiringBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
