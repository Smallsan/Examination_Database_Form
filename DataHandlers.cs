using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace ExaminationApplication
{
    public class DataHandlers
    {
        public struct StudentScore
        {
            public int Student_Number { get; set; }

            public int Math_Score { get; set; }

            public int English_Score { get; set; }
            public int Science_Score { get; set; }
            public int Technology_Score { get; set; }
            public int Total_Score { get; set; }
            public DateTime Date { get; set; }
        }
        public struct ExaminationQuestions
        {
            public int Question_Number { get; set; }
            public string Question { get; set; }
            public string Choice_A { get; set; }
            public string Choice_B { get; set; }
            public string Choice_C { get; set; }
            public string Choice_D { get; set; }
            public string Correct_Letter { get; set; }
        }
        public struct StudentInformation
        {
            public int Student_Number { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Student_Year { get; set; }
            public string College { get; set; }
            public string Address { get; set; }
            public string Course { get; set; }
        }

        public static ExaminationQuestions[] math_questions;
        public static ExaminationQuestions[] science_questions;
        public static ExaminationQuestions[] technology_questions;
        public static ExaminationQuestions[] english_questions;

        public static void fetch_questions()
        {
            math_questions = get_randomized_questions("math");
            science_questions = get_randomized_questions("science");
            technology_questions = get_randomized_questions("technology");
            english_questions = get_randomized_questions("english");
        }
        private static ExaminationQuestions[] get_randomized_questions(String subject)
        {
            List<ExaminationQuestions> examination_questions = new List<ExaminationQuestions>();
            string query = "SELECT * FROM " + subject + "_questions";
            DatabaseHandler.connect_database();
            using (MySqlCommand command = new MySqlCommand(query, DatabaseHandler.connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        examination_questions.Add(new ExaminationQuestions
                        {
                            Question_Number = reader.GetInt32(0),
                            Question = reader.GetString(1),
                            Choice_A = reader.GetString(2),
                            Choice_B = reader.GetString(3),
                            Choice_C = reader.GetString(4),
                            Choice_D = reader.GetString(5),
                            Correct_Letter = reader.GetString(6),
                        });
                    }
                }
            }
            DatabaseHandler.disconnect_database();
            return list_randomizer(examination_questions, 10).ToArray();
        }
        private static List<ExaminationQuestions> list_randomizer(List<ExaminationQuestions> list, int list_size)
        {
            Random random = new Random();

            List<ExaminationQuestions> shuffled_list = list.OrderBy(x => random.Next()).ToList();

            List<ExaminationQuestions> randomized_list = shuffled_list.Take(list_size).ToList();

            List<ExaminationQuestions> numbered_list = new List<ExaminationQuestions>();

            ExaminationQuestions holder = new ExaminationQuestions();

            int numberer = 1;
            foreach (ExaminationQuestions examinationQuestions in randomized_list)
            {
                holder = examinationQuestions;
                holder.Question_Number = numberer;
                numbered_list.Add(holder);
                numberer++;
            }
            
            return numbered_list;
        }

    }
}
