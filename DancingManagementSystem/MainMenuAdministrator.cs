using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DancingManagementSystem
{
    public partial class MainMenuAdministrator : Form
    {
        //Initiate an SQL connection and DataTable
        MySQLConnection sqlConn;
        DataTable dtTable;

        //
        //Constructor
        //
        public MainMenuAdministrator()
        {
            InitializeComponent();
        }

        private void tableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Initiate a new connection object and sqlCommand string
            sqlConn = new MySQLConnection();
            string sqlCommand;

            switch (tableBox.SelectedIndex)
            {
                case 0: //If the selected table is dance_class
                    //SQL query command
                    sqlCommand = "SELECT c.class_id, c.class_title, c.class_category, i.instructor_name, c.class_venue, c.class_start_date, c.class_fee "
                    + "FROM instructor i, dance_class c "
                    + "WHERE i.instructor_id = c.class_instructor_id;";

                    // Call method select_Using_DataAdapter() to retrieve the DataTable from the query
                    dtTable = sqlConn.select_Using_DataAdapter(sqlCommand);

                    //Change the display name of column in DataTable
                    changeColumnName(0, 0);
                    //Assign the DataTable to the object DataViewGrid ==> display the table
                    dataView.DataSource = dtTable;

                    // Make the Column ID read-only, means that user can not input anything here.
                    // The ID should be generated and managed automatically by the Database System
                    this.dataView.Columns[0].ReadOnly = true;

                    //Change the title of the screen
                    lblTitle.Text = "Dance Class Management";

                    break;

                case 1: //If the selected table is user_data
                    //SQL query command
                    sqlCommand = "SELECT * FROM user_data;";

                    // Call method select_Using_DataAdapter() to retrieve the DataTable from the query
                    dtTable = sqlConn.select_Using_DataAdapter(sqlCommand);

                    //Assign the DataTable to the object DataViewGrid ==> display the table
                    dataView.DataSource = dtTable;

                    //Change the display name of column in DataTable
                    changeColumnName(1, 0);

                    // Make the Column ID read-only, means that user can not input anything here.
                    // The ID should be generated and managed automatically by the Database System
                    this.dataView.Columns[0].ReadOnly = true;

                    //Change the title of the screen
                    lblTitle.Text = "User Data Management";

                    break;

                case 2: //If the selected table is registered_class
                    //SQL query command
                    sqlCommand = "SELECT r.dance_class_class_id, c.class_title, u.* "
                                 + "FROM registered_class r, user_data u, dance_class c "
                                 + "WHERE (r.dance_class_class_id=c.class_id) AND (r.user_data_user_id=u.user_id) "
                                 + "ORDER BY r.dance_class_class_id ASC; ";

                    // Call method select_Using_DataAdapter() to retrieve the DataTable from the query
                    dtTable = sqlConn.select_Using_DataAdapter(sqlCommand);

                    //Assign the DataTable to the object DataViewGrid ==> display the table
                    dataView.DataSource = dtTable;

                    //Change the display name of column in DataTable
                    changeColumnName(2, 0);

                    // Make the Column ID read-only, means that user can not input anything here.
                    // The ID should be generated and managed automatically by the Database System
                    this.dataView.ReadOnly = true;

                    //Change the title of the screen
                    lblTitle.Text = "Registered Classes Management";

                    break;
            }// end of switch
        }// end of tableBox_SelectedIndexChanged()

        //
        // This method is called when the button Delete is clicked
        //
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedId;
            string sqlCommand;

            switch (tableBox.SelectedIndex)
            {
                case 0: //If the selected table is dance_class
                    // Get the class_id of the class that we selected (wanna delete)
                    selectedId = dataView.Rows[dataView.CurrentCell.RowIndex].Cells[0].Value.ToString();

                    //SQL Delete Command to delete the row in table 'dance_class' that has the 'class_id' = classId
                    sqlCommand = "DELETE FROM dance_class WHERE class_id=" + selectedId + ";";

                    //
                    //Initiate a new connection object
                    sqlConn = new MySQLConnection();

                    sqlConn.delete(sqlCommand);

                    //
                    //Update the DataGridView
                    //
                    foreach (DataGridViewCell oneCell in dataView.SelectedCells)
                    {
                        if (oneCell.Selected)
                            dataView.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    break;

                case 1: // If the selected table is user_data
                    // Get the user_id of the user that we selected (wanna delete)
                    selectedId = dataView.Rows[dataView.CurrentCell.RowIndex].Cells[0].Value.ToString();

                    //
                    //Initiate a new connection object
                    sqlConn = new MySQLConnection();

                    //SQL Delete Command to delete the row in table 'dance_class' that has the 'class_id' = classId
                    sqlCommand = "DELETE FROM user_data WHERE user_id=" + selectedId + ";";

                    // Execute the sql command above
                    sqlConn.delete(sqlCommand);

                    //
                    //Update the DataGridView
                    //
                    foreach (DataGridViewCell oneCell in dataView.SelectedCells)
                    {
                        if (oneCell.Selected)
                            dataView.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    break;

                case 2: // If the selected table is registered_class
                    // Get the class_id of the class that we selected (wanna delete)
                    selectedId = dataView.Rows[dataView.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    string selectedId2 = dataView.Rows[dataView.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    //
                    //Initiate a new connection object
                    sqlConn = new MySQLConnection();

                    //SQL Delete Command to delete the row in table 'dance_class' that has the 'class_id' = classId
                    sqlCommand = "DELETE FROM registered_class WHERE dance_class_class_id=" 
                                 + selectedId 
                                 + " AND user_data_user_id="
                                 + selectedId2
                                 + ";";

                    // Execute the sql command above
                    sqlConn.delete(sqlCommand);

                    //
                    //Update the DataGridView
                    //
                    foreach (DataGridViewCell oneCell in dataView.SelectedCells)
                    {
                        if (oneCell.Selected)
                            dataView.Rows.RemoveAt(oneCell.RowIndex);
                    }
                    break;
            }// end of switch

        }// end of btnDelete_Click()

        //
        // This method is called automatically when the MainMenuAdministrator form is loaded.
        //
        private void MainMenuAdministrator_Load(object sender, EventArgs e)
        {
            // Set the default selected item of combobox
            // This changing action will trigger the listener tableBox_SelectedIndexChanged()
            this.tableBox.SelectedIndex = 0;
        }// end of MainMenuAdministrator_Load()

        //
        //This method is to change the display name of the column in the DataGridView
        //
        private void changeColumnName(int table, int column)
        {
            switch (table)
            {
                case 0: // If the current table is dance_class
                    if (column == 0)
                    {
                        dtTable.Columns["class_id"].ColumnName = "Class ID";
                        dtTable.Columns["class_title"].ColumnName = "Class Name";
                        dtTable.Columns["class_category"].ColumnName = "Category";
                        dtTable.Columns["instructor_name"].ColumnName = "Instructor";
                        dtTable.Columns["class_venue"].ColumnName = "Venue";
                        dtTable.Columns["class_start_date"].ColumnName = "Start Date";
                        dtTable.Columns["class_fee"].ColumnName = "Fee";
                    } else
                    {
                        dtTable.Columns["Class ID"].ColumnName = "class_id";
                        dtTable.Columns["Class Name"].ColumnName = "class_title";
                        dtTable.Columns["Category"].ColumnName = "class_category";
                        dtTable.Columns["Instructor"].ColumnName = "instructor_name";
                        dtTable.Columns["Venue"].ColumnName = "class_venue";
                        dtTable.Columns["Start Date"].ColumnName = "class_start_date";
                        dtTable.Columns["Fee"].ColumnName = "class_fee";
                    }
                    break;
                case 1: // If the current table is user_data
                    if (column == 0)
                    {
                        dtTable.Columns["user_id"].ColumnName = "User ID";
                        dtTable.Columns["user_first_name"].ColumnName = "First Name";
                        dtTable.Columns["user_last_name"].ColumnName = "Last Name";
                        dtTable.Columns["birthday"].ColumnName = "Birthday";
                        dtTable.Columns["email"].ColumnName = "Email address";
                        dtTable.Columns["mobile"].ColumnName = "Mobile";
                        dtTable.Columns["username"].ColumnName = "Username";
                    }
                    else
                    {
                        dtTable.Columns["User ID"].ColumnName = "user_id";
                        dtTable.Columns["First Name"].ColumnName = "user_first_name";
                        dtTable.Columns["Last Name"].ColumnName = "user_last_name";
                        dtTable.Columns["Birthday"].ColumnName = "birthday";
                        dtTable.Columns["Email address"].ColumnName = "email";
                        dtTable.Columns["Mobile"].ColumnName = "mobile";
                        dtTable.Columns["Username"].ColumnName = "username";
                    }
                    break;
                case 2: // If the current table is registered_class
                    if (column == 0)
                    {
                        dtTable.Columns["dance_class_class_id"].ColumnName = "Class ID";
                        dtTable.Columns["class_title"].ColumnName = "Class Name";
                        dtTable.Columns["user_id"].ColumnName = "User ID";
                        dtTable.Columns["user_first_name"].ColumnName = "First Name";
                        dtTable.Columns["user_last_name"].ColumnName = "Last Name";
                        dtTable.Columns["birthday"].ColumnName = "Birthday";
                        dtTable.Columns["email"].ColumnName = "Email address";
                        dtTable.Columns["mobile"].ColumnName = "Mobile";
                        dtTable.Columns["username"].ColumnName = "Username";
                    }
                    else
                    {
                        dtTable.Columns["Class ID"].ColumnName = "dance_class_class_id";
                        dtTable.Columns["Class Name"].ColumnName = "class_title";
                        dtTable.Columns["User ID"].ColumnName = "user_id";
                        dtTable.Columns["First Name"].ColumnName = "user_first_name";
                        dtTable.Columns["Last Name"].ColumnName = "user_last_name";
                        dtTable.Columns["Birthday"].ColumnName = "birthday";
                        dtTable.Columns["Email address"].ColumnName = "email";
                        dtTable.Columns["Mobile"].ColumnName = "mobile";
                        dtTable.Columns["Username"].ColumnName = "username";
                    }
                    break;
            }// end of switch
        }// end of changeColumnName()

        private void modify_Class_Item(object sender, EventArgs e)
        {
            //Change to User Info table
            tableBox.SelectedIndex = 0;

            //Create a new Form View
            var form1 = new View_Admin_Class(dataView, sqlConn);
            form1.ShowDialog();
        }

        private void modify_User_Item(object sender, EventArgs e)
        {
            //Change to User Info table
            tableBox.SelectedIndex = 1;

            //Create a new Form View
            var form2 = new View_Admin_User(dataView,sqlConn);
            form2.ShowDialog();
        }

        private void modify_Registered_Item(object sender, EventArgs e)
        {
            //Change to User Info table
            tableBox.SelectedIndex = 2;

            //Create a new Form View
            var form3 = new View_Admin_Registered(sqlConn);
            form3.ShowDialog();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //

    }// end of class MainMenuAdministrator
}
