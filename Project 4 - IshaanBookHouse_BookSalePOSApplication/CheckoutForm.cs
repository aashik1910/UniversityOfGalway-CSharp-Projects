#nullable disable
using System.Globalization;
using System.Text;
using System.Transactions;

namespace FinalAssignmentA4
{
    public partial class CheckoutForm : Form
    {
        // Declaration of constant variables used in the code
        const string STOCKFILENAME = "Stock_File.txt";
        const string CLOSINGSTOCKFILE = "Closing_Stock.txt";
        const char FILEDELIMITER = ',';
        const int TOTALFIELDS = 4;
        const int STOCKTHRESHOLD = 5;
        const decimal DISCOUNT75 = 75.00m;
        const decimal DISCOUNT25 = 25.00m;
        const decimal ORIGINALPRICE = 0.00m;
        const decimal LOWDISCOUNT = 0.05m;
        const decimal HIGHDISCOUNT = 0.10m;

        //Declaring the list of variables to handle the inventory items
        public List<string> InventoryTitles = new List<string>();
        public List<string> InventoryTypes = new List<string>();
        public List<decimal> InventoryPrices = new List<decimal>();
        public List<int> InventoryCurrentStock = new List<int>();
        public List<int> InventoryOpeningStock = new List<int>();

        //Declaring the list of variables to handle the basket items 
        private List<string> BasketTitles = new List<string>();
        private List<string> BasketTypes = new List<string>();
        private List<decimal> BasketLineTotals = new List<decimal>();
        private List<int> BasketQuantities = new List<int>();

        //Declaring the list of variables to handle the transaction Record to display in the report
        public List<string> HistoryIDs = new List<string>();
        public List<DateTime> HistoryDates = new List<DateTime>();
        public List<decimal> HistoryTotals = new List<decimal>();

        public CheckoutForm()
        {
            //Initialize the component
            InitializeComponent();
            LoadInventoryData();

            //Saving the data on exit
            this.FormClosing += SaveDataOnExit;
        }

        //Loading the Checkout form and getting the username from the login page to display here
        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            this.Text = "Ishaan Book House - Sales Rep - " + LoginForm.UserName + "";
        }

