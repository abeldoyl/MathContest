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
            AgeTextBox.Text = "";
            GradeTextBox.Text = "";
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            AddRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SummaryButton.Enabled = false;
        }

        private void ExitButton_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
