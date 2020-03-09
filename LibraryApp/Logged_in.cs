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
    public partial class Logged_in : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");
        public Logged_in()
        {
            InitializeComponent();
        }
        //nor borrowed
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ListBooksForm = new NeverBorrowed();
            ListBooksForm.ShowDialog();
            this.Show();
        }
        //back to login
        private void button2_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            
        }
        //categories
        private void button3_Click(object sender, EventArgs e)
        {
            var CategoriesForm = new CategoriesForm();
            CategoriesForm.ShowDialog();
        }
        //expiring
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ExpiringForm = new ExpiringReturnDateForm();
            ExpiringForm.ShowDialog();
            this.Show();
        }
        //expired
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ExpiredForm = new ExpiredNotPunished();
            ExpiredForm.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UsersWithBorrowedBooks = new UsersWithBorrowedBooks();
            UsersWithBorrowedBooks.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AllBooksForm = new AllBooks();
            AllBooksForm.ShowDialog();
            this.Show();
        }
    }
}
