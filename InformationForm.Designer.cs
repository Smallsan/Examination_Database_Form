namespace ExaminationApplication
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentInfoPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.collegeTextBox = new System.Windows.Forms.TextBox();
            this.addressRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentYearComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.studentNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentInformationLabel = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.studentInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentInfoPanel
            // 
            this.studentInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentInfoPanel.Controls.Add(this.courseTextBox);
            this.studentInfoPanel.Controls.Add(this.label7);
            this.studentInfoPanel.Controls.Add(this.clearButton);
            this.studentInfoPanel.Controls.Add(this.submitButton);
            this.studentInfoPanel.Controls.Add(this.collegeTextBox);
            this.studentInfoPanel.Controls.Add(this.addressRichTextBox);
            this.studentInfoPanel.Controls.Add(this.label6);
            this.studentInfoPanel.Controls.Add(this.studentYearComboBox);
            this.studentInfoPanel.Controls.Add(this.ageComboBox);
            this.studentInfoPanel.Controls.Add(this.studentNoTextBox);
            this.studentInfoPanel.Controls.Add(this.label5);
            this.studentInfoPanel.Controls.Add(this.label4);
            this.studentInfoPanel.Controls.Add(this.label3);
            this.studentInfoPanel.Controls.Add(this.label1);
            this.studentInfoPanel.Controls.Add(this.nameTextBox);
            this.studentInfoPanel.Controls.Add(this.label2);
            this.studentInfoPanel.Controls.Add(this.studentInformationLabel);
            this.studentInfoPanel.Location = new System.Drawing.Point(12, 12);
            this.studentInfoPanel.Name = "studentInfoPanel";
            this.studentInfoPanel.Size = new System.Drawing.Size(558, 415);
            this.studentInfoPanel.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clearButton.Location = new System.Drawing.Point(14, 357);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(152, 38);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.submitButton.Location = new System.Drawing.Point(387, 357);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(144, 38);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // collegeTextBox
            // 
            this.collegeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.collegeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collegeTextBox.Location = new System.Drawing.Point(134, 199);
            this.collegeTextBox.Name = "collegeTextBox";
            this.collegeTextBox.Size = new System.Drawing.Size(280, 29);
            this.collegeTextBox.TabIndex = 11;
            // 
            // addressRichTextBox
            // 
            this.addressRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressRichTextBox.Location = new System.Drawing.Point(134, 286);
            this.addressRichTextBox.Name = "addressRichTextBox";
            this.addressRichTextBox.Size = new System.Drawing.Size(397, 54);
            this.addressRichTextBox.TabIndex = 2;
            this.addressRichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // studentYearComboBox
            // 
            this.studentYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentYearComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.studentYearComboBox.FormattingEnabled = true;
            this.studentYearComboBox.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year",
            "5th Year",
            "6th Year"});
            this.studentYearComboBox.Location = new System.Drawing.Point(184, 151);
            this.studentYearComboBox.Name = "studentYearComboBox";
            this.studentYearComboBox.Size = new System.Drawing.Size(180, 29);
            this.studentYearComboBox.TabIndex = 9;
            // 
            // ageComboBox
            // 
            this.ageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.ageComboBox.Location = new System.Drawing.Point(370, 59);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(74, 29);
            this.ageComboBox.TabIndex = 8;
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNoTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNoTextBox.Location = new System.Drawing.Point(172, 103);
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(192, 29);
            this.studentNoTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "College:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(114, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 29);
            this.nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No:";
            // 
            // studentInformationLabel
            // 
            this.studentInformationLabel.AutoSize = true;
            this.studentInformationLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInformationLabel.Location = new System.Drawing.Point(127, 0);
            this.studentInformationLabel.Name = "studentInformationLabel";
            this.studentInformationLabel.Size = new System.Drawing.Size(298, 40);
            this.studentInformationLabel.TabIndex = 0;
            this.studentInformationLabel.Text = "Student Information";
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.adminButton.Location = new System.Drawing.Point(426, 433);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(144, 38);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "Not A Student?";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Course:";
            // 
            // courseTextBox
            // 
            this.courseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTextBox.Location = new System.Drawing.Point(124, 244);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(198, 29);
            this.courseTextBox.TabIndex = 13;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 483);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.studentInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination - Information ";
            this.studentInfoPanel.ResumeLayout(false);
            this.studentInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel studentInfoPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentInformationLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.TextBox studentNoTextBox;
        private System.Windows.Forms.ComboBox studentYearComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox collegeTextBox;
        private System.Windows.Forms.RichTextBox addressRichTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Label label7;
    }
}

