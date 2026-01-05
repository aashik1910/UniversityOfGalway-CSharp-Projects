using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Assignment 1
//Name: Aashik Ahamed Mohamed Ibrahim
//Student ID: 25237259
//This assignement is to design the Neart4U Quote Generator application using C# and Visual Studio
//This application helps to calculate the quote of the purchase of the exercise equipments and gives a summary of all the quotations generated
namespace N4UQuoteGeneratorAashik
{
    public partial class N4UQuoteGenerator : Form
    {
        //declaration of global variables
        decimal TotalCostEllipticals;
        decimal TotalCostThreadMill;
        decimal TotalCostRowingMachine;
        decimal TOtalCostExerciseBikes;
        decimal TotalQuoteCostEllipticals;
        decimal TotalQuoteCostThreadMill;
        decimal TotalQuoteCostRowingMachine;
        decimal TOtalQuoteCostExerciseBikes;

        decimal TotalQuoteValue = 0;
        decimal TotalNoOfQuote = 0;
        decimal TotalCostInstallations = 149;
        decimal TotalInstallationCost = 0;
        decimal TotalSetUpCost = 59.00m;
        decimal PriceOfEllipticals = 1199.00m;
        decimal PriceOfThreadMill = 899.00m;
        decimal PriceOfRowingMachine = 699.00m;
        decimal PriceOfExerciseBikes = 499.00m;
        decimal QuantityOfEllipticals;
        decimal QuantityOfThreadMill;
        decimal QuantityOfRowingMachine;
        decimal QuantityOfExerciseBikes;
        decimal TotalQuantityOfEllipticals;
        decimal TotalQuantityOfThreadMill;
        decimal TotalQuantityOfRowingMachine;
        decimal TotalQuantityOfExerciseBikes;

        public N4UQuoteGenerator()
        {
            InitializeComponent();
        }

