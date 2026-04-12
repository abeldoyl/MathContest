/*
Abel Doyle
RCET 2265
Spring Semester 2026
MathContest
https://github.com/abeldoyl/MathContest.git
*/
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
        
        void SetDefaults()
        {
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
        }

        private bool ValidateFields()
        {
            bool valid = true;
            if (NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.White;
            }
            else
            {
                NameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            try
            {
                if (int.Parse(AgeTextBox.Text) >= 7 && int.Parse(AgeTextBox.Text) <= 11)
                {
                    AgeTextBox.BackColor = Color.White;
                }
                else
                {
                    AgeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                AgeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            try
            {
                if (int.Parse(GradeTextBox.Text) >= 1 && int.Parse(GradeTextBox.Text) <= 4)
                {
                    GradeTextBox.BackColor = Color.White;
                }
                else
                {
                    GradeTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                GradeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            if (StudentAnswerTextBox.Text != "")
            {
                StudentAnswerTextBox.BackColor = Color.White;
            }
            else
            {
                StudentAnswerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            return valid;
        }

        private void SubmitButtonEnable()
        {
            if (ValidateFields())
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }
        private void RandomNumberGenerator()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 20);
            FirstNumberTextBox.Text = firstNumber.ToString();
            int secondNumber = random.Next(1, 20);
            SecondNumberTextBox.Text = secondNumber.ToString();
        }
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
                SubmitButtonEnable();
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
                SubmitButtonEnable();
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
                SubmitButtonEnable();
            }
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonEnable();
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
