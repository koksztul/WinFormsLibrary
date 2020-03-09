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
    public partial class NeverBorrowed : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");


        public NeverBorrowed()
        {
            InitializeComponent();
        }

        //List books button
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            SqlDataReader rdr = null;


            try
            {
                // czyszczenie listboxa
                BookList.Items.Clear();

                conn.Open();

                sql = "SELECT * FROM library.dbo.books WHERE id NOT IN(SELECT book_id FROM library.dbo.rents)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

               // MessageBox.Show("Prawidlowe polaczenie z baza danych");

                while (rdr.Read())
                {
                    BookList.Items.Add("Nazwa: " + rdr[1] + " Ilość stron: " + rdr[2]);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void ListBooksBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
