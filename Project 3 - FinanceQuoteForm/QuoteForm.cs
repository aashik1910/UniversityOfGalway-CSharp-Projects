//Assignment 2
//Name: Aashik Ahamed Mohamed Ibrahim
//Student ID: 25237259
//This assignement is to design the Sales Quote Generator application using C# and Visual Studio
//This application helps to calculate the Quote and Summary of the purchase of the exercise equipments with corresponding brand
//and gives warrenty, expedite installation and discount on request basis

using FinanceQuoteForm;
using System.Transactions;

namespace Finance_Form
{
    public partial class QuoteForm : Form
    {
        public QuoteForm()
        {
            InitializeComponent();
        }

        //Declaring contstant variables for the Equipment list box
        const String ELLIPTICAL = "Elliptical", THREADMILL = "Threadmill", EXERCISEBIKE = "ExerciseBike",
            ROWINGMACHINE = "RowingMachine", STAIRCLIMBER = "StairClimber";
        const decimal ELLIPTICALCOST = 1199m, THREADMILLCOST = 899m, EXERCISEBIKECOST = 499m,
            ROWINGMACHINECOST = 699m, STAIRCLIMBERCOST = 799m;

        //Declaring variables for the brand list box
        const string OWNBRAND = "OwnBrand", TECHNOGYM = "TechnoGym", PROFORM = "Proform",
            NORDICTRACK = "NordicTrack", PELOTON = "Peloton";
        const decimal OWNBRANDDISCOUNT = -0.20m, TECHNOGYMDISCOUNT = -0.10m, PROFORMDISCOUNT = 0,
            NORDICTRACKDISCOUNT = 0.15m, PELOTONDISCOUNT = 0.25m;

        //Declaring variables for Service Warranty
        const decimal ONEYEARWARRANTY = 0.15m, THREEYEARWARRANTY = 0.25m, FIVEYEARWARRANTY = 0.30m, NOWARRANTY = 0;

        //Declaring varible for installation
        const decimal BASICINSTALL = 149m, EXPEDITEDINSTALLATION = 99m;
        const decimal FINALDISCOUNT = 0.075m, NODISCOUNT = 0m;
        const int DISCOUNTELIGIBLEQUANTITY = 4;
        //Declaring variables to use while executing the application
        int Warrenty = 0, QuantityEntered;
        decimal FinalDiscountValue, BrandQuantityCost, WarrentyValue, ServiceWarrenty, InstallationCost;

        //Values for client form

        public static string TransactionId { get; private set; } = "";

        public static string ClientName { get; private set; } = "";

        public static string Eircode { get; private set; } = "";

        public static string PhoneNumber { get; private set; } = "";
        public static string EmailAddress { get; private set; } = "";

        public DateTime CurrentDate = DateTime.Now;

        public static int Quantity { get; private set; }
        public static string Equipment { get; private set; } = "";
        public static string Brand { get; private set; } = "";
        public static string InstallationType { get; private set; } = "";
        public static string WarrentyYears { get; private set; } = "";
        public static decimal TotalQuoteValue { get; private set; }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.Text = "Sales Quote Calculator";
            EquipmentListBox.Focus();
            BrandListBox.Focus();
            OrderButton.Enabled = false;
            ClientInputGroupBox.Visible = false;

            //Clear all the selected values to default in case anything selected
            EquipmentListBox.ClearSelected();
            BrandListBox.ClearSelected();
            QuantityTextBox.Clear();
            Year1RadioButton.Checked = false;
            Year3RadioButton.Checked = false;
            Year5RadioButton.Checked = false;
            NoWarrantyButton.Checked = false;

