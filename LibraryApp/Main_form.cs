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
    public partial class Main_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-23F0CKP; Initial Catalog =library; User ID = sa; Password=sa123");
        public Main_form()
        {
            InitializeComponent();
        }

        

        // Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Login button
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string userid = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            SqlCommand cmd = new SqlCommand("select * from library.dbo.Admins where Login='" + UsernameTextBox.Text + "'and Passowrd='" + PasswordTextBox.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                var LoggedInForm = new Logged_in();
                this.Hide();
                LoggedInForm.ShowDialog();
                this.Show();
                UsernameTextBox.Text = "Username";
                PasswordTextBox.Text = "Password";
                if (LoginErrorLabel.Visible)
                {
                    LoginErrorLabel.Visible = false;
                }
            }
            else
            {
                LoginErrorLabel.Visible = true;
            }
            conn.Close();




        }
        // Registration button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegistrationForm = new RegistrationForm();
            RegistrationForm.ShowDialog();
            this.Show();
            LoginErrorLabel.Visible = false;
        }
    }
}
