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
    public partial class StudentScores : Form
    {
        public StudentScores()
        {
            InitializeComponent();
            Grid_Student_Scores();
            Display_Information();
        }
        private void Grid_Student_Scores()
        {
            DataTable studentScoresData = new DataTable();

            DatabaseHandler.connect_database();

            string query = "SELECT * FROM student_scores";

            var adapter = new MySqlDataAdapter(query, DatabaseHandler.connection);

            adapter.Fill(studentScoresData);  

            DatabaseHandler.disconnect_database();

            dataGridView1.DataSource = studentScoresData;
        }

        private void Display_Information()
        {
            DataTable studentScoresData = Get_Student_Grades();
            int thresholdScore = 24; 
            int passedCount = CountPassedStudents(thresholdScore, studentScoresData);
            int failedCount = studentScoresData.Rows.Count - passedCount;

            informationLabel.Text = "Passed Count: " + passedCount + "   Failed Count: " + failedCount;

        }

        private DataTable Get_Student_Grades()
        {
            DataTable studentScoresData = new DataTable();

            DatabaseHandler.connect_database();

            string query = "SELECT total_score FROM student_scores";

            var adapter = new MySqlDataAdapter(query, DatabaseHandler.connection);

            adapter.Fill(studentScoresData);

            return studentScoresData;
        }
        private int CountPassedStudents(int thresholdScore, DataTable studentScoresData)
        {
            int passedCount = 0;
            foreach (DataRow row in studentScoresData.Rows)
            {
                int totalScore = Convert.ToInt32(row["total_score"]);
                if (totalScore >= thresholdScore)
                {
                    passedCount++;
                }
            }
            return passedCount;
        }

    }
}
