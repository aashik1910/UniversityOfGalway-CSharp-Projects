namespace FinanceQuoteForm
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        //Values declared for resizing of form
        const int INCREMENT = 15, FORMSTARTWIDTH = 822, FORMSTARTHEIGHT = 273,
            FORMEXPANDWIDTH = 822, FORMEXPANDHEIGHT = 751;
        Boolean FormWidthExpanded = false, FormHeightExpanded = false;
        
        //Declaring variables for file search
        string ExpectedTransactionId = "";
        string ExpectedEmailAddress = "";
        string FilePath = "LoanDetails.txt";

        //Maintaining original structure
        private void SearchForm_Load(object sender, EventArgs e)
        {
            //Actual size of the form 
            this.Size = new Size(FORMSTARTWIDTH, FORMSTARTHEIGHT);
        }
        //Search button functionality
        private void SearchButton_Click(object sender, EventArgs e)
        {

           
            //Calling the respective methods when the radio buttons are clicked
            if (TransactionIdRadioButton.Checked)
            {
                SearchTransactionById();
            }
            else if (EmailRadioButton.Checked)
            {
                SearchByEmailAdress();
            }

        }
        //Event handler to handle the search by transaction id
        public void SearchTransactionById()
        {
            ExpectedTransactionId = SearchTextBox.Text;
            //Hnadling if the file path or the file is empty
            if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
            {
                MessageBox.Show("The LoanDetails.txt file is empty or missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Checking whether the transaction Id is valid or not 
            if (string.IsNullOrWhiteSpace(ExpectedTransactionId) || ExpectedTransactionId.Length != 8 || ExpectedTransactionId.Contains("@") || ExpectedTransactionId.Contains("."))
            {
                MessageBox.Show("Please enter a valid Transaction Id.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //Expanding the form when the user enters the valid transaction id
                ExpandForm();
                StreamReader reader = new StreamReader(FilePath);

                //Declaring the variables
                string ResultByTransaction = "";
                bool Capture = false;
                string Currentline;

                do
                {
                    //Reading the code line by line until null value
                    Currentline = reader.ReadLine();
                    if (Currentline == null)
                        break;

                    //Comparing the variable with the expected transaction id
                    if (!Capture && Currentline.StartsWith(ExpectedTransactionId))
                        Capture = true;

                    if (Capture)
                    {
                        if (string.IsNullOrWhiteSpace(Currentline))
                            break;
                        //Storing the results here to display in the output label
                        ResultByTransaction += Currentline + "\n";
                    }

                } while (true);
                //Value to the display
                SearchDisplayLabel.Text = ResultByTransaction;
            }
            catch
            {
                MessageBox.Show("Error reading file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search by the email address
        public void SearchByEmailAdress()
        {
            ExpectedEmailAddress = SearchTextBox.Text;
            //Checking if the file or the file path is empty or not
            if (!File.Exists(FilePath) || new FileInfo(FilePath).Length == 0)
            {
                MessageBox.Show("The LoanDetails.txt file is empty or missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Condition to satisfy to get valid email address search
            if (string.IsNullOrWhiteSpace(ExpectedEmailAddress) || !ExpectedEmailAddress.Contains("@") || !ExpectedEmailAddress.Contains("."))
            {
                MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Initialize reader
            StreamReader Reader = null;

            try
            {
                //Expanding the form when the user enters the valid email address
                ExpandForm();
                Reader = new StreamReader(FilePath);

                //Declaring the variables for storage
                string Result = "";
                string ResultByEmailAddress = "";
                bool Capture = false;

                do
                {
                    //declaring current line to read the lines one by one
                    string CurrentLine = Reader.ReadLine();

                    if (CurrentLine == null)
                    {
                        if (Capture)
                            Result += ResultByEmailAddress + "\n";
                        break;
                    }
                    //Iretations for multiple email address search
                    if (string.IsNullOrWhiteSpace(CurrentLine))
                    {
                        
                        if (Capture)
                        {
                            Result += ResultByEmailAddress + "\n";
                            Capture = false;
                        }
                        ResultByEmailAddress = ""; 
                    }
                    else
                    {
                        ResultByEmailAddress += CurrentLine + "\n";

                        // Check if the line contains the email
                        if (!Capture && CurrentLine.Trim().Equals(ExpectedEmailAddress))
                        {
                            Capture = true;
                        }
                    }

                } while (true);
                //Display the result to the output
                SearchDisplayLabel.Text = ResultByEmailAddress;
            }
            catch
            {
                MessageBox.Show("Error reading file: ", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ExpandForm()
        {
            
            //Expand the form according to the display and content
            if (!FormWidthExpanded && !FormHeightExpanded)
            {
                for (int i = FORMSTARTHEIGHT; i <= FORMEXPANDHEIGHT; i += INCREMENT)
                {
                    this.Size = new Size(FORMSTARTWIDTH, i);
                    this.Refresh();
                    System.Threading.Thread.Sleep(1);
                }

                FormWidthExpanded = true;
                FormHeightExpanded = true;
            }
        }
        //Close the application
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
