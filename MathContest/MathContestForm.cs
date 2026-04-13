/*
Abel Doyle
RCET 2265
Spring Semester 2026
MathContest
https://github.com/abeldoyl/MathContest.git
*/
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MathContest
{
    public partial class MathContestForm : Form
    {
        public MathContestForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        int submitNumber = 0;
        int correctAnswers = 0;
        int correctNumber = 0;
        //Custom Methods Below-----------------------------------------------------------
        void SetDefaults()
        {
            submitNumber = 0;
            correctAnswers = 0;
            correctNumber = 0;
            NameTextBox.Text = "";
            NameTextBox.BackColor = Color.LightYellow;
            AgeTextBox.Text = "";
            AgeTextBox.BackColor = Color.LightYellow;
            GradeTextBox.Text = "";
            GradeTextBox.BackColor = Color.LightYellow;
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            AddRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
            RandomNumberGenerator();
            MathProblemGroupBox.Enabled = false;
        }

        //This method validates our Math Contest form with four fields and
        //enables/disables different feilds based on the results.
        //What it validates:
        //Name — must not be empty.
        //Age — must be a valid integer between 7 and 11.
        //Grade — must be a valid integer between 1 and 4.
        //Student Answer — must not be empty
        void ValidateFields()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(NameTextBox.Text.Trim()))
            {
                valid = false;
                NameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }
            int age;
            if (!int.TryParse(AgeTextBox.Text.Trim(), out age) || age < 7 || age > 11)
            {
                valid = false;
                AgeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                AgeTextBox.BackColor = Color.White;
            }
            int grade;
            if (!int.TryParse(GradeTextBox.Text.Trim(), out grade) || grade < 1 || grade > 4)
            {
                valid = false;
                GradeTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                GradeTextBox.BackColor = Color.White;
            }
            if (StudentAnswerTextBox.Enabled)
            {
                if (StudentAnswerTextBox.Text != "")
                {
                    StudentAnswerTextBox.BackColor = Color.White;
                }
                else
                {
                    valid = false;
                    StudentAnswerTextBox.BackColor = Color.LightYellow;
                }
            }

            if (valid)
            {
                if (!MathProblemGroupBox.Enabled)
                {
                    MathProblemGroupBox.Enabled = true;
                    StudentAnswerTextBox.Enabled = true;
                    StudentAnswerLabel.Enabled = true;
                    SubmitButton.Enabled = true;
                    MathProblems();
                }
            }
        }
        //Creates random numbers for math problems
        private void RandomNumberGenerator()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 21);
            FirstNumberTextBox.Text = firstNumber.ToString();
            int secondNumber = random.Next(1, 21);
            SecondNumberTextBox.Text = secondNumber.ToString();
        }
        //Does the math for the created random numbers to compare to student answer later
        void MathProblems()
        {
            int firsNumber = int.Parse(FirstNumberTextBox.Text);
            int secondNumber = int.Parse(SecondNumberTextBox.Text);
            if (AddRadioButton.Checked)
            {
                correctNumber = firsNumber + secondNumber;
            }
            else if (SubtractRadioButton.Checked)
            {
                correctNumber = firsNumber - secondNumber;
            }
            else if (MultiplyRadioButton.Checked)
            {
                correctNumber = firsNumber * secondNumber;
            }
            else if (DivideRadioButton.Checked)
            {
                correctNumber = firsNumber / secondNumber;
            }
        }

        //Event Handlers Below-----------------------------------------------------------
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                ValidateFields();
            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                ValidateFields();
            }
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (submitNumber >= 1)
            {
                SetDefaults();
            }
            else
            {
                ValidateFields();
            }
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MathProblems();
            try
            {
                int.Parse(StudentAnswerTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid answer.");
                return;
            }
            if (int.Parse(StudentAnswerTextBox.Text) == correctNumber)
            {
                MessageBox.Show("Your answer is correct.");
                correctAnswers++;
            }
            else
            {
                MessageBox.Show($"Tthe correct answer is {correctNumber}.");
            }
            StudentAnswerTextBox.Text = "";
            RandomNumberGenerator();
            SummaryButton.Enabled = true;
            submitNumber++;
            StudentAnswerTextBox.Focus();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Out of {submitNumber} problems you answered {correctAnswers} problems correctly");
            StudentAnswerTextBox.Focus();
        }
    }
}
