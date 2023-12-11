using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationApplication
{
    public partial class StudentRecords : Form
    {
        public StudentRecords()
        {
            InitializeComponent();
            Grid_Student_Records();
        }


        private void Grid_Student_Records()
        {
            DataTable studentScoresData = new DataTable();

            DatabaseHandler.connect_database();

            string query = "SELECT * FROM student_information";

            var adapter = new MySqlDataAdapter(query, DatabaseHandler.connection);

            adapter.Fill(studentScoresData);

            DatabaseHandler.disconnect_database();

            dataGridView1.DataSource = studentScoresData;
        }
    }
}
