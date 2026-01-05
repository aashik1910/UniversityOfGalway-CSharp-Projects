/* Student Name: Aashik Ahamed Mohamed Ibrahim
 * Student ID: 25237259
 * Date:24/10/2025
 * Assignment: 3
 * Assignment: Search for the order details from the txt file
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Form
{
    public partial class LoginForm : Form
    {

        //Password Variables declaration
        const string EXPECTEDPASSWORD = "ILuvVisualC#";
        const int MAXIMUMATTEMPTS = 3;
        int NoOfAttempts, RemainingAttempts;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Password Verification against given password
            string PasswordEntered = PasswordTextBox.Text;
            if (EXPECTEDPASSWORD == PasswordEntered)
            {
                MessageBox.Show("Login Successful!", "Login Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Login to quote page after successfull login
                QuoteForm QuoteFormConnect = new QuoteForm();

                this.Hide();

                QuoteFormConnect.Show();

                
            }
            else
            {
                //Handling the invalid attempts of password
                NoOfAttempts++;

                RemainingAttempts = MAXIMUMATTEMPTS - NoOfAttempts;

                //Validation of number of attempts and the maximum attempts

                if (NoOfAttempts >= MAXIMUMATTEMPTS)
                {
                    MessageBox.Show("Maximum tries reached, Application will be closed now", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid password. You have "+ RemainingAttempts + " attempts remaining", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //Cancel Button to close the application without login
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
