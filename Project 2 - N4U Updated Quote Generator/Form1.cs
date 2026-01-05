using System.Runtime.InteropServices;
//Assignment 2
//Name: Aashik Ahamed Mohamed Ibrahim
//Student ID: 25237259
//This assignement is to design the Sales Quote Generator application using C# and Visual Studio
//This application helps to calculate the Quote and Summary of the purchase of the exercise equipments with corresponding brand
//and gives warrenty, expedite installation and discount on request basis

namespace New_Quote_Generator
{
    public partial class form1 : Form
    {
        public form1()
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
        const decimal ONEYEARWARRANTY = 0.15m, THREEYEARWARRANTY = 0.25m, FIVEYEARWARRANTY = 0.30m;

        //Declaring varible for installation
        const decimal BASICINSTALL = 149m, EXPEDITEDINSTALLATION = 99m;
        const decimal FINALDISCOUNT = 0.075m;
        //Declaring variables to use while executing the application
        int Quantity, NumberOfDiscountedOrders = 0, Warrenty = 0, TotalOrders = 0;
        string Equipment = "", Brand = "", Installation = "", WarrentyYears = "";
        decimal SummaryQuoteValue = 0, FinalDiscountValue = 0, TotalDiscountGiven = 0, BrandQuantityCost, BrandCostWithWarrenty, 
            WarrentyValue, TotalQuoteValue, ServiceWarrenty, InstallationCost;

