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
    public partial class Login : Form
    {
        //
        //Variables declaration
        MySQLConnection sqlConnection = new MySQLConnection();

        //
        // Constructor
        //
        public Login()
        {
            InitializeComponent();
        }

        //
        // This method will be called once the Button Login is clicked.
        // It connects to the table 'user_login' of the Database and search for the corresponding password of the given
        // username, then check if the given password is correct or not.
        // If the password is correct, then close this Login form and generate MainMenu form
        // If the password is incorrect, then display MessageBox telling the error.
        // If the account is 'admin', the MainMenuAdmin form will be created instead of MainMenu form.
        //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the username that user entered into 'Username' textbox and store in variable 'uname'
            string uname = txtboxUsername.Text;

            //This variable to store the password that get from the database
            string pword = "";
            
            // Create a string that represents an SQL query command.
            // This SQL command to retrieve the corresponding password of a given username from database
            string sqlCommand = "SELECT user_id,password FROM user_data WHERE username='" + uname + "';";
            
            //Execute the SQL command and save the result of the query to 'queryResult' variable by calling select() method
            MySqlDataReader queryResult;
            queryResult = sqlConnection.select_Using_DataReader(sqlCommand);
            
            // Using while loop to move the row of data
            while (queryResult.Read())
            {
                //Assign the retrieved password to string 'pword', then compare this string to the password that user entered.
                pword = queryResult.GetString(1);
                MySQLConnection.setUserId(queryResult.GetInt16(0));
            }
            
            // Close queryResult now
            queryResult.Close();
            
            // Close SQL connection, because the method select() doesn't close the connection after openning connection.
            sqlConnection.close();
            
            // If the pword equal to Null, it means there is no username existent in the database.            
            if (pword.Equals(""))
            {
                MessageBox.Show("The username doesn't exist!");
            } else
            {
                // If the passwords are match, close Login form and start MainMenu form
                if ( String.Equals(pword, txtboxPassword.Text, StringComparison.Ordinal) )
                {
                    //
                    // If the loggin account is 'admin', then open MainMenu for Administrator
                    // If not, open MainMenu for user
                    //
                    if (String.Equals("admin", txtboxUsername.Text, StringComparison.Ordinal))
                    {
                        this.Hide();
                        var mainMenu = new MainMenuAdministrator();
                        mainMenu.Closed += (s, args) => this.Close();
                        mainMenu.Show();
                    } else
                    {
                        this.Hide();
                        var mainMenu = new MainMenu();
                        mainMenu.Closed += (s, args) => this.Close();
                        mainMenu.Show();
                    }
                    //
                }
                else
                {
                    MessageBox.Show("The password is incorrect. Try again!");
                }
            }
        }// end of btnLogin_Click()

        //
        // This method is to handle the events generated when the button 'Sign up' is clicked.
        // + Initiate a new Registration Form.
        // + Display the new form.
        //
        private void btnSignup_Click(object sender, EventArgs e)
        {
            //Initiate a new registration form
            var registrationForm = new Registration();
            
            // ShowDialog() is used rather than Show() because I want the Login form to be not interactive since the 
            // registration form is still appearing.
            registrationForm.ShowDialog();

        }// end of btnSignup_Click()

        //
        //This method is called when the user press Enter while interacting with Password textbox
        //
        private void txtboxPassword_EnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }           
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var uploadForm = new OpenFileForm();
            uploadForm.ShowDialog();
        }
    }// end of class Login
}//end of namespace
