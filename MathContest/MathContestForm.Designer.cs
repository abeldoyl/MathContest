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
            GradeLabel = new Label();
            GradeTextBox = new TextBox();
            AgeLabel = new Label();
            AgeTextBox = new TextBox();
            MathProblemGroupBox = new GroupBox();
            FirstNumberLabel = new Label();
            textBox3 = new TextBox();
            SecondNumberLabel = new Label();
            SecondNumberTextBox = new TextBox();
            MathTypeGroupBox = new GroupBox();
            StudentAnswerLabel = new Label();
            textBox1 = new TextBox();
            AddRadioButton = new RadioButton();
            SubtractRadioButton = new RadioButton();
            MultiplyRadioButton = new RadioButton();
            DivideRadioButton = new RadioButton();
            StudentInformationGroupBox.SuspendLayout();
            MathProblemGroupBox.SuspendLayout();
            MathTypeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(6, 45);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(180, 23);
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
            StudentInformationGroupBox.Size = new Size(448, 81);
            StudentInformationGroupBox.TabIndex = 2;
            StudentInformationGroupBox.TabStop = false;
            StudentInformationGroupBox.Text = "Student Information";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(350, 27);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(38, 15);
            GradeLabel.TabIndex = 5;
            GradeLabel.Text = "Grade";
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(356, 45);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(23, 23);
            GradeTextBox.TabIndex = 4;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(284, 27);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(28, 15);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Age";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(286, 45);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(23, 23);
            AgeTextBox.TabIndex = 2;
            // 
            // MathProblemGroupBox
            // 
            MathProblemGroupBox.Controls.Add(StudentAnswerLabel);
            MathProblemGroupBox.Controls.Add(textBox1);
            MathProblemGroupBox.Controls.Add(SecondNumberLabel);
            MathProblemGroupBox.Controls.Add(SecondNumberTextBox);
            MathProblemGroupBox.Controls.Add(FirstNumberLabel);
            MathProblemGroupBox.Controls.Add(textBox3);
            MathProblemGroupBox.Location = new Point(12, 133);
            MathProblemGroupBox.Name = "MathProblemGroupBox";
            MathProblemGroupBox.Size = new Size(221, 203);
            MathProblemGroupBox.TabIndex = 6;
            MathProblemGroupBox.TabStop = false;
            MathProblemGroupBox.Text = "Current Math Problem";
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Location = new Point(6, 27);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(76, 15);
            FirstNumberLabel.TabIndex = 1;
            FirstNumberLabel.Text = "First Number";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 0;
            // 
            // SecondNumberLabel
            // 
            SecondNumberLabel.AutoSize = true;
            SecondNumberLabel.Location = new Point(6, 84);
            SecondNumberLabel.Name = "SecondNumberLabel";
            SecondNumberLabel.Size = new Size(93, 15);
            SecondNumberLabel.TabIndex = 3;
            SecondNumberLabel.Text = "Second Number";
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(6, 102);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.Size = new Size(132, 23);
            SecondNumberTextBox.TabIndex = 2;
            // 
            // MathTypeGroupBox
            // 
            MathTypeGroupBox.Controls.Add(DivideRadioButton);
            MathTypeGroupBox.Controls.Add(MultiplyRadioButton);
            MathTypeGroupBox.Controls.Add(SubtractRadioButton);
            MathTypeGroupBox.Controls.Add(AddRadioButton);
            MathTypeGroupBox.Location = new Point(239, 133);
            MathTypeGroupBox.Name = "MathTypeGroupBox";
            MathTypeGroupBox.Size = new Size(221, 203);
            MathTypeGroupBox.TabIndex = 7;
            MathTypeGroupBox.TabStop = false;
            MathTypeGroupBox.Text = "Math Problem Type";
            // 
            // StudentAnswerLabel
            // 
            StudentAnswerLabel.AutoSize = true;
            StudentAnswerLabel.Location = new Point(6, 143);
            StudentAnswerLabel.Name = "StudentAnswerLabel";
            StudentAnswerLabel.Size = new Size(90, 15);
            StudentAnswerLabel.TabIndex = 5;
            StudentAnswerLabel.Text = "Student Answer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 4;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Location = new Point(59, 45);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(47, 19);
            AddRadioButton.TabIndex = 0;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add";
            AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubtractRadioButton
            // 
            SubtractRadioButton.AutoSize = true;
            SubtractRadioButton.Location = new Point(59, 70);
            SubtractRadioButton.Name = "SubtractRadioButton";
            SubtractRadioButton.Size = new Size(69, 19);
            SubtractRadioButton.TabIndex = 1;
            SubtractRadioButton.TabStop = true;
            SubtractRadioButton.Text = "Subtract";
            SubtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            MultiplyRadioButton.AutoSize = true;
            MultiplyRadioButton.Location = new Point(59, 95);
            MultiplyRadioButton.Name = "MultiplyRadioButton";
            MultiplyRadioButton.Size = new Size(69, 19);
            MultiplyRadioButton.TabIndex = 2;
            MultiplyRadioButton.TabStop = true;
            MultiplyRadioButton.Text = "Multiply";
            MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // DivideRadioButton
            // 
            DivideRadioButton.AutoSize = true;
            DivideRadioButton.Location = new Point(59, 120);
            DivideRadioButton.Name = "DivideRadioButton";
            DivideRadioButton.Size = new Size(58, 19);
            DivideRadioButton.TabIndex = 3;
            DivideRadioButton.TabStop = true;
            DivideRadioButton.Text = "Divide";
            DivideRadioButton.UseVisualStyleBackColor = true;
            // 
            // MathContestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MathTypeGroupBox);
            Controls.Add(MathProblemGroupBox);
            Controls.Add(StudentInformationGroupBox);
            Name = "MathContestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Contest";
            StudentInformationGroupBox.ResumeLayout(false);
            StudentInformationGroupBox.PerformLayout();
            MathProblemGroupBox.ResumeLayout(false);
            MathProblemGroupBox.PerformLayout();
            MathTypeGroupBox.ResumeLayout(false);
            MathTypeGroupBox.PerformLayout();
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
        private GroupBox MathProblemGroupBox;
        private Label FirstNumberLabel;
        private TextBox textBox3;
        private Label StudentAnswerLabel;
        private TextBox textBox1;
        private Label SecondNumberLabel;
        private TextBox SecondNumberTextBox;
        private GroupBox MathTypeGroupBox;
        private RadioButton DivideRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton SubtractRadioButton;
        private RadioButton AddRadioButton;
    }
}
