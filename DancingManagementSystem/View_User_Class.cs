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
    public partial class View_User_Class : Form
    {
        //
        //Variables
        private MySQLConnection sqlConn;
        private int minIndex = 0;
        private int maxIndex;
        private int rowIndex = 0;
        private DataGridView dataView;

        //
        // Constructor
        // The MainMenu form will pass its SQLConnection & DataGridView to this FormView 
        // so that this FormView can navigate the data and update the data to The Database
        public View_User_Class(DataGridView dataView, MySQLConnection sqlConn)
        {
            //Initiate the visual window form
            InitializeComponent();

            // Assign the dataView and sqlConn that the Mainmenu form passes to this form
            this.dataView = dataView;
            this.sqlConn = sqlConn;

            // Set the maxIndex.
            // The reason to minus 2 rather than minus 1 is that the last record of the DataGridView is NULL
            maxIndex = dataView.Rows.Count - 2;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //Set the rowIndex to 0 ==> first record in DataGridView
            rowIndex = 0;

            // Call the method navigateRecord(rowIndex) to display the data of the record
            navigateRecord(rowIndex);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Check if the current row is the first row
            if (rowIndex != minIndex)
            {
                // Set rowIndex back to the previous record
                rowIndex--;

                // Call the method navigateRecord(rowIndex) to display the data of the record
                navigateRecord(rowIndex);
            }
            else
            {
                MessageBox.Show("This is the first record already!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Check if the current row is the last row
            if (rowIndex != maxIndex)
            {
                // Set rowIndex back to the previous record
                rowIndex++;

                // Call the method navigateRecord(rowIndex) to display the data of the record
                navigateRecord(rowIndex);
            }
            else
            {
                MessageBox.Show("This is the last record. No more records!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //Set the rowIndex to maxIndex ==> last record in DataGridView
            rowIndex = maxIndex;

            // Call the method navigateRecord(rowIndex) to display the data of the record
            navigateRecord(rowIndex);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Get the class_id of the current selected row
            string selectedId = dataView.Rows[rowIndex].Cells[0].Value.ToString();

            //Check if the class_id has already been registered
            if (!isClassRegistered(selectedId))
            {
                //Initiate a new connection object and sqlCommand string
                sqlConn = new MySQLConnection();

                //SQL command
                string sqlCommand = "INSERT INTO registered_class VALUES(" + selectedId + "," + MySQLConnection.getUserId() + ");";

                // Execute the above SQL commands
                sqlConn.insert(sqlCommand);

                //Inform user
                MessageBox.Show("Registered for the class successfully!");

            }
            else
            {
                MessageBox.Show("You've registered for this class already. No need to repeat!");
            }
        }

        //
        // This method gets the value from datagridview and put to the labels
        //
        private void navigateRecord(int rowIndex)
        {
            lblNameValue.Text = dataView.Rows[rowIndex].Cells[1].Value.ToString();
            lblCategoryValue.Text = dataView.Rows[rowIndex].Cells[2].Value.ToString();
            lblInstructorValue.Text = dataView.Rows[rowIndex].Cells[3].Value.ToString();
            lblVenueValue.Text = dataView.Rows[rowIndex].Cells[4].Value.ToString();
            lblStartDateValue.Text = dataView.Rows[rowIndex].Cells[5].Value.ToString().Remove(10);
            lblFeeValue.Text = dataView.Rows[rowIndex].Cells[6].Value.ToString();
        }

        //
        // This method is to check if the selected class_is is already registered
        // If so, display the message to inform user
        private bool isClassRegistered(string class_id)
        {
            // Initiate a new connection object
            sqlConn = new MySQLConnection();

            //Create a string SQL command
            string sqlCommand = "SELECT COUNT(dance_class_class_id) FROM registered_class WHERE dance_class_class_id="
                                + class_id + " AND user_data_user_id=" + MySQLConnection.getUserId() + ";";

            //initialize with arbitrary value, except 0 and 1
            int row_count = 2;

            //Execute the sql command
            MySqlDataReader dtReader = sqlConn.select_Using_DataReader(sqlCommand);

            //While loop to change the current row of dtReader
            while (dtReader.Read())
            {
                row_count = dtReader.GetInt16(0);
            }

            //Close object dtReader
            dtReader.Close();

            //Close SQL connection
            sqlConn.close();

            //Check the value of row_count 
            if (row_count == 1)
                return true;
            else
                return false;
        }// end of isClassRegistered()

        //
        // This method is called when the form is loaded for the first time
        //
        private void View_User_Class_Load(object sender, EventArgs e)
        {
            //Set the rowIndex to the first record
            rowIndex = 0;

            //Display the first record
            navigateRecord(rowIndex);
        } //end of form_load()
    }
}
