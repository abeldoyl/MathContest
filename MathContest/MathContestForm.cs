namespace MathContest
{
    public partial class MathContestForm : Form
    {
        public MathContestForm()
        {
            InitializeComponent();
            SetDefaults();
        }

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
                    AgeTextBox.BackColor= Color.White;
                }
                else
                {
                    AgeTextBox.BackColor = Color.LightYellow;
                    valid= false;
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

        private void ExitButton_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click (object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonEnable();
            
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonEnable();
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonEnable();
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonEnable();
        }
    }
}
