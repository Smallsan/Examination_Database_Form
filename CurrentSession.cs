using Examination;

namespace ExaminationApplication
{
    public class CurrentSession
    {
        public enum Exam{
            Math,
            English,
            Science,
            Technology
        }
        public static DataHandlers.ExaminationQuestions[] current_examination_questions;
        public static Exam next_exam = Exam.Math;
        public static string current_subject = "";
        public static int math_score = 0;
        public static int english_score = 0;
        public static int science_score = 0;
        public static int technology_score = 0;
        public static AdminInterface admin_interface;
        public static AdminLogin admin_login;
        public static ExaminationForm examination_form;
        public static InformationForm information_form;
        public static Result result;
        public static DataHandlers.StudentInformation studentInformation;
        public static DataHandlers.StudentScore studentScore;

        public static void start_admin_interface()
        {
            admin_interface = new AdminInterface();
            admin_interface.Visible = true;
        }
        public static void start_admin_login()
        {
            admin_login = new AdminLogin();
            admin_login.Visible = true;
        }
        public static void start_examination_form()
        {
            examination_form = new ExaminationForm();
            examination_form.Visible = true;
        }

        public static void start_information_form()
        {
            information_form = new InformationForm();
            information_form.Visible = true;
        }

        public static void start_result()
        {
            result = new Result();
            result.Visible = true;
        }
        public static void add_score()
        {
            switch (current_subject)
            {
                case ("Math"):
                    math_score++; break;
                case ("Technology"):
                    technology_score++; break;
                case ("Science"):
                    science_score++; break;
                case ("English"):
                    english_score++; break;
            }
        }
        public static void start_next_exam()
        {
            switch (next_exam)
            {
                case (Exam.Math):
                    examination_form.initiate_questions(DataHandlers.math_questions, "Math");
                    next_exam = Exam.Science;
                    break;
                case (Exam.Science):
                    examination_form.initiate_questions(DataHandlers.science_questions, "Science");
                    next_exam = Exam.English;
                    break;
                case (Exam.English):
                    examination_form.initiate_questions(DataHandlers.english_questions, "English");
                    next_exam = Exam.Technology;
                    break;
                case (Exam.Technology):
                    examination_form.initiate_questions(DataHandlers.technology_questions, "Technology");
                    next_exam = Exam.Math;
                    break;

            }
        }
    }
}
