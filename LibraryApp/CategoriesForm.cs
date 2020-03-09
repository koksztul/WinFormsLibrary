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
    public partial class CategoriesForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");

        public CategoriesForm()
        {
            InitializeComponent();
        }

        // List by categories button
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            SqlDataReader rdr = null;


            try
            {
                // czyszczenie listboxa
                CategoriesListBox.Items.Clear();
                conn.Open();

                sql = "SELECT categories.name, COUNT(*) AS 'ilosc ksiazek' FROM library.dbo.categories, library.dbo.books WHERE categories.id = books.category_id GROUP BY categories.name; ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                //MessageBox.Show("Prawidlowe polaczenie z baza danych");

                while (rdr.Read())
                {
                    CategoriesListBox.Items.Add("Kategoria: " + rdr[0] + " Ilość książęk: " + rdr[1]);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoriesBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
