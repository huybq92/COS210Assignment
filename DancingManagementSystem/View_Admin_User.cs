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
    public partial class View_Admin_User : Form
    {
        //variables
        private MySQLConnection sqlConn;
        private int minIndex = 0;
        private int maxIndex;
        private int rowIndex = 0;
        private DataGridView dataView;

        //
        //Constructor
        //
        public View_Admin_User(DataGridView dataView, MySQLConnection sqlConn)
        {
            //Initialize visual windows form
            InitializeComponent();

            //Assign parameters to local variables
            this.sqlConn = sqlConn;
            this.dataView = dataView;

            // Set the maxIndex.
            // The reason to minus 2 rather than minus 1 is that the last record of the DataGridView is NULL
            maxIndex = dataView.Rows.Count - 2;
        }

        //
        // This method gets the value from datagridview and put to the textboxes
        //
        private void navigateRecord(int rowIndex)
        {
            txtboxFirstName.Text = dataView.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dataView.Rows[rowIndex].Cells[2].Value.ToString();
            lblBirthdayValue.Text = dataView.Rows[rowIndex].Cells[3].Value.ToString().Remove(10);
            txtboxEmail.Text = dataView.Rows[rowIndex].Cells[4].Value.ToString();
            txtboxMobile.Text = dataView.Rows[rowIndex].Cells[5].Value.ToString();
            lblUsernameValue.Text = dataView.Rows[rowIndex].Cells[6].Value.ToString();
            txtboxPassword.Text = dataView.Rows[rowIndex].Cells[7].Value.ToString();
        }

        //
        // This method is loaded when the form is loaded
        //
        private void View_Admin_User_Load(object sender, EventArgs e)
        {
            //Set the rowIndex to the first record
            rowIndex = 0;

            //Display the first record
            navigateRecord(rowIndex);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //Set the rowIndex to 0 ==> first record in DataGridView
            rowIndex = 0;

            // Call the method navigateRecord(rowIndex) to display the data of the record
            navigateRecord(rowIndex);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //Set the rowIndex to maxIndex ==> last record in DataGridView
            rowIndex = maxIndex;

            // Call the method navigateRecord(rowIndex) to display the data of the record
            navigateRecord(rowIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Check if the current row is the last row or not
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

        //
        // This method is called when the button change is clicked.
        //
        private void btnChange_Click(object sender, EventArgs e)
        {
            // Change the datetime displayed in label Birthday
            lblBirthdayValue.Text = datePickerBirthday.Value.ToString("dd/MM/yyyy");
        }

        //
        // This method is called when the button Update is clicked.
        //
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Create sql command string
            string sqlCommand = "UPDATE user_data "
                                + "SET user_first_name='" + txtboxFirstName.Text + "',"
                                + "user_last_name='" + txtboxLastName.Text + "',"
                                + "birthday='" + datePickerBirthday.Value.ToString("yyyy-MM-dd") + "',"
                                + "email='" + txtboxEmail.Text + "',"
                                + "mobile='" + txtboxMobile.Text + "',"
                                + "password='" + txtboxPassword.Text + "' "
                                + "WHERE user_id=" + dataView.Rows[rowIndex].Cells[0].Value.ToString()
                                + ";";

            //SQLConnection
            sqlConn = new MySQLConnection();

            //Execute sql command
            sqlConn.update(sqlCommand);

            MessageBox.Show("User Info has been updated successfully!");
        }
    }
}