using System.Diagnostics;
using System.Text;

namespace FinalAssignmentA4
{
    public partial class SearchReportForm : Form
    {
        //Declaring the Checkout page 
        CheckoutForm ParentData;
        string ActiveFilePath = "";

        //Constant for the declaration
        const string SALESREPORT = "Sales_Report.txt";
        const string FINALSTOCKREPORT = "FinalStockReport.txt";
        const string FINALSALESREPORT = "FinalSalesReport.txt";
        const string DETAILEDLOG = "DetailedLog.txt";
        const string LASTSEARCHQUERY = "LastSearchQuery.txt";

        const int NUMBEROFPARTS = 5;


        //Values declared for resizing of form
        const int INCREMENT = 15, FORMSTARTWIDTH = 866, FORMSTARTHEIGHT = 700,
            FORMEXPANDWIDTH = 1250, FORMEXPANDHEIGHT = 700;
        Boolean FormWidthExpanded = false, FormHeightExpanded = false;

        //Form Initialization
        public SearchReportForm(CheckoutForm Source)
        {
            InitializeComponent();
            ParentData = Source;
        }
        private void SearchReportForm_Load(object sender, EventArgs e)
        {
            //Actual size of the form 
            this.Size = new Size(FORMSTARTWIDTH, FORMSTARTHEIGHT);
            SearchButton.Enabled = true;
        }
        //Sales report button and the report handling
        private void SalesButton_Click(object sender, EventArgs e)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("FULL SALES HISTORY REPORT");
            Builder.AppendLine("========================================");

            decimal SumTotal = 0;
            string ReportSourcePath = SALESREPORT;
            //Append the details properly
            if (File.Exists(ReportSourcePath))
            {
                string[] AllSales = File.ReadAllLines(ReportSourcePath);
                foreach (string SaleRecord in AllSales)
                {
                    string[] Parts = SaleRecord.Split(',');
                    if (Parts.Length >= NUMBEROFPARTS)
                    {
                        Builder.AppendLine($"DATE: {Parts[0]}");
                        Builder.AppendLine($"ID: {Parts[1]}");
                        Builder.AppendLine($"ITEMS: {Parts[2]}");
                        Builder.AppendLine($"TOTAL: {Parts[3]}");
                        Builder.AppendLine($"DISCOUNT: {Parts[4]}"); // Added Discount here
                        Builder.AppendLine("----------------------------------------");

                        string CleanPrice = Parts[3].Replace("€", "").Trim();
                        decimal.TryParse(CleanPrice, out decimal LineTotal);
                        SumTotal += LineTotal;
                    }
                }
            }

            Builder.AppendLine("========================================");
            Builder.AppendLine("TOTAL SALES REVENUE: " + SumTotal.ToString("C2"));
            //Set the file path to final sales report
            ActiveFilePath = FINALSALESREPORT;
            File.WriteAllText(ActiveFilePath, Builder.ToString());
            ReportDisplayTextBox.Text = Builder.ToString();
        }
        //Stock report generation
        private void StockButton_Click(object sender, EventArgs e)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("CURRENT STOCK REPORT");
            Builder.AppendLine("Generated: " + DateTime.Now.ToString("g"));
            Builder.AppendLine("========================================");

            for (int i = 0; i < ParentData.InventoryTitles.Count; i++)
            {
                int CurrentStock = ParentData.InventoryCurrentStock[i];
                string StatusAlert = "";

                //handling the ourof stock
                if (CurrentStock == 0) StatusAlert = " !!! *** OUT OF STOCK *** !!!";
                else if (CurrentStock < 5) StatusAlert = " [LOW STOCK WARNING]";

                Builder.AppendLine($"ITEM: {ParentData.InventoryTitles[i]} ({ParentData.InventoryTypes[i]})");
                Builder.AppendLine($"STOCK: {CurrentStock} Remaining {StatusAlert}");
                Builder.AppendLine("----------------------------------------");
            }

            Builder.AppendLine("========================================");
            Builder.AppendLine("END OF REPORT");

            //Setting the final sotck
            ActiveFilePath = FINALSTOCKREPORT;
            File.WriteAllText(ActiveFilePath, Builder.ToString());