            ExpeditedInstallCheckBox.Checked = false;
            OutputLabel.Text = "";

        }
        private void QuoteButton_Click(object sender, EventArgs e)
        {
            this.Text = "Quote Generation";
            //Declaring variables for handling the Equipments and Brands
            int EquipmentIndex, BrandIndex;
            decimal EquipmentCost = 0, BrandDiscount = 0, BrandCostWithWarrenty = 0;

            FinalDiscountValue = 0;
            //Try catch to handle any exceptions caused during run time
            try
            {
                //if condition for handling equipments
                if (EquipmentListBox.SelectedIndex != -1)
                {
                    //if condition for handling equipments
                    if (BrandListBox.SelectedIndex != -1)
                    {
                        //if condition to handlt quantity and also to get input from user
                        if (int.TryParse(QuantityTextBox.Text, out QuantityEntered) && QuantityEntered > 0)
                        {
                            Quantity = QuantityEntered;
                            EquipmentIndex = EquipmentListBox.SelectedIndex;
                            BrandIndex = BrandListBox.SelectedIndex;
                            //Switch case to handle the selection of equipments
                            switch (EquipmentIndex)
                            {
                                case 0: Equipment = ELLIPTICAL; EquipmentCost = ELLIPTICALCOST; break;
                                case 1: Equipment = THREADMILL; EquipmentCost = THREADMILLCOST; break;
                                case 2: Equipment = EXERCISEBIKE; EquipmentCost = EXERCISEBIKECOST; break;
                                case 3: Equipment = ROWINGMACHINE; EquipmentCost = ROWINGMACHINECOST; break;
                                case 4: Equipment = STAIRCLIMBER; EquipmentCost = STAIRCLIMBERCOST; break;
                            }
                            //Switch case to handle the selection of brand
                            switch (BrandIndex)
                            {
                                case 0: Brand = OWNBRAND; BrandDiscount = OWNBRANDDISCOUNT; break;
                                case 1: Brand = TECHNOGYM; BrandDiscount = TECHNOGYMDISCOUNT; break;
                                case 2: Brand = PROFORM; BrandDiscount = PROFORMDISCOUNT; break;
                                case 3: Brand = NORDICTRACK; BrandDiscount = NORDICTRACKDISCOUNT; break;
                                case 4: Brand = PELOTON; BrandDiscount = PELOTONDISCOUNT; break;
                            }
                            //Calculate the Equipment cost along with quantity as these are the mandatory fields
                            BrandQuantityCost = (EquipmentCost + (EquipmentCost * BrandDiscount)) * Quantity;

                            //Ifelse to handle radio button selection
                            if (Year1RadioButton.Checked)
                            {
                                Warrenty = 1;
                                WarrentyYears = "1 Year";
                                ServiceWarrenty = ONEYEARWARRANTY;
                                WarrentyValue = ServiceWarrenty * BrandQuantityCost;
                            }
                            else if (Year3RadioButton.Checked)
                            {
                                Warrenty = 3;
                                WarrentyYears = "3 Years";
                                ServiceWarrenty = THREEYEARWARRANTY;
                                WarrentyValue = ServiceWarrenty * BrandQuantityCost;
                            }
                            else if (Year5RadioButton.Checked)
                            {
                                Warrenty = 5;
                                WarrentyYears = "5 Years";
                                ServiceWarrenty = FIVEYEARWARRANTY;
                                WarrentyValue = ServiceWarrenty * BrandQuantityCost;

                            }
                            else
                            {
                                Warrenty = 0;
                                WarrentyYears = "No Warrenty Selected";
                                ServiceWarrenty = NOWARRANTY;
                                WarrentyValue = ServiceWarrenty * BrandQuantityCost;
                            }


                            //Total cost after warrenty selection
                            BrandCostWithWarrenty = BrandQuantityCost + WarrentyValue;

                            //If condition to calculate the discount and add it to if quote meets the criteria given
                            if (Warrenty >= 3 && Quantity >= DISCOUNTELIGIBLEQUANTITY)
                            {
                                FinalDiscountValue = (BrandCostWithWarrenty * FINALDISCOUNT);
                            }
                            else
                            {
                                FinalDiscountValue = NODISCOUNT;
                            }
                            //If condition to handle the check box selection
                            if (!ExpeditedInstallCheckBox.Checked)
                            {
                                InstallationType = "Standard Install";
                                InstallationCost = BASICINSTALL;
                            }
                            else
                            {
                                InstallationType = "Expedited Install";
                                InstallationCost = BASICINSTALL + EXPEDITEDINSTALLATION;
                            }
                            //Final quote value calculation along with installation
                            TotalQuoteValue = (BrandCostWithWarrenty - FinalDiscountValue) + InstallationCost;

                            //Text storage to send the values to the output label to display 
                            OutputLabel.Text = "Total Quote Value: " +
                                "\n\n" + "Equipment Selected: " + Equipment +
                                "\n" + "Brand Selected: " + Brand +
                                "\n" + "Quantity Entered: " + Quantity +
                                "\n" + "Cost of the Equipment: " + BrandQuantityCost.ToString("C2") +
                                "\n" + "Service Warranty Selected: " + WarrentyValue.ToString("C2") + " for " + WarrentyYears +
                                "\n" + "Discount Applied: " + FinalDiscountValue.ToString("C2") +
                                "\n" + "Standard Installation Cost: " + BASICINSTALL.ToString("C2") +
                                "\n" + "InstallationType Selected: " + InstallationType.ToString() +
                                "\n" + "Total Equipment Cost is: " + TotalQuoteValue.ToString("C2");

                            //Enable the order button once quote is generated
                            OrderButton.Enabled = true;
                        }
                        else
                        {
                            //else to handle the error in quantity box - only whole number and non negative values are accepted
                            MessageBox.Show("Please enter valid quantity or value more than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            QuantityTextBox.Focus();
                        }
                    }
                    else
                    {
                        //else to handle when quote is generated without brand is selected
                        MessageBox.Show("Please select brand to proceed further", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BrandListBox.Focus();
                    }
                }
                else
                {
                    //else to handle when quote is generated without equipment is selected
                    MessageBox.Show("Please select equipment to proceed further", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EquipmentListBox.Focus();
                }
            }
            catch
            {
                //else to handle any other generic error
                MessageBox.Show("Please enter/select valid inputs", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            //After Quote Button is pressed - changing the application behavior
            ClientInputGroupBox.Visible = true;
            QuoteButton.Enabled = true;

            TransactionId = "";

            //Random Transaction Number generation
            Random RandomNumber = new Random();

            //Ireration to generate Transaction Number
            for (int i = 0; i < 8; i++)
            {
                TransactionId += RandomNumber.Next(0, 10).ToString();
            }
            TransactionLabelBox.Text = TransactionId;

            //Current Date generation
            DateLabelBox.Text = CurrentDate.ToShortDateString();


        }
        private bool ValidateClientDetails()
        {
            //Client Details storing from the input 
            ClientName = ClientNameTextBox.Text;
            Eircode = EircodeTextBox.Text;
            PhoneNumber = PhoneNumberTextBox.Text;
            EmailAddress = EmailAddressTextBox.Text;

            //Validate Client Name 
            if (string.IsNullOrEmpty(ClientName))
            {
                ErrorMessageLabel.Text = "Please enter the full name.";
                ClientNameTextBox.Focus();
                ErrorMessageLabel.ForeColor = Color.Red;
                return false;
            }
            //Validate Eircode
            if (string.IsNullOrWhiteSpace(Eircode) || Eircode.Length != 8)
            {
                ErrorMessageLabel.Text = "Please enter a valid Eircode (e.g H91 ABCA)";
                ErrorMessageLabel.ForeColor = Color.Red;
                EircodeTextBox.Focus();
                return false;
            }
            //Validate Phone Number
            if (!PhoneNumber.All(char.IsDigit) || PhoneNumber.Length != 10)
            {
                ErrorMessageLabel.Text = "Please enter a valid phone number";
                PhoneNumberTextBox.Focus();
                ErrorMessageLabel.ForeColor = Color.Red;
                return false;
            }
            //Validate Email Address
            if (string.IsNullOrWhiteSpace(EmailAddress) || !EmailAddress.Contains("@") || !EmailAddress.Contains("."))
            {
                ErrorMessageLabel.Text = "Please enter a valid email address";
                EmailAddressTextBox.Focus();
                ErrorMessageLabel.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void ProceedButton_Click_1(object sender, EventArgs e)
        {
            //Changing the behavior of the application according to the Proceed button
            QuoteButton.Enabled = true;
            OrderButton.Enabled = true;

            //Proceeding after successful validation
            if (ValidateClientDetails())
            {
                ErrorMessageLabel.ForeColor = Color.Green;
                ErrorMessageLabel.Text = "All details are successfully validated.";

                LoanForm LoanFormConnect = new LoanForm();
                this.Hide();
                LoanFormConnect.ShowDialog();
            }
          
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Search button opening the search form
            SearchForm SearchFormConnect = new SearchForm();
            this.Hide();
            SearchFormConnect.ShowDialog();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the application to default values once clear button is pressed
            HomePage_Load(sender, e);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the application once exit button is pressed
            Application.Exit();
        }
    }
}

