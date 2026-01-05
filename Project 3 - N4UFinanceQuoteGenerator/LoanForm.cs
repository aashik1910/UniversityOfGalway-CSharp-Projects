using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;
using System.Text;

namespace Finance_Form
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        public DateTime CurrentDate = DateTime.Now;

        //Values declared for the loan calulation
        const decimal INTEREST_ONEYEAR_BELOW_FIVETHOUSAND = 9.45m,
                INTEREST_THREEYEAR_BELOW_FIVETHOUSAND = 8.85m,
                INTEREST_FIVEYEAR_BELOW_FIVETHOUSAND = 7.25m,
                INTEREST_ONEYEAR_ABOVE_FIVETHOUSAND = 8.85m,
                INTEREST_THREEYEAR_ABOVE_FIVETHOUSAND = 7.75m,
                INTEREST_FIVEYEAR_ABOVE_FIVETHOUSAND = 6.85m,
                INTEREST_ONEYEAR_ABOVE_TWENTYFIVETHOUSAND = 7.85m,
                INTEREST_THREEYEAR_ABOVE_TWENTYFIVETHOUSAND = 6.65m,
                INTEREST_FIVEYEAR_ABOVE_TWENTYFIVETHOUSAND = 5.65m,
                NO_LOAN_RATE = 0m;

        decimal PrincipalAmount = 0m, TotalInterest = 0m, TotalPayment = 0m, MonthlyPayment = 0m, AnnualRateToDisplay;

        private void LoanForm_Load(object sender, EventArgs e)
        {
            //Making sure for keeping the radio buttons unclicked before staring
            RadioButtonOneYear.Checked = false;
            RadioButtonThreeYear.Checked = false;
            RadioButtonFiveYear.Checked = false;
            NoLoanRadioButton.Checked = false;

            //For keeping radio button unchecked 
            RadioButtonOneYear.AutoCheck = true;
            RadioButtonThreeYear.AutoCheck = true;
            RadioButtonFiveYear.AutoCheck = true;
            NoLoanRadioButton.AutoCheck = true;

            //Getting Customer Details from quote form 
            TransactionIdDetailTextBox.Text = QuoteForm.TransactionId;
            DateDetailTextBox.Text = CurrentDate.ToShortDateString();
            ClientNameDetailTextBox.Text = QuoteForm.ClientName;
            EircodeDetailTextBox.Text = QuoteForm.Eircode;
            PhoneNumberDetailTextBox.Text = QuoteForm.PhoneNumber;
            EmailAddressDetailTextBox.Text = QuoteForm.EmailAddress;

            //Getting Order details from quote form
            EquipmentBox.Text = QuoteForm.Equipment;
            BrandBox.Text = QuoteForm.Brand;
            QuantityBox.Text = QuoteForm.Quantity.ToString();
            WarrantyBox.Text = QuoteForm.WarrentyYears;
            InstallationBox.Text = QuoteForm.InstallationType;
            TotalCostTextBox.Text = QuoteForm.TotalQuoteValue.ToString("C2");
        }

        private void LoanDetails()
        {
            //Declaring the conditions and the inputs for the loan calculation
            decimal OneYearRate = 0, ThreeYearRate = 0, FiveYearRate = 0, NoLoanRate = 0;
            const int ONEYEAR = 1, THREEYEAR = 3, FIVEYEAR = 5, NOLOAN = 0;
            PrincipalAmount = QuoteForm.TotalQuoteValue;

            //Conditions to handle the catagory of amount against the rate of interest 
            if (PrincipalAmount < 5000)
            {
                OneYearRate = INTEREST_ONEYEAR_BELOW_FIVETHOUSAND;
                ThreeYearRate = INTEREST_THREEYEAR_BELOW_FIVETHOUSAND;
                FiveYearRate = INTEREST_FIVEYEAR_BELOW_FIVETHOUSAND;
                NoLoanRate = NO_LOAN_RATE;
            }
            else if (PrincipalAmount > 5000 && PrincipalAmount <= 25000)
            {
                OneYearRate = INTEREST_ONEYEAR_ABOVE_FIVETHOUSAND;
                ThreeYearRate = INTEREST_THREEYEAR_ABOVE_FIVETHOUSAND;
                FiveYearRate = INTEREST_FIVEYEAR_ABOVE_FIVETHOUSAND;
                NoLoanRate = NO_LOAN_RATE;
            }
            else if (PrincipalAmount > 25000)
            {
                OneYearRate = INTEREST_ONEYEAR_ABOVE_TWENTYFIVETHOUSAND;
                ThreeYearRate = INTEREST_THREEYEAR_ABOVE_TWENTYFIVETHOUSAND;
                FiveYearRate = INTEREST_FIVEYEAR_ABOVE_TWENTYFIVETHOUSAND;
                NoLoanRate = NO_LOAN_RATE;
            }

            //Calling the methods to calculate based on the radio button checked
            if (RadioButtonOneYear.Checked)
            {
                DisplayLoanDetails(PrincipalAmount, ONEYEAR, OneYearRate);
            }
            else if (RadioButtonThreeYear.Checked)
            {
                DisplayLoanDetails(PrincipalAmount, THREEYEAR, ThreeYearRate);
            }
            else if (RadioButtonFiveYear.Checked)
            {
                DisplayLoanDetails(PrincipalAmount, FIVEYEAR, FiveYearRate);
            }
            else if (NoLoanRadioButton.Checked)
            {
                DisplayLoanDetails(PrincipalAmount, NOLOAN, NoLoanRate);
            }

        }
        //Calculation of Loan amount according to rate of interest and year
        private void DisplayLoanDetails(decimal PrincipalAmount, int Years, decimal AnnualRate)
        {
            if (AnnualRate == 0)
            {
                LoanOutputLabel.Text = "No loan required.";
                return;
            }

            //declaring variables for calculation
            int totalMonths = Years * 12;
            decimal monthlyRate = AnnualRate / 100 / 12;

            TotalPayment = PrincipalAmount;

            // Calculation of compound interest
            for (int i = 0; i < totalMonths; i++)
            {
                TotalPayment += TotalPayment * monthlyRate;
            }

            TotalInterest = TotalPayment - PrincipalAmount;
            MonthlyPayment = TotalPayment / totalMonths;

            AnnualRateToDisplay = AnnualRate / 100;
            //Displaying the details back to the radio button
            LoanOutputLabel.Text =
                "Total Years: " + Years.ToString() +
                "\n" + "Total Payment: " + TotalPayment.ToString("C2") +
                "\n" + "Total Interest: " + TotalInterest.ToString("C2") +
                "\n" + "Monthly Payment: " + MonthlyPayment.ToString("C2") +
                "\n" + "Annual Rate of Interest: " + AnnualRateToDisplay.ToString("P");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            //Validation if no radio button is selected submit is disabled
            if (!RadioButtonOneYear.Checked && !RadioButtonThreeYear.Checked && !RadioButtonFiveYear.Checked && !NoLoanRadioButton.Checked)
            {
                ErrorMessageLabel.ForeColor = Color.Red;
                ErrorMessageLabel.Text = "Please select loan option to submit the order";
            }
            else
            {
                ErrorMessageLabel.ForeColor = Color.Green;
                ErrorMessageLabel.Text = "Order is placed successfully!!!";
                Application.Exit();
            }

            //write the details in the txt file  
            try
            {
                string FilePath = "LoanDetails.txt";
                string TransactionDetails =
                    QuoteForm.TransactionId +
                    "\n" + CurrentDate.ToShortDateString() +
                    "\n" + QuoteForm.ClientName +
                    "\n" + QuoteForm.Eircode +
                    "\n" + QuoteForm.PhoneNumber +
                    "\n" + QuoteForm.EmailAddress +
                    "\n" + QuoteForm.Equipment +
                    "\n" + QuoteForm.Brand +
                    "\n" + QuoteForm.Quantity +
                    "\n" + QuoteForm.WarrentyYears +
                    "\n" + QuoteForm.InstallationType +
                    "\n" + PrincipalAmount.ToString("C2") +
                    "\n" + TotalPayment.ToString("C2") +
                    "\n" + TotalInterest.ToString("C2") +
                    "\n" + MonthlyPayment.ToString("C2") +
                    "\n" + AnnualRateToDisplay.ToString("P") +
                    "\n";

                //Append the upcoming transactiond details in the same
                File.AppendAllText(FilePath, TransactionDetails);
            }
            catch
            {
                MessageBox.Show("File not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Handling the radio buttons differently to make sure changes are displayed accordingly
        private void RadioButtonOneYear_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonOneYear.Checked)
                LoanDetails();
        }

        private void RadioButtonThreeYear_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonThreeYear.Checked)
                LoanDetails();
        }

        private void RadioButtonFiveYear_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonFiveYear.Checked)
                LoanDetails();
        }

        private void NoLoanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoLoanRadioButton.Checked)
                LoanDetails();
        }
        //Closing the complete application once close button is clicked
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Back button will take the user back to the quote form to genenrate the quote
        private void BackButton_Click(object sender, EventArgs e)
        {
            QuoteForm BackToQuote = new QuoteForm();
            BackToQuote.ShowDialog();
            this.Hide();
        }
    }
}
