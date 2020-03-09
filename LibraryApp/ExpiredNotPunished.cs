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
    public partial class ExpiredNotPunished : Form
    {

        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");

        public ExpiredNotPunished()
        {
            InitializeComponent();
        }

        private void ShowExpiredButton_Click(object sender, EventArgs e)
        {
            string sql = "";
            SqlDataReader rdr = null;


            try
            {
                // czyszczenie listboxa
                ExpiredBooksListBox.Items.Clear();

                conn.Open();

                sql = "SELECT k.id, k.name FROM library.dbo.rents wy INNER JOIN library.dbo.books k ON k.id = wy.book_id WHERE wy.id NOT IN(SELECT rent_id FROM library.dbo.punishments) AND DATEDIFF(DAY, wy.rent_date, wy.planned_return_date) > 0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                //MessageBox.Show("Prawidlowe polaczenie z baza danych");

                while (rdr.Read())
                {
                   ExpiredBooksListBox.Items.Add("id: " + rdr[0] + " Nazwa: " + rdr[1]);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExpiredBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
