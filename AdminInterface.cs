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
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void scoreSummaryButton_Click(object sender, EventArgs e)
        {
            StudentScores studentScores = new StudentScores();
            studentScores.Visible = true;
        }

        private void studentRecordsButton_Click(object sender, EventArgs e)
        {
            StudentRecords studentRecords = new StudentRecords();
            studentRecords.Visible = true;
        }

        private void technologyButton_Click(object sender, EventArgs e)
        {
            QuestionEditor questionEditor = new QuestionEditor("technology");
            questionEditor.Visible = true;
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            QuestionEditor questionEditor = new QuestionEditor("english");
            questionEditor.Visible = true;
        }

        private void scienceButton_Click(object sender, EventArgs e)
        {
            QuestionEditor questionEditor = new QuestionEditor("science");
            questionEditor.Visible = true;
        }

        private void mathButton_Click(object sender, EventArgs e)
        {
            QuestionEditor questionEditor = new QuestionEditor("math");
            questionEditor.Visible = true;
        }
    }
}
