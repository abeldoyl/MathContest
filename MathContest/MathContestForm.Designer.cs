namespace MathContest
{
    partial class MathContestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameTextBox = new TextBox();
            NameLabel = new Label();
            StudentInformationGroupBox = new GroupBox();
            AgeLabel = new Label();
            AgeTextBox = new TextBox();
            GradeLabel = new Label();
            GradeTextBox = new TextBox();
            StudentInformationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(6, 45);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(132, 23);
            NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 27);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // StudentInformationGroupBox
            // 
            StudentInformationGroupBox.Controls.Add(GradeLabel);
            StudentInformationGroupBox.Controls.Add(GradeTextBox);
            StudentInformationGroupBox.Controls.Add(AgeLabel);
            StudentInformationGroupBox.Controls.Add(AgeTextBox);
            StudentInformationGroupBox.Controls.Add(NameLabel);
            StudentInformationGroupBox.Controls.Add(NameTextBox);
            StudentInformationGroupBox.Location = new Point(12, 35);
            StudentInformationGroupBox.Name = "StudentInformationGroupBox";
            StudentInformationGroupBox.Size = new Size(323, 81);
            StudentInformationGroupBox.TabIndex = 2;
            StudentInformationGroupBox.TabStop = false;
            StudentInformationGroupBox.Text = "Student Information";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(198, 27);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(28, 15);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Age";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(198, 45);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(23, 23);
            AgeTextBox.TabIndex = 2;
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(256, 27);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(38, 15);
            GradeLabel.TabIndex = 5;
            GradeLabel.Text = "Grade";
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(256, 45);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(23, 23);
            GradeTextBox.TabIndex = 4;
            // 
            // MathContestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentInformationGroupBox);
            Name = "MathContestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Contest";
            StudentInformationGroupBox.ResumeLayout(false);
            StudentInformationGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameTextBox;
        private Label NameLabel;
        private GroupBox StudentInformationGroupBox;
        private Label AgeLabel;
        private TextBox AgeTextBox;
        private Label GradeLabel;
        private TextBox GradeTextBox;
    }
}
