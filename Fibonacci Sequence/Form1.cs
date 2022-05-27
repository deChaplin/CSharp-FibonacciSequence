namespace Fibonacci_Sequence
{
    public partial class Form1 : Form
    {
        int firstNo = 0;
        int secondNo = 1;
        int nextNo = 0;

        int numberWanted = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Checks input is an integer
            int test;
            if (!Int32.TryParse(txtElements.Text, out test))
            {
                MessageBox.Show("Must be an integer");
                txtElements.Text = "";
                return;
            }

            numberWanted = int.Parse(txtElements.Text); // converts textbox to integer

            if (numberWanted < 2)
            {
                MessageBox.Show("Please enter a number more than two");
                txtElements.Text = "";
                numberWanted = 0;
                return;
            }

            btnStart.Enabled = false;
            txtElements.Enabled = false;

            lblSeq.Text = firstNo.ToString() + ", " + secondNo.ToString();

            // Calculation
            for (int i = 2; i < numberWanted; i++)
            {
                nextNo = firstNo + secondNo;

                lblSeq.Text = lblSeq.Text + ", " + nextNo.ToString();

                firstNo = secondNo;
                secondNo = nextNo;
            }

        }
    }
}