            ReportDisplayTextBox.Text = Builder.ToString();
        }
        //Sales report functionality
        private void SearchSaleButton_Click(object sender, EventArgs e)
        {
            ExpandForm();
            SearchSaleButton.Enabled = false;
            StringBuilder Builder = new StringBuilder();
            Builder.AppendLine("Search by Transaction ID or Date of Purchase to see transactions");
            for (int i = 0; i < ParentData.HistoryIDs.Count; i++)
            {
                Builder.AppendLine("Transaction: " + ParentData.HistoryIDs[i] + " Date: " + ParentData.HistoryDates[i].ToShortDateString());
            }

            ActiveFilePath = DETAILEDLOG;
            File.WriteAllText(ActiveFilePath, Builder.ToString());
            ReportDisplayTextBox.Text = Builder.ToString();
        }
        //Search button using transaction and date
        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            if (!TransactionRadioButton.Checked && !DateRadioButton.Checked)
            {
                MessageBox.Show("Please select a search category (Transaction ID or Date).",
                                "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userInput = SearchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }
            //Clear the report display box
            ReportDisplayTextBox.Clear();
            StringBuilder resultsBuilder = new StringBuilder();
            resultsBuilder.AppendLine("SEARCH RESULTS");
            resultsBuilder.AppendLine("========================================");

            string filePath = SALESREPORT;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No transaction records found.");
                return;
            }

            
            string[] allTransactions = File.ReadAllLines(filePath);
            bool matchFound = false;

            foreach (string line in allTransactions)
            {
                
                string[] Parts = line.Split(',');

                if (Parts.Length < 5) continue;

                bool isMatch = false;

                // 3. Match Logic based on Radio Button selection
                if (TransactionRadioButton.Checked && Parts[1].Contains(userInput))
                {
                    isMatch = true;
                }
                else if (DateRadioButton.Checked && Parts[0].StartsWith(userInput))
                {
                    // Note: Users can enter YYYY-MM-DD or just YYYY-MM for monthly
                    isMatch = true;
                }

                if (isMatch)
                {
                    matchFound = true;
                    resultsBuilder.AppendLine($"DATE: {Parts[0]}");
                    resultsBuilder.AppendLine($"ID: {Parts[1]}");
                    resultsBuilder.AppendLine($"ITEMS: {Parts[2]}");
                    resultsBuilder.AppendLine($"TOTAL: {Parts[3]} (Discount: {Parts[4]})");
                    resultsBuilder.AppendLine("----------------------------------------");
                }
            }

            if (!matchFound)
            {
                resultsBuilder.AppendLine("No matches found for your search.");
            }

            
            ReportDisplayTextBox.Text = resultsBuilder.ToString();

           
            ActiveFilePath = LASTSEARCHQUERY;
            File.WriteAllText(ActiveFilePath, resultsBuilder.ToString());
        }
        //Clear button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            ReportDisplayTextBox.Clear();
            TransactionRadioButton.Checked = false;
            DateRadioButton.Checked = false;
            SearchTextBox.PlaceholderText = "Select a search option above..."; // Reset placeholder
            ActiveFilePath = "";
        }
        //Transaction radio button

        private void TransactionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TransactionRadioButton.Checked)
            {
                SearchTextBox.Clear();
                ReportDisplayTextBox.Clear(); // Clear old results
                SearchTextBox.PlaceholderText = "Enter Transaction ID (e.g., IBH12345):";
            }
        }
        //Date radio button
        private void DateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DateRadioButton.Checked)
            {
                SearchTextBox.Clear();
                ReportDisplayTextBox.Clear(); 
                SearchTextBox.PlaceholderText = "Enter Date (YYYY-MM-DD):";
            }
        }
        //Expand the form
        public void ExpandForm()
        {

            //Expand the form according to the display and content
            if (!FormWidthExpanded && !FormHeightExpanded)
            {
                for (int i = FORMSTARTWIDTH; i <= FORMEXPANDWIDTH; i += INCREMENT)
                {
                    this.Size = new Size(i, FORMSTARTHEIGHT);
                    this.Refresh();
                    System.Threading.Thread.Sleep(1);
                }

                FormWidthExpanded = true;
                FormHeightExpanded = true;
                
            }
        }
        //Generate the report into notepad file
        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(ActiveFilePath))
            {
                Process.Start("notepad.exe", ActiveFilePath);
            }
            else
            {
                MessageBox.Show("Please select a report first.");
            }
        }
        //Back button will take the user back to the checkout button
        private void BackButton_Click(object sender, EventArgs e)
        {
            ParentData.Show();
            this.Hide();
            this.Close();
        }
        
    }
}
