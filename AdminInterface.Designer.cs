namespace ExaminationApplication
{
    partial class AdminInterface
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
            this.scoreSummaryButton = new System.Windows.Forms.Button();
            this.studentRecordsButton = new System.Windows.Forms.Button();
            this.technologyButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.mathButton = new System.Windows.Forms.Button();
            this.scienceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreSummaryButton
            // 
            this.scoreSummaryButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreSummaryButton.Location = new System.Drawing.Point(12, 12);
            this.scoreSummaryButton.Name = "scoreSummaryButton";
            this.scoreSummaryButton.Size = new System.Drawing.Size(225, 55);
            this.scoreSummaryButton.TabIndex = 0;
            this.scoreSummaryButton.Text = "Student Score Summary";
            this.scoreSummaryButton.UseVisualStyleBackColor = true;
            this.scoreSummaryButton.Click += new System.EventHandler(this.scoreSummaryButton_Click);
            // 
            // studentRecordsButton
            // 
            this.studentRecordsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRecordsButton.Location = new System.Drawing.Point(12, 73);
            this.studentRecordsButton.Name = "studentRecordsButton";
            this.studentRecordsButton.Size = new System.Drawing.Size(225, 55);
            this.studentRecordsButton.TabIndex = 1;
            this.studentRecordsButton.Text = "Student Records";
            this.studentRecordsButton.UseVisualStyleBackColor = true;
            this.studentRecordsButton.Click += new System.EventHandler(this.studentRecordsButton_Click);
            // 
            // technologyButton
            // 
            this.technologyButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technologyButton.Location = new System.Drawing.Point(243, 195);
            this.technologyButton.Name = "technologyButton";
            this.technologyButton.Size = new System.Drawing.Size(225, 55);
            this.technologyButton.TabIndex = 2;
            this.technologyButton.Text = "Technology Questions";
            this.technologyButton.UseVisualStyleBackColor = true;
            this.technologyButton.Click += new System.EventHandler(this.technologyButton_Click);
            // 
            // englishButton
            // 
            this.englishButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishButton.Location = new System.Drawing.Point(243, 134);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(225, 55);
            this.englishButton.TabIndex = 3;
            this.englishButton.Text = "English Questions";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // mathButton
            // 
            this.mathButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathButton.Location = new System.Drawing.Point(243, 12);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(225, 55);
            this.mathButton.TabIndex = 4;
            this.mathButton.Text = "Math Questions";
            this.mathButton.UseVisualStyleBackColor = true;
            this.mathButton.Click += new System.EventHandler(this.mathButton_Click);
            // 
            // scienceButton
            // 
            this.scienceButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scienceButton.Location = new System.Drawing.Point(243, 73);
            this.scienceButton.Name = "scienceButton";
            this.scienceButton.Size = new System.Drawing.Size(225, 55);
            this.scienceButton.TabIndex = 5;
            this.scienceButton.Text = "Science Questions";
            this.scienceButton.UseVisualStyleBackColor = true;
            this.scienceButton.Click += new System.EventHandler(this.scienceButton_Click);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 263);
            this.Controls.Add(this.scienceButton);
            this.Controls.Add(this.mathButton);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.technologyButton);
            this.Controls.Add(this.studentRecordsButton);
            this.Controls.Add(this.scoreSummaryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination - Admin Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scoreSummaryButton;
        private System.Windows.Forms.Button studentRecordsButton;
        private System.Windows.Forms.Button technologyButton;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button mathButton;
        private System.Windows.Forms.Button scienceButton;
    }
}