        private void HomePage_Load(object sender, EventArgs e)
        {
            //To make sure all the prerequise after opening the applications are met
            this.Text = "Sales Quote Calculator";
            EquipmentListBox.Focus();
            BrandListBox.Focus();
            OrderButton.Enabled = false;
            SummaryButton.Enabled = false;

            //Clear all the selected values to default in case anything selected
            EquipmentListBox.ClearSelected();
            BrandListBox.ClearSelected();
            QuantityTextBox.Clear();
            Year1RadioButton.Checked = false;
            Year3RadioButton.Checked = false;
            Year5RadioButton.Checked = false;
            ExpeditedInstallCheckBox.Checked = false;
            OutputLabel.Text = "";

            //Tool Tips for Quote, Order, Summary, Clear and Exit Button
            QuoteToolTip.SetToolTip(QuoteButton, "Press to get the Quote");
            OrderToolTip.SetToolTip(OrderButton, "Press to place the Order");
            ClearToolTip.SetToolTip(ClearButton, "Press to clear the Quote");
            SummaryToolTip.SetToolTip(SummaryButton, "Press to get the Quote Summary");
            ExitToolTip.SetToolTip(ExitButton, "Press to exit the application");
        }
        private void QuoteButton_Click(object sender, EventArgs e)
        {
            this.Text = "Quote Generation";
            //Declaring variables for handling the Equipments and Brands
            int EquipmentIndex = 0, BrandIndex = 0;
            decimal EquipmentCost = 0, BrandDiscount = 0;
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
                        if (int.TryParse(QuantityTextBox.Text, out Quantity) && Quantity > 0)
                        {
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
                                WarrentyYears = "No Warrenty Selected";
                            }
                            //Total cost after warrenty selection
                            BrandCostWithWarrenty = BrandQuantityCost + (BrandQuantityCost * ServiceWarrenty);
                            
                            //If condition to calculate the discount and add it to if quote meets the criteria given
                            if (Warrenty >= 3 && Quantity >= 4)
                            {
                                FinalDiscountValue = (BrandCostWithWarrenty * FINALDISCOUNT);
                                NumberOfDiscountedOrders++;
                            }
                            else
                            {
                                FinalDiscountValue = 0;
                            }
                            //If condition to handle the check box selection
                            if (!ExpeditedInstallCheckBox.Checked)
                            {
                                Installation = "Expedited Installation is not Selected";
                                InstallationCost = BASICINSTALL;
                            }
                            else
                            {
                                Installation = EXPEDITEDINSTALLATION.ToString("C2");
                                InstallationCost = BASICINSTALL + EXPEDITEDINSTALLATION;
                            }
                            //Final quote value calculation along with installation
                            TotalQuoteValue = (BrandCostWithWarrenty - FinalDiscountValue) + InstallationCost;

                            //Variables to be used for Summary
                            SummaryQuoteValue += TotalQuoteValue;
                            TotalDiscountGiven += FinalDiscountValue;
                            
                            //Text storage to send the values to the output label to display 
                            OutputLabel.Text = "Total Quote Value: " +
                                "\n\n" + "Equipment Selected: " + Equipment +
                                "\n" + "Brand Selected: " + Brand +
                                "\n" + "Quantity Entered: " + Quantity +
                                "\n\n" + "Cost of the Equipment: " + BrandQuantityCost.ToString("C2") +
                                "\n" + "Service Warranty Selected: " + WarrentyValue.ToString("C2") + " for " + WarrentyYears +
                                "\n" + "Discount Applied: " + FinalDiscountValue.ToString("C2") +
                                "\n" + "Standard Installation Cost: " + BASICINSTALL.ToString("C2") +
                                "\n" + "Expedited Installation Selected: " + Installation.ToString() +
                                "\n" + "Total Equipment Cost is: " + TotalQuoteValue.ToString("C2");

                            //Enable the order button once quote is generated
                            OrderButton.Enabled = true;
                        }
                        else
                        {
                            //else to handle the error in quantity box - only whole number and non negative values are accepted
                            MessageBox.Show("Please enter valid number or value more than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Text = "Place the Order";
            //Display of quote details in the order message box for confirmation once the order button is pressed
            DialogResult result = MessageBox.Show(
                "\n" + "Your order details are as follows: " +
                "\n\n" + "Equipment Selected: " + Equipment +
                "\n" + "Brand Selected: " + Brand +
                "\n" + "Quantity Entered: " + Quantity +
                "\n\n" + "Cost of the Equipment: " + BrandQuantityCost.ToString("C2") +
                "\n" + "Service Warranty Selected: " + WarrentyValue.ToString("C2") + " for " + WarrentyYears +
                "\n" + "Discount Applied: " + FinalDiscountValue.ToString("C2") +
                "\n" + "Standard Installation Cost: " + BASICINSTALL.ToString("C2") +
                "\n" + "Expedited Installation Selected: " + Installation.ToString() +
                "\n" + "Total Equipment Cost is: " + TotalQuoteValue.ToString("C2")+
            "\n\n" + "Please confirm the order or cancel to requote", "Confirm the Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if condition to store the result of the message box
            if (result == DialogResult.Yes)
            {
                //Value storage for summary
                TotalOrders++;
                MessageBox.Show("Your Order is placed successfully", "Order Placed!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = "Sales Quote Calculator";
                //Display the application and clear the values to default once ok is pressed
                EquipmentListBox.Focus();
                EquipmentListBox.ClearSelected();
                BrandListBox.ClearSelected();
                QuantityTextBox.Clear();
                Year1RadioButton.Checked = false;
                Year3RadioButton.Checked = false;
                Year5RadioButton.Checked = false;
                ExpeditedInstallCheckBox.Checked = false;
                OutputLabel.Text = "";
                SummaryButton.Enabled = true;
                OrderButton.Enabled = false;
            }  
            
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            this.Text = "Summary of quote generated";
            //Display the summary value calculated in the above to the output label once the summary button is pressed
            OutputLabel.Text = "Total Summary Value:" +
                            "\n\n" + "Total Number of Orders Placed: " + TotalOrders +
                            "\n" + "Total Value of Equipment Ordered: " + SummaryQuoteValue.ToString("C2") +
                            "\n" + "Total Number of Discounted Orders: " + NumberOfDiscountedOrders.ToString("C2") +
                            "\n" + "Total Value of Discount: " + TotalDiscountGiven.ToString("C2") +
                            "\n" + "Average Revenue per Purchase: " + (SummaryQuoteValue / TotalOrders).ToString("C2");
            OrderButton.Enabled = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the application to default values once clear button is pressed
            HomePage_Load(sender, e);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //close the application once exit button is pressed
            this.Close();
        }

       
    }
}

