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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            Inititate_Scores();
        }

        public void Inititate_Scores()
        {
            int math_score = CurrentSession.math_score;
            int science_score = CurrentSession.science_score;
            int english_score = CurrentSession.english_score;
            int technology_score = CurrentSession.technology_score;
            int total_score = math_score + science_score + english_score + technology_score;
            mathLabel.Text = "Math Score = " + math_score + "/10";
            scienceLabel.Text = "Science Score = " + science_score + "/10";
            technologyLabel.Text = "Technology Score = " + technology_score + "/10";
            englishLabel.Text = "English Score = " + english_score + "/10";
            totalScoreLabel.Text = "Total Score = " + total_score + "/40";
            if (CurrentSession.next_exam == CurrentSession.Exam.Math)
            {
                nextButton.Visible = false;
                exitButton.Visible = true;
                backButton.Visible = true;
                save_values(math_score, science_score, english_score, technology_score, total_score);
                save_to_database();
                mark_grade(total_score);
                marksLabel.Visible = true;
            }
        }

        private void mark_grade(int total_score)
        {
            marksLabel.Visible = true;
            if (total_score >= 24)
            {
                marksLabel.Text = "Marks: Passed";
            }
            else
            {
                marksLabel.Text = "Marks: Failed";
            }
            double percentage = (double)((total_score / 40) * 100);
            percentLabel.Text = "percentage: " + percentage + "%";
            percentLabel.Visible = true;
                
        }
        private void save_values(int math_score, int science_score, int english_score, int technology_score, int total_score)
        {
            CurrentSession.studentScore = new DataHandlers.StudentScore {
                Student_Number = CurrentSession.studentInformation.Student_Number,
                Math_Score = math_score,
                Science_Score = science_score,
                English_Score = english_score,
                Technology_Score = technology_score,
                Total_Score = total_score,
                Date = DateTime.Now,
            };
        }

        private void save_to_database()
        {
            string query = "INSERT INTO student_scores (student_no, math_score, english_score, science_score, technology_score, total_score, date_taken) " +
               "VALUES (@StudentNo, @MathScore, @EnglishScore, @ScienceScore, @TechnologyScore, @TotalScore, @DateTaken)";
            DatabaseHandler.connect_database();
            using (MySqlCommand command =  new MySqlCommand(query, DatabaseHandler.connection))
            {
                command.Parameters.AddWithValue("@StudentNo", CurrentSession.studentScore.Student_Number);
                command.Parameters.AddWithValue("@MathScore", CurrentSession.studentScore.Math_Score);
                command.Parameters.AddWithValue("@EnglishScore", CurrentSession.studentScore.English_Score);
                command.Parameters.AddWithValue("@ScienceScore", CurrentSession.studentScore.Science_Score);
                command.Parameters.AddWithValue("@TechnologyScore", CurrentSession.studentScore.Technology_Score);
                command.Parameters.AddWithValue("@TotalScore", CurrentSession.studentScore.Total_Score);
                command.Parameters.AddWithValue("@DateTaken", CurrentSession.studentScore.Date);
                command.ExecuteNonQuery();
            }
            DatabaseHandler.disconnect_database();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            CurrentSession.start_examination_form();
            CurrentSession.start_next_exam();
            Dispose();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CurrentSession.start_information_form();
            Dispose();
            
        }
    }
}
