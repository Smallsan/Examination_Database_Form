using ExaminationApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Examination
{
    public partial class ExaminationForm : Form
    {
        public ExaminationForm()
        {
            InitializeComponent();
        }
        public void initiate_questions(DataHandlers.ExaminationQuestions[] examinationQuestions, String subject)
        {
            CurrentSession.current_examination_questions = examinationQuestions;
            CurrentSession.current_subject = subject;
            Text = "Examination - " + subject;
            titleLabel.Text = subject + " Examination Part 1";
            this.Text = titleLabel.Text;
            foreach (DataHandlers.ExaminationQuestions question in examinationQuestions)
            {
                set_question(question);
            }

        }

        public void reset_radio_buttons()
        {
            foreach (Control control in Controls)
            {
                if (control is Panel panel && panel.Name.StartsWith("panel"))
                {
                    panel.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);
                }
            }
        }

        public void grade_answers()
        {
            foreach (DataHandlers.ExaminationQuestions question in CurrentSession.current_examination_questions)
            {

                int question_number = question.Question_Number;
                RadioButton[] radioButtons = get_radio_buttons(question_number);

                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton.Checked)
                    {
                        if (radioButton.Text.StartsWith(question.Correct_Letter.ToLower()))
                        {
                            CurrentSession.add_score();
                        }
                    }
                }
            }
        }

        private RadioButton[] get_radio_buttons(int question_number)
        {
            List<RadioButton> radio_buttons = new List<RadioButton>();

            string[] radio_button_names = new string[] { "a", "b", "c", "d" };

            foreach (string name in radio_button_names)
            {
                string radio_button_name = $"question{question_number}{name}RadioButton";
                Control[] controls = this.Controls.Find(radio_button_name, true);

                if (controls.Length > 0 && controls[0] is RadioButton radio_button)
                {
                    ;
                    radio_buttons.Add(radio_button);
                }
            }
            return radio_buttons.ToArray();
        }


        private void set_question(DataHandlers.ExaminationQuestions examination_question)
        {
            int question_number = examination_question.Question_Number;

            Control questionLabel = Controls.Find($"question{question_number}Label", true).FirstOrDefault();
            if (questionLabel != null && questionLabel is RichTextBox)
            {
                ((RichTextBox)questionLabel).Text = question_number + ".) " + examination_question.Question;
            }

            Control radioButtonA = Controls.Find($"question{question_number}aRadioButton", true).FirstOrDefault();
            if (radioButtonA != null && radioButtonA is RadioButton)
            {
                ((RadioButton)radioButtonA).Text = "a.) " + examination_question.Choice_A;
            }

            Control radioButtonB = Controls.Find($"question{question_number}bRadioButton", true).FirstOrDefault();
            if (radioButtonB != null && radioButtonB is RadioButton)
            {
                ((RadioButton)radioButtonB).Text = "b.) " + examination_question.Choice_B;
            }

            Control radioButtonC = Controls.Find($"question{question_number}cRadioButton", true).FirstOrDefault();
            if (radioButtonC != null && radioButtonC is RadioButton)
            {
                ((RadioButton)radioButtonC).Text = "c.) " + examination_question.Choice_C;
            }

            Control radioButtonD = Controls.Find($"question{question_number}dRadioButton", true).FirstOrDefault();
            if (radioButtonD != null && radioButtonD is RadioButton)
            {
                ((RadioButton)radioButtonD).Text = "d.) " + examination_question.Choice_D;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var confirm_next = MessageBox.Show("Do you want to submit your answers?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm_next == DialogResult.Yes)
            {
                grade_answers();
                Dispose();
                CurrentSession.start_result();
            }
        }
    }
}

