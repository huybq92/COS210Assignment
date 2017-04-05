using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DancingManagementSystem
{
    public partial class Registration : Form
    {
        //
        //Variables Declaration
        //
        private MySQLConnection sqlConn = new MySQLConnection();

        //
        // Constructor
        //
        public Registration()
        {
            InitializeComponent();
        }

        //
        // This method is to handle the events generated when the button 'Create' is clicked!
        // 
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //
            // Check if the 2 passwords are identical
            if (txtboxPassword.Text.Equals(txtboxPasswordConfirm.Text))
            {
                //Check if username is already selected or not
                if (isUsernameAvailable(txtboxUsername.Text))
                {
                    //
                    //Declare variables and store all the information that user entered
                    //           
                    string first_name = txtboxFirstname.Text;
                    string last_name = txtboxLastname.Text;
                    string username = txtboxUsername.Text;
                    string password = txtboxPassword.Text;
                    string birthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
                    string email = txtboxEmail.Text;
                    string mobile = txtboxMobile.Text;
                    string sqlCommand = "INSERT INTO user_data VALUES(null,'"
                                          + first_name + "','"
                                          + last_name + "','"
                                          + birthday + "','"
                                          + email + "','"
                                          + mobile + "','"
                                          + username + "','"
                                          + password + "');";

                    // Execute the SQL commands
                    sqlConn.insert(sqlCommand);

                    // Display the message to inform the success of creating the new account
                    MessageBox.Show("New account has been created!");

                    //Finally, close the form after all
                    this.Close();
                } else
                {
                    MessageBox.Show("Username is not available. Choose another please!");
                }
            } else //if the passwords are not identical, then display message to inform
            {
                MessageBox.Show("Passwords don't match! Check again!");
            }
        }

        //
        // This method will handle the events generated when the button Check Availability is clicked
        //      + Call the method isUsernameAvailable()
        //      + If the return value is true, display message
        //      + If the return value is false, display message
        //
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (isUsernameAvailable(txtboxUsername.Text))
            {
                MessageBox.Show("Congratulation! This username is available!");
            }
            else
            {
                MessageBox.Show("Sorry, this username is already taken! Please choose another!");
            }
        }

        //
        // Method isUsernameAvailable() is to check the availability of the username if it's already in the database. 
        //
        private bool isUsernameAvailable(string uname)
        {
            string sqlCommand = "SELECT COUNT(username) AS Row_Count FROM user_data"
                                + " WHERE username='"
                                + uname + "';";
            int row_count = 2;
            MySqlDataReader dtReader = sqlConn.select_Using_DataReader(sqlCommand);

            while (dtReader.Read())
            {
                row_count = dtReader.GetInt16(0);
            }

            // Close dtReader now
            dtReader.Close();

            // Close SQL connection, because the method select() doesn't close the connection after openning connection.
            sqlConn.close();

            if (row_count==0)
            {
                return true;
            } else
            {
                return false;
            }

        }// end of isUsernameAvailable()


        //
        // This method is called once the Textbox 'First Name' is clicked. The textbox will be make empty
        //
        private void txtboxFirstname_GotFocus(object sender, EventArgs e)
        {
            if (String.Equals(txtboxFirstname.Text, "First", StringComparison.Ordinal))
            {
                txtboxFirstname.Text = "";
            }
        }

        //
        // This method is called once the Textbox 'Last Name' is clicked. The textbox will be make empty
        //
        private void txtboxLastname_GotFocus(object sender, EventArgs e)
        {
            if (String.Equals(txtboxLastname.Text, "Last", StringComparison.Ordinal))
            {
                txtboxLastname.Text = "";
            }
        }

        //
        //
        //
    }// end of class Registration
}// end of namespace