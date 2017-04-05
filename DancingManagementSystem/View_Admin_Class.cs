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
    public partial class View_Admin_Class : Form
    {
        //variables
        private MySQLConnection sqlConn;
        private int minIndex = 0;
        private int maxIndex;
        private int rowIndex = 0;
        private DataGridView dataView;
        private DataTable dtTable;
        
        //
        // Constructor
        //
        public View_Admin_Class(DataGridView dataView, MySQLConnection sqlConn)
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
            txtboxName.Text = dataView.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxCategory.Text = dataView.Rows[rowIndex].Cells[2].Value.ToString();
            lblInstructorValue.Text = dataView.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxVenue.Text = dataView.Rows[rowIndex].Cells[4].Value.ToString();
            lblStartDateValue.Text = dataView.Rows[rowIndex].Cells[5].Value.ToString().Remove(10);
            txtboxFee.Text = dataView.Rows[rowIndex].Cells[6].Value.ToString();
        }

        //
        // This method is loaded when the form is loaded
        //
        private void View_Admin_Class_Load(object sender, EventArgs e)
        {
            //Set the rowIndex to the first record
            rowIndex = 0;

            // Get the list of available instructors from the database and add the list to combo box
            // + Connect to DB and Select the list of all instructor's names and their id
            // + Populate the name list to the ComboBox
            sqlConn = new MySQLConnection();
            string sqlCommand = "SELECT instructor_name, instructor_id FROM instructor ORDER BY instructor_id ASC;";
            dtTable = sqlConn.select_Using_DataAdapter(sqlCommand); //this method return a DataTable object

            //Populate the list from dtTable to the comboBox
            comboInstructor.DataSource = dtTable;
            comboInstructor.DisplayMember = "instructor_name";
            comboInstructor.ValueMember = "instructor_id";

            //Set the default index when the form is first loaded.
            comboInstructor.SelectedIndex = 0;

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

        private void btnLast_Click(object sender, EventArgs e)
        {
            //Set the rowIndex to maxIndex ==> last record in DataGridView
            rowIndex = maxIndex;

            // Call the method navigateRecord(rowIndex) to display the data of the record
            navigateRecord(rowIndex);
        }

        //
        // This method is called when the button Update is clicked.
        //
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Create sql command string
            string sqlCommand = "UPDATE dance_class "
                                + "SET class_title='" + txtboxName.Text + "',"
                                + "class_category='" + txtboxCategory.Text + "',"
                                + "class_instructor_id='" + comboInstructor.SelectedValue.ToString() + "',"
                                + "class_venue='" + txtboxVenue.Text + "',"
                                + "class_start_date='" + datePickerStartDate.Value.ToString("yyyy-MM-dd") + "',"
                                + "class_fee='" + txtboxFee.Text + "' "
                                + "WHERE class_id=" + dataView.Rows[rowIndex].Cells[0].Value.ToString()
                                + ";";

            //SQLConnection
            sqlConn = new MySQLConnection();

            //Execute sql command
            sqlConn.update(sqlCommand);

            //Inform the user
            MessageBox.Show("The class has been updated successfully!");
            //MessageBox.Show(sqlCommand);

            //After successfully updating the database, change the datagridview
            dataView[1, rowIndex].Value = txtboxName.Text;
            dataView[2, rowIndex].Value = txtboxCategory.Text;
            dataView[3, rowIndex].Value = comboInstructor.GetItemText(comboInstructor.SelectedItem);
            dataView[4, rowIndex].Value = txtboxVenue.Text;
            dataView[5, rowIndex].Value = datePickerStartDate.Value.ToString("dd/MM/yyyy");
            dataView[6, rowIndex].Value = txtboxFee.Text;

        }// end of btnUpdate_Click()

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //sql connection
            sqlConn = new MySQLConnection();

            //insert comamnd
            string sqlCommand = "INSERT INTO dance_class VALUES (null,'"
                                + txtboxName.Text + "','"
                                + txtboxCategory.Text + "','"
                                + comboInstructor.SelectedValue.ToString() + "','"
                                + txtboxVenue.Text + "','"
                                + datePickerStartDate.Value.ToString("yyyy-MM-dd") + "','"
                                + txtboxFee.Text + "');";

            sqlConn.insert(sqlCommand);

            MessageBox.Show("Add new class successfully!");
            //MessageBox.Show(sqlCommand);
        }
    }// end of class
}
