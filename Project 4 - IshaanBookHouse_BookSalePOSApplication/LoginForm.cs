/* Student Name: Aashik Ahamed Mohamed Ibrahim
 * Student ID: 25237259
 * Date:18/12/2025
 * Assignment: 4
 * Assignment: Customized ePOS application - Ishaan Book House - A Book 
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

namespace FinalAssignmentA4
{
    public partial class LoginForm : Form
    {
        //Variables declaration for password
        const string EXPECTEDPASSWORD = "ILuvVisualC#"; 
        const int MAXIMUMATTEMPTS = 3;
        int NoOfAttempts, RemainingAttempts;

        //Taking the username to next page to display in the form text as who logged in
        public static string UserName { get; private set; } = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        //Login button for the application
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Checking the entry of usename and password
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter both a username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserName = UserNameTextBox.Text;
            string PasswordEntered = PasswordTextBox.Text;
            //Checking for the password authenticity
            if (EXPECTEDPASSWORD == PasswordEntered)
            {
                MessageBox.Show("Login Successful!", "Login Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CheckoutForm CheckoutHomePage = new CheckoutForm();
                this.Hide();
                CheckoutHomePage.Show();
            }
            else
            {
                //Checking for the number of attempts
                NoOfAttempts++;
                RemainingAttempts = MAXIMUMATTEMPTS - NoOfAttempts;

                if (NoOfAttempts >= MAXIMUMATTEMPTS)
                {
                    MessageBox.Show("Maximum tries reached. Application will close.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Invalid password. {RemainingAttempts} attempts remaining.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTextBox.Clear();
                    PasswordTextBox.Focus();
                }
            }
        }

        //Focusing on the username to enter the username once the form is loaded
        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserNameTextBox.Focus();
        }

        //Exit the application if the customer have any objection
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