        //Loading the data from stock file and closing file to sync the data regular basis
        private void LoadInventoryData()
        {
            string FilePath;
            //To use the original stock file or if the update file exit use the update file
            if (File.Exists(CLOSINGSTOCKFILE))
            {
                FilePath = CLOSINGSTOCKFILE;
            }
            else
            {
                FilePath = STOCKFILENAME;
            }
            //Reading the data from the file and send it to the Book and Type List box
            if (File.Exists(FilePath))
            {
                string[] FileLines = File.ReadAllLines(FilePath);
                for (int Index = 0; Index < FileLines.Length; Index++)
                {
                    string[] Parts = FileLines[Index].Split(FILEDELIMITER);
                    if (Parts.Length == TOTALFIELDS)
                    {
                        //Splitting the data using the delimmitter file to send it as seperate entity
                        InventoryTitles.Add(Parts[0].Trim());
                        InventoryTypes.Add(Parts[1].Trim());
                        InventoryPrices.Add(decimal.Parse(Parts[2].Trim()));
                        int StockVal = int.Parse(Parts[3].Trim());
                        InventoryCurrentStock.Add(StockVal);
                        InventoryOpeningStock.Add(StockVal);
                    }
                }
                PopulateBookList();
            }
        }
        //Add the inventory to the book and type list boxes
        private void PopulateBookList()
        {
            BookListBox.Items.Clear();
            List<string> UniqueTitles = new List<string>();
            for (int i = 0; i < InventoryTitles.Count; i++)
            {
                if (!UniqueTitles.Contains(InventoryTitles[i]))
                {
                    UniqueTitles.Add(InventoryTitles[i]);
                    BookListBox.Items.Add(InventoryTitles[i]);
                }
            }
        }
        //Handling the list of books in the display section using the data derived
        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedItem == null) return;
            TypeListBox.Items.Clear();
            PriceDisplayLabel.Text = "";
            StockDisplayLabel.Text = "";
            string SelectedTitle = BookListBox.SelectedItem.ToString();

            for (int i = 0; i < InventoryTitles.Count; i++)
            {
                if (InventoryTitles[i] == SelectedTitle)
                {
                    TypeListBox.Items.Add(InventoryTypes[i] + " - " + InventoryPrices[i].ToString("C2"));
                }
            }
        }
        //Handling the list of type in the display section using the data derived
        private void TypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedItem == null || TypeListBox.SelectedItem == null) return;

            string SelectedTitle = BookListBox.SelectedItem.ToString();
            string SelectedEntry = TypeListBox.SelectedItem.ToString();
            string SelectedType = SelectedEntry.Split('-')[0].Trim();
            //Handling of outofstock and low stock inventory 
            for (int i = 0; i < InventoryTitles.Count; i++)
            {
                if (InventoryTitles[i] == SelectedTitle && InventoryTypes[i] == SelectedType)
                {
                    PriceDisplayLabel.Text = InventoryPrices[i].ToString("C2");
                    StockDisplayLabel.Text = InventoryCurrentStock[i].ToString();

                    if (InventoryCurrentStock[i] <= 0)
                    {
                        MessageBox.Show("WARNING: " + SelectedTitle + " (" + SelectedType + ") is currently OUT OF STOCK.");
                    }
                    else if (InventoryCurrentStock[i] < STOCKTHRESHOLD)
                    {
                        MessageBox.Show("LOW STOCK ALERT: Only " + InventoryCurrentStock[i].ToString() + " left for " + SelectedTitle);
                    }
                    break;
                }
            }
        }
        //Refressh the stock display according to the stock file and the data selected
        private void RefreshStockDisplay()
        {
            if (BookListBox.SelectedItem == null || TypeListBox.SelectedItem == null) return;
            string SelectedTitle = BookListBox.SelectedItem.ToString();
            string SelectedType = TypeListBox.SelectedItem.ToString().Split('-')[0].Trim();

            for (int i = 0; i < InventoryTitles.Count; i++)
            {
                if (InventoryTitles[i] == SelectedTitle && InventoryTypes[i] == SelectedType)
                {
                    StockDisplayLabel.Text = InventoryCurrentStock[i].ToString();
                    break;
                }
            }
        }
        //Add the item to the order button
        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            //Handle when the book list or type list is not selected
            if (BookListBox.SelectedItem == null || TypeListBox.SelectedItem == null) return;

            string Title = BookListBox.SelectedItem.ToString();
            string SelectedEntry = TypeListBox.SelectedItem.ToString();
            string Type = SelectedEntry.Split('-')[0].Trim();
            int RequestedQty = (int)NumberQuantity.Value;
            DiscountDisplayLabel.Show();
            //handling for the inventory
            for (int i = 0; i < InventoryTitles.Count; i++)
            {
                if (InventoryTitles[i] == Title && InventoryTypes[i] == Type)
                {
                    if (InventoryCurrentStock[i] < RequestedQty)
                    {
                        MessageBox.Show("Insufficient stock.");
                        return;
                    }

                    //Calculation of the specific amount for the item selected
                    decimal LineTotal = InventoryPrices[i] * RequestedQty;

                    InventoryCurrentStock[i] -= RequestedQty;

                    BasketTitles.Add(Title);
                    BasketTypes.Add(Type);
                    BasketQuantities.Add(RequestedQty);
                    BasketLineTotals.Add(LineTotal);

                    //Display the selected item in the basket once add to order button is selected
                    CurrentBasketListBox.Items.Add(Title + " (" + Type + ") x" + RequestedQty + " - " + LineTotal.ToString("C2"));

                    //Display the inventory current stock in the section after calculation
                    CalculateTotal();
                    StockDisplayLabel.Text = InventoryCurrentStock[i].ToString();
                    //Setting the Quantity to default
                    NumberQuantity.Value = 1;
                    break;
                }
            }
        }
        //This handler handles the calculation of data
        private void CalculateTotal()
        {
            decimal SubTotal = 0;
            for (int i = 0; i < BasketLineTotals.Count; i++) { SubTotal += BasketLineTotals[i]; }
            decimal Discount = 0;
            if (SubTotal > DISCOUNT75) Discount = SubTotal * HIGHDISCOUNT;
            else if (SubTotal > DISCOUNT25) Discount = SubTotal * LOWDISCOUNT;
            //application of discount
            DiscountDisplayLabel.Text = "Discount amount applied = " + Discount.ToString("C2");
            TotalCostDisplayLabel.Text = (SubTotal - Discount).ToString("C2");
        }
        //Remove the selected items from the basket and update the inventory list accordingly
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CurrentBasketListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                //Returning the items list to the default values
                string RemoveTitle = BasketTitles[selectedIndex];
                string RemoveType = BasketTypes[selectedIndex];
                int RemoveQuantity = BasketQuantities[selectedIndex];

                for (int i = 0; i < InventoryTitles.Count; i++)
                {
                    if (InventoryTitles[i] == RemoveTitle && InventoryTypes[i] == RemoveType)
                    {
                        InventoryCurrentStock[i] += RemoveQuantity;
                        break;
                    }
                }

                //Remove the items in the basket list
                BasketTitles.RemoveAt(selectedIndex);
                BasketTypes.RemoveAt(selectedIndex);
                BasketQuantities.RemoveAt(selectedIndex);
                BasketLineTotals.RemoveAt(selectedIndex);

                //Clear the basket list and refresh the stock list
                CurrentBasketListBox.Items.RemoveAt(selectedIndex);
                CalculateTotal();
                RefreshStockDisplay();
            }
            else
            {
                MessageBox.Show("Please select an item from the basket to remove.");
            }
        }
        //Clear button to remove all the items in a single click
        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BasketTitles.Count; i++)
            {
                for (int j = 0; j < InventoryTitles.Count; j++)
                {
                    if (InventoryTitles[j] == BasketTitles[i] && InventoryTypes[j] == BasketTypes[i])
                    {
                        InventoryCurrentStock[j] += BasketQuantities[i];
                        break;
                    }
                }
            }
            //Clear all the existing values and set to default
            BasketTitles.Clear();
            BasketTypes.Clear();
            BasketQuantities.Clear();
            BasketLineTotals.Clear();
            CurrentBasketListBox.Items.Clear();
            DiscountDisplayLabel.Hide();

            // Set the original price value to default
            TotalCostDisplayLabel.Text = ORIGINALPRICE.ToString("C2");
            RefreshStockDisplay();
        }

        private void Checkoutbutton_Click(object sender, EventArgs e)
        {
            //Check whether the basket is empty or not
            if (BasketTitles.Count == 0)
            {
                MessageBox.Show("Basket is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Display the confirmation to the sales analyst
            if (MessageBox.Show("Complete purchase?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;

            //Transaction ID generation and current data storage
            string TransactionID = "IBH" + DateTime.Now.Ticks.ToString().Substring(12);
            string DateStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //Update the total values accordingly
            decimal TotalValue;
            string CleanTotal = TotalCostDisplayLabel.Text.Replace("€", "").Trim();
            decimal.TryParse(CleanTotal, out TotalValue);

            //Calculate total discount applied
            decimal SubTotal = 0;
            foreach (decimal LineTotal in BasketLineTotals) { SubTotal += LineTotal; }
            decimal DiscountApplied = SubTotal - TotalValue;

            //Sotre the item purchased
            string ItemsPurchased = "";
            for (int i = 0; i < BasketTitles.Count; i++)
            {
                ItemsPurchased += $"{BasketTitles[i]} x{BasketQuantities[i]}; ";
            }

            //Record all the transactions
            string Record = $"{DateStamp},{TransactionID},{ItemsPurchased.TrimEnd(';', ' ')},{TotalValue:C2},{DiscountApplied:C2}";

            //Append all the lines
            File.AppendAllLines("Sales_Report.txt", new[] { Record });

            //Clear UI and Lists
            BasketTitles.Clear();
            BasketQuantities.Clear();
            BasketLineTotals.Clear();
            CurrentBasketListBox.Items.Clear();
            TotalCostDisplayLabel.Text = ORIGINALPRICE.ToString("C2");
            DiscountDisplayLabel.Hide();
            //shot the message
            MessageBox.Show($"Transaction {TransactionID} saved to Sales Report.");
        }

        private void SaveDataOnExit(object sender, FormClosingEventArgs e)
        {
            //Save the data while exiting the page
            StringBuilder Builder = new StringBuilder();
            for (int i = 0; i < InventoryTitles.Count; i++)
            {
                Builder.AppendLine(InventoryTitles[i] + FILEDELIMITER + InventoryTypes[i] + FILEDELIMITER + InventoryPrices[i] + FILEDELIMITER + InventoryCurrentStock[i]);
            }
            File.WriteAllText(CLOSINGSTOCKFILE, Builder.ToString());
        }
        //Navigation to the report form
        private void ReportSearchButton_Click(object sender, EventArgs e)
        {
            SearchReportForm FormReport = new SearchReportForm(this);
            this.Hide();
            FormReport.Show();
        }
        //Logout from the application
        private void LogoutButton_Click(object sender, EventArgs e)
        {

            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();

        }


    }
}