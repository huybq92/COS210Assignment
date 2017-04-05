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
    public partial class MainMenu : Form
    {
        //Initiate an SQL connection and DataTable
        private MySQLConnection sqlConn;
        private DataTable dtTable;

        //
        //Constructor
        //
        public MainMenu()
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

                    //Assign the DataTable to the object DataViewGrid ==> display the table
                    dataView.DataSource = dtTable;

                    // Change the display name of the columns
                    changeColumnName(0);

                    // Make the Column ID read-only, means that user can not input anything here.
                    // The ID should be generated and managed automatically by the Database System
                    this.dataView.ReadOnly = true;

                    //Change the title of the screen
                    lblTitle.Text = "Current Dance Classes";

                    break;

                case 1: //If the selected table is registered_class
                    //SQL query command
                    sqlCommand = "SELECT c.class_id, c.class_title, c.class_category, i.instructor_name, c.class_venue, c.class_start_date, c.class_fee "
                                    + "FROM registered_class rc, dance_class c, instructor i "
                                    + "WHERE c.class_id = rc.dance_class_class_id "
                                    + "AND i.instructor_id = c.class_instructor_id "
                                    + "AND user_data_user_id="
                                    + MySQLConnection.getUserId() + ";";

                    // Call method select_Using_DataAdapter() to retrieve the DataTable from the query
                    dtTable = sqlConn.select_Using_DataAdapter(sqlCommand);

                    //Assign the DataTable to the object DataViewGrid ==> display the table
                    dataView.DataSource = dtTable;

                    // Change the display name of the columns
                    changeColumnName(1);

                    // Make the Column ID read-only, means that user can not input anything here.
                    // The ID should be generated and managed automatically by the Database System
                    this.dataView.ReadOnly = true;

                    //Change the title of the screen
                    lblTitle.Text = "You've already registered for following classes";

                    break;

                case 2: //If the selected table is user_data
                    //SQL query command
                    sqlCommand = "SELECT * FROM user_data WHERE user_id=" + MySQLConnection.getUserId() + ";";

                    // Call method select_Using_DataAdapter() to retrieve the DataTable from the query
                    dtTable = sqlConn.select_Using_DataAdapter(sqlCommand);

                    //Assign the DataTable to the object DataViewGrid ==> display the table
                    dataView.DataSource = dtTable;

                    // Change the display name of the columns
                    changeColumnName(2);

                    // Make the Column ID read-only, means that user can not input anything here.
                    // The ID should be generated and managed automatically by the Database System
                    this.dataView.ReadOnly = true;

                    //Change the title of the screen
                    lblTitle.Text = "Your Personal Information";

                    break;
            }// end of switch
        }// end of tableBox_SelectedIndexChanged()

        //
        // This method is called automatically when the MainMenu form is loaded.
        //
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Set the default selected item of combobox
            // This changing action will trigger the listener tableBox_SelectedIndexChanged()
            this.tableBox.SelectedIndex = 0;

        }// end of MainMenu_Load()

        //
        //This method is to change the display name of the column in the DataGridView
        //
        private void changeColumnName(int table)
        {
            switch (table)
            {
                case 0: // If the current table is dance_class
                    dtTable.Columns["class_id"].ColumnName = "Class ID";
                    dtTable.Columns["class_title"].ColumnName = "Class Name";
                    dtTable.Columns["class_category"].ColumnName = "Category";
                    dtTable.Columns["instructor_name"].ColumnName = "Instructor";
                    dtTable.Columns["class_venue"].ColumnName = "Venue";
                    dtTable.Columns["class_start_date"].ColumnName = "Start Date";
                    dtTable.Columns["class_fee"].ColumnName = "Fee";
                    break;

                case 1: // If the current table is registered_class
                    dtTable.Columns["class_id"].ColumnName = "Class ID";
                    dtTable.Columns["class_title"].ColumnName = "Class Name";
                    dtTable.Columns["class_category"].ColumnName = "Category";
                    dtTable.Columns["instructor_name"].ColumnName = "Instructor";
                    dtTable.Columns["class_venue"].ColumnName = "Venue";
                    dtTable.Columns["class_start_date"].ColumnName = "Start Date";
                    dtTable.Columns["class_fee"].ColumnName = "Fee";
                    break;

                case 2: // If the current table is user_data
                        dtTable.Columns["user_id"].ColumnName = "User ID";
                        dtTable.Columns["user_first_name"].ColumnName = "First Name";
                        dtTable.Columns["user_last_name"].ColumnName = "Last Name";
                        dtTable.Columns["birthday"].ColumnName = " Birthday";
                        dtTable.Columns["email"].ColumnName = "Email address";
                        dtTable.Columns["mobile"].ColumnName = " Mobile";
                        dtTable.Columns["username"].ColumnName = "Username";
                    break;

            }// end of switch
        }// end of changeColumnName()

        //
        // This method is to handle the click event generated by menu item 'Register for class'
        //
        private void register_Click(object sender, EventArgs e)
        {
            //Change the current table to dance_class
            tableBox.SelectedIndex = 0;

            //Generate formview
            var formView1 = new View_User_Class(dataView, sqlConn);
            formView1.ShowDialog();

        }// end of viewToolStripMenuItem_Click()

        //
        //This method is to handle the click event generated by menu item 'Registered Classes'
        //
        private void registered_class_Click(object sender, EventArgs e)
        {
            //Change the current table to dance_class
            tableBox.SelectedIndex = 1;

            //Generate formview
            var formView2 = new View_User_Registered(dataView);
            formView2.ShowDialog();
        }

        //
        //This method is to handle the click event generated by menu item 'Your Personal Info'
        //
        private void personal_info_Click(object sender, EventArgs e)
        {
            //Change the current table to dance_class
            tableBox.SelectedIndex = 2;

            //Generate formview
            var formView3 = new View_User_User(dataView);
            formView3.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenu = new MainMenuAdministrator();
            mainMenu.Closed += (s, args) => this.Close();
            mainMenu.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }// end of class MainMenu
}
