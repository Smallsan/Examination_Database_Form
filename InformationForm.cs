using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExaminationApplication
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            CurrentSession.start_admin_login();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (has_empty_field())
            {
                MessageBox.Show("Please fill up all the fields");
                return;
            }
            if (has_incorrect_value())
            {
                MessageBox.Show("Incorrect values in fields");
                return;
            }

            var confirm_next = MessageBox.Show("Do you want to submit your information?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm_next == DialogResult.Yes)
            {
                save_fields();
                DataHandlers.fetch_questions();
                CurrentSession.start_examination_form();
                CurrentSession.start_next_exam();
                save_to_database();
                Dispose();
            }
        }

        private void save_to_database()
        {
            string query = "INSERT INTO student_information (student_number, name, age, student_year, college, address, course) " +
                       "VALUES (@StudentNumber, @Name, @Age, @StudentYear, @College, @Address, @Course)";
            DatabaseHandler.connect_database();
            using (MySqlCommand command = new MySqlCommand(query, DatabaseHandler.connection))
            {
                command.Parameters.AddWithValue("@StudentNumber", CurrentSession.studentInformation.Student_Number);
                command.Parameters.AddWithValue("@Name", CurrentSession.studentInformation.Name);
                command.Parameters.AddWithValue("@Age", CurrentSession.studentInformation.Age);
                command.Parameters.AddWithValue("@StudentYear", CurrentSession.studentInformation.Student_Year);
                command.Parameters.AddWithValue("@College", CurrentSession.studentInformation.College);
                command.Parameters.AddWithValue("@Address", CurrentSession.studentInformation.Address);
                command.Parameters.AddWithValue("@Course", CurrentSession.studentInformation.Course);
                command.ExecuteNonQuery();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_fields();
        }

        private void save_fields()
        {
            CurrentSession.studentInformation = new DataHandlers.StudentInformation
            {
                Name = nameTextBox.Text,
                Age = Convert.ToInt32(ageComboBox.Text),
                Student_Number = (int)Convert.ToInt64(studentNoTextBox.Text),
                Student_Year = studentYearComboBox.Text,
                College = collegeTextBox.Text,
                Address = addressRichTextBox.Text,
                Course = courseTextBox.Text,
            };
        }

        private void clear_fields()
        {
            nameTextBox.Text = "";
            ageComboBox.SelectedIndex = -1;
            studentNoTextBox.Text = "";
            studentYearComboBox.SelectedIndex = -1;
            collegeTextBox.Text = "";
            addressRichTextBox.Text = "";
            courseTextBox.Text = "";
        }

        private bool has_empty_field()
        {
            return (
            nameTextBox.Text == "" ||
            ageComboBox.SelectedIndex == -1 ||
            studentNoTextBox.Text == "" ||
            studentYearComboBox.SelectedIndex == -1 ||
            collegeTextBox.Text == "" ||
            addressRichTextBox.Text == "" ||
            courseTextBox.Text == ""
            );
        }
        private bool has_incorrect_value()
        {
            return (Regex.IsMatch(studentNoTextBox.Text, @"^[a-zA-Z]+$"));
        }
    }
}
