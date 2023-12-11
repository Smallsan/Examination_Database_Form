using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ExaminationApplication
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (has_empty_field())
            {
                MessageBox.Show("Please fill up all the fields");
                return;
            }
            string username = userTextBox.Text;
            string password = passwordTextBox.Text;
            string query = "SELECT COUNT(*) FROM admin_account WHERE username = '" + username + "' AND password = '" + password + "'";

            using (DatabaseHandler.connection)
            {
                MySqlCommand command = new MySqlCommand(query, DatabaseHandler.connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                DatabaseHandler.connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    CurrentSession.start_admin_interface();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
        }
        private bool has_empty_field()
        {
            return (userTextBox.Text == "" || passwordTextBox.Text == "");
        }
    }
}