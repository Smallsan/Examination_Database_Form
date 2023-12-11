namespace ExaminationApplication
{
    partial class Result
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.mathLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scienceLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.technologyLabel = new System.Windows.Forms.Label();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.marksLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(235, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 47);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Results";
            // 
            // mathLabel
            // 
            this.mathLabel.AutoSize = true;
            this.mathLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathLabel.Location = new System.Drawing.Point(21, 60);
            this.mathLabel.Name = "mathLabel";
            this.mathLabel.Size = new System.Drawing.Size(190, 32);
            this.mathLabel.TabIndex = 1;
            this.mathLabel.Text = "Math Score: N/A";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.percentLabel);
            this.panel1.Controls.Add(this.marksLabel);
            this.panel1.Controls.Add(this.totalScoreLabel);
            this.panel1.Controls.Add(this.technologyLabel);
            this.panel1.Controls.Add(this.englishLabel);
            this.panel1.Controls.Add(this.scienceLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.mathLabel);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 293);
            this.panel1.TabIndex = 3;
            // 
            // scienceLabel
            // 
            this.scienceLabel.AutoSize = true;
            this.scienceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scienceLabel.Location = new System.Drawing.Point(21, 102);
            this.scienceLabel.Name = "scienceLabel";
            this.scienceLabel.Size = new System.Drawing.Size(215, 32);
            this.scienceLabel.TabIndex = 2;
            this.scienceLabel.Text = "Science Score: N/A";
            this.scienceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishLabel.Location = new System.Drawing.Point(21, 145);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(210, 32);
            this.englishLabel.TabIndex = 3;
            this.englishLabel.Text = "English Score: N/A";
            // 
            // technologyLabel
            // 
            this.technologyLabel.AutoSize = true;
            this.technologyLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technologyLabel.Location = new System.Drawing.Point(21, 190);
            this.technologyLabel.Name = "technologyLabel";
            this.technologyLabel.Size = new System.Drawing.Size(257, 32);
            this.technologyLabel.TabIndex = 4;
            this.technologyLabel.Text = "Technology Score: N/A";
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.AutoSize = true;
            this.totalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLabel.Location = new System.Drawing.Point(21, 235);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(185, 32);
            this.totalScoreLabel.TabIndex = 5;
            this.totalScoreLabel.Text = "Total Score: N/A";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(501, 315);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(130, 35);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next Subject";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksLabel.Location = new System.Drawing.Point(417, 77);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(161, 32);
            this.marksLabel.TabIndex = 6;
            this.marksLabel.Text = "Marks: Passed";
            this.marksLabel.Visible = false;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.Location = new System.Drawing.Point(468, 119);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(60, 32);
            this.percentLabel.TabIndex = 7;
            this.percentLabel.Text = "75%";
            this.percentLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(265, 315);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(130, 35);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back To Title";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 357);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination - Results";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label mathLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label technologyLabel;
        private System.Windows.Forms.Label scienceLabel;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.Button backButton;
    }
}