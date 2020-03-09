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
    public partial class AllReaders : Form
    {

        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");

        public AllReaders()
        {
            InitializeComponent();
        }

        private void AllReadesBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            SqlDataReader rdr = null;


            try
            {
                AllReadersListBox.Items.Clear();

                conn.Open();

                sql = "SELECT * FROM library.dbo.readers";
                SqlCommand cmd = new SqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                //MessageBox.Show("Prawidlowe polaczenie z baza danych");

                while (rdr.Read())
                {
                   AllReadersListBox.Items.Add("Imie: " + rdr[1] + " Nazwisko: " + rdr[2]);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
