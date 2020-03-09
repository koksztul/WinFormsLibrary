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
    public partial class UsersWithBorrowedBooks : Form
    {

        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");

        public UsersWithBorrowedBooks()
        {
            InitializeComponent();
        }

        private void UsersWBooksBorrowedButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            SqlDataReader rdr = null;


            try
            {
                //czyszczenie listboxa
                UsersWBooksBorrowedListBox.Items.Clear();
                conn.Open();

                sql = "SELECT cz.name, cz.surname FROM library.dbo.readers cz INNER JOIN library.dbo.rents wy ON cz.id = wy.reader_id WHERE wy.return_date IS NULL";
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                //MessageBox.Show("Prawidlowe polaczenie z baza danych");

                while (rdr.Read())
                {
                    UsersWBooksBorrowedListBox.Items.Add("Imie: " + rdr[0] + "Nazwisko: " + rdr[1]);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WithBorrowedBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