        private void N4UQuoteGenerator_Load(object sender, EventArgs e)
        {
            //Hide the quote page related contents to allow user to enter the rep id and quote id
            SplitLineGroupBox.Visible = false;
            EquipmentQuoteGroupBox.Visible = false;
            QuoteSummaryGroupBox.Visible = false;
            QuoteClearSummaryExitPictureBox.Visible = false;
            SummaryButton.Visible = false;
            ExitButton.Visible = false;
            ClearButton.Visible = false;
            QuoteButton.Visible = false;
            QuotePageLogoPictureBox.Visible = false;
            //Enter Tool Tip
            EnterToolTip.SetToolTip(EnterButton, "Press to enter the Quote Page");
            
        }
        private void EnterButton_Click_1(object sender, EventArgs e)
        {
            //Store the input values of Sales Rep Name and Quote Id
            string salesRepName = SalesRepTextBox.Text;
            string quoteIdNumber = QuoteIdTextBox.Text;
            
            EnterButton.Enabled = true;

            //Change the name of the form as per Sales Rep ID and Quote ID
            this.Text = "Sales Rep: " + salesRepName + " Quote ID: " + quoteIdNumber;

            //Hide elements from Home Page after clicking on submit button
            SalesRepGroupBox.Visible = false;
            HomePageLogoPictureBox.Visible = false;

            //Show the elements from the Quote Page after clicking on submit button
            EquipmentQuoteGroupBox.Visible = true;
            SummaryButton.Visible = true;
            ExitButton.Visible = true;
            ClearButton.Visible = true;
            QuoteButton.Visible = true;

            //Tool Tip of Quote, Clear, Summary and Exit 
            QuoteToolTip.SetToolTip(QuoteButton, "Press to get the Quote");
            ClearToolTip.SetToolTip(ClearButton, "Press to clear the Quote Page");
            SummaryToolTip.SetToolTip(SummaryButton, "Press to get the Quote Summary");
            ExitToolTip.SetToolTip(ExitButton, "Press to exit the application");

            //Make the Quote page related elements 
            QuotePageLogoPictureBox.Visible = true;
            QuoteClearSummaryExitPictureBox.Visible = true;
        }
        private void QuoteButton_Click(object sender, EventArgs e)
        {
            QuoteButton.Enabled = true;

            //Change the Quote Summary Group Box
            QuoteSummaryGroupBox.Text = "Quote Summary";

            //Try Catch block to handle Ellipticals Text Box Quantity and Cost
            try
            {
                QuantityOfEllipticals = int.Parse(NoOfEllipticalsTextBox.Text);
                TotalCostEllipticals = QuantityOfEllipticals * PriceOfEllipticals;
                CostEllipticalsTextBox.Text = TotalCostEllipticals.ToString("C2");
                TotalQuantityOfEllipticals += QuantityOfEllipticals;
            }
            catch
            {
                MessageBox.Show("Please Enter Numerical Data for Ellipticals", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NoOfEllipticalsTextBox.Focus();
                return;
            }
            //Try Catch block to handle ThreadMills Text Box Quantity and Cost
            try
            {
                QuantityOfThreadMill = int.Parse(NoOfThreadMillsTextBox.Text);
                TotalCostThreadMill = QuantityOfThreadMill * PriceOfThreadMill;
                CostThreadMillsTextBox.Text = TotalCostThreadMill.ToString("C2");
                TotalQuantityOfThreadMill += QuantityOfThreadMill;
            }
            catch
            {
                MessageBox.Show("Please Enter Numerical Data for ThreadMills", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NoOfThreadMillsTextBox.Focus();
                return;
            }
            //Try Catch block to handle Rowing Machine Text Box Quantity and Cost
            try
            {
                QuantityOfRowingMachine = int.Parse(NoOfRowingMachinesTextBox.Text);
                TotalCostRowingMachine = QuantityOfRowingMachine * PriceOfRowingMachine;
                CostRowingMachineTextBox.Text = TotalCostRowingMachine.ToString("C");
                TotalQuantityOfRowingMachine += QuantityOfRowingMachine;
            }
            catch
            {
                MessageBox.Show("Please Enter Numerical Data for Rowing Machines", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NoOfRowingMachinesTextBox.Focus();
                return;
            }
            //Try Catch block to handle Exercise Bikes Text Box Quantity and Cost
            try
            {
                QuantityOfExerciseBikes = int.Parse(NoOfExerciseBikesTextBox.Text);
                TOtalCostExerciseBikes = QuantityOfExerciseBikes * PriceOfExerciseBikes;
                CostExerciseBikeTextBox.Text = TOtalCostExerciseBikes.ToString("C2");
                TotalQuantityOfExerciseBikes += QuantityOfExerciseBikes;
            }
            catch
            {
                MessageBox.Show("Please Enter Numerical Data for ExerciseBikes", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NoOfExerciseBikesTextBox.Focus();
                return;
            }
            //Hide the elements in the quote summary page accordingly
            QuoteSummaryGroupBox.Visible = true;
            TotalNoOfQuotesTextBox.Visible = false;
            TotalNoOfQuotesLabel.Visible = false;
            SplitLineGroupBox.Visible = true;
            TotalQuoteValueLabel.Visible = true;
            TotalQuoteValueTextBox.Visible = true;
            AverageQuoteValueLabel.Visible = false;
            AverageQuoteValueTextBox.Visible = false;
            NetCostSetupLabel.Visible = false;
            NetCostSetupTextBox.Visible = false;
            
            //Calculation of Total Quote value
            CostInstallationTextBox.Text = TotalCostInstallations.ToString("C2");
            TotalQuoteValue = TotalCostEllipticals + TotalCostThreadMill + TotalCostRowingMachine + TOtalCostExerciseBikes + TotalCostInstallations;
            TotalQuoteValueTextBox.Text = TotalQuoteValue.ToString("C2");

            //Iterate Total No of Quote whenever quote button is clicked
            TotalNoOfQuote++;

            //Add the number of equipments each time quote is clicked for summary
            TotalQuoteCostEllipticals += TotalCostEllipticals;
            TotalQuoteCostThreadMill += TotalCostThreadMill;
            TotalQuoteCostRowingMachine += TotalCostRowingMachine;
            TOtalQuoteCostExerciseBikes += TOtalCostExerciseBikes;
            TotalInstallationCost += TotalCostInstallations;

            //Calculation of equipment's percentage with total cost
            try
            {
                decimal EllipticalsPercentage = TotalCostEllipticals/TotalQuoteValue;
                CostEllipticalsPercentageBox.Text = EllipticalsPercentage.ToString("P2");

                decimal ThreadMillPercentage = TotalCostThreadMill/TotalQuoteValue;
                CostThreadMillsPercentageBox.Text = ThreadMillPercentage.ToString("P2");

                decimal RowingMachinePercentage = TotalCostRowingMachine/TotalQuoteValue;
                CostRowingMachinePercentageBox.Text = RowingMachinePercentage.ToString("P2");

                decimal ExerciseBikePercentage = TOtalCostExerciseBikes/TotalQuoteValue;
                CostExerciseBikePercentageBox.Text = ExerciseBikePercentage.ToString("P2");

                decimal IntallationPercentage = TotalCostInstallations / TotalQuoteValue;
                CostInstallationPercentageBox.Text = IntallationPercentage.ToString("P2");
            }
            catch
            {
                MessageBox.Show("Please Enter Numerical Data Only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SummaryButton.Enabled = true;

            //Change the name of the quote summary page
            QuoteSummaryGroupBox.Text = "Total Quote Summary";

            //Change the name of the form once summary is clicked
            this.Text = "Neart4U Quote Summary Data";

            //Change the visibility of the elements accordingly
            CostEllipticalsPercentageBox.Visible = false;
            CostRowingMachinePercentageBox.Visible=false;
            CostThreadMillsPercentageBox.Visible= false;
            CostExerciseBikePercentageBox.Visible = false;
            CostInstallationPercentageBox.Visible=false;
            EquipmentQuoteGroupBox.Visible = false;

            AverageQuoteValueLabel.Visible = true;
            AverageQuoteValueTextBox.Visible = true;
            TotalQuoteValueLabel.Visible = true;
            TotalQuoteValueTextBox.Visible = true;
            TotalNoOfQuotesLabel.Visible = true;
            TotalNoOfQuotesTextBox.Visible = true;
            NetCostSetupLabel.Visible = true;
            NetCostSetupTextBox.Visible = true;

            //Calculate the total cost to display in summary page
            CostEllipticalsTextBox.Text = TotalQuoteCostEllipticals.ToString("C2");
            CostThreadMillsTextBox.Text = TotalQuoteCostThreadMill.ToString("C2");
            CostRowingMachineTextBox.Text = TotalQuoteCostRowingMachine.ToString("C2");
            CostExerciseBikeTextBox.Text = TOtalQuoteCostExerciseBikes.ToString("C2");

            CostInstallationTextBox.Text = TotalInstallationCost.ToString("C2");

            //Display the Total number of quote
            TotalNoOfQuotesTextBox.Text = TotalNoOfQuote.ToString();
            decimal AverageQuoteValue = TotalQuoteValue / TotalNoOfQuote;
            AverageQuoteValueTextBox.Text = AverageQuoteValue.ToString("C2");

            //Calculate the total number of items for summary
            decimal TotalNoOfItems = TotalQuantityOfEllipticals + TotalQuantityOfThreadMill + TotalQuantityOfRowingMachine + TotalQuantityOfExerciseBikes;

            //Calcuate the actual Setup cost for the net set up cost
            decimal ActualSetupCost = TotalNoOfItems * TotalSetUpCost;

            //Calcuate and display the net setup cost
            decimal NetSetupCost = TotalInstallationCost - ActualSetupCost;
            NetCostSetupTextBox.Text = NetSetupCost.ToString("C2");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearButton.Enabled = true;
            //Make sure to hide and clear the values once clear button is clicked
            SplitLineGroupBox.Visible = false;
            EquipmentQuoteGroupBox.Visible = false;
            QuoteSummaryGroupBox.Visible = false;
            QuoteClearSummaryExitPictureBox.Visible = false;
            SummaryButton.Visible = false;
            ExitButton.Visible = false;
            ClearButton.Visible = false;
            QuoteButton.Visible = false;
            QuotePageLogoPictureBox.Visible = false;

            NoOfEllipticalsTextBox.Text = "";
            NoOfThreadMillsTextBox.Text = "";
            NoOfRowingMachinesTextBox.Text = "";
            NoOfExerciseBikesTextBox.Text = "";

            SalesRepGroupBox.Visible = true;
            HomePageLogoPictureBox.Visible = true;

            //Change the name of the quote generator form once clear button is clicked

            this.Text = "N4U Quote Generator";

            //Clear the sales rep and quote id text
            SalesRepTextBox.Text = "";
            QuoteIdTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //CLose the form completely upon clicking on the exit button
            this.Close();
        }

        
    }
}
