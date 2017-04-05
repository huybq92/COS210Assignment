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
    public partial class View_User_Registered : Form
    {
        //
        //Variables
        private int minIndex = 0;
        private int maxIndex;
        private int rowIndex = 0;
        private DataGridView dataView;

        //
        // Constructor
        // The MainMenu form will pass its SQLConnection & DataGridView to this FormView 
        // so that this FormView can navigate the data and update the data to The Database
        public View_User_Registered(DataGridView dataView)
        {
            //Initiate the visual window form
            InitializeComponent();

            // Assign the dataView that the Mainmenu form passes to this form
            this.dataView = dataView;

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

        private void navigateRecord(int rowIndex)
        {
            lblNameValue.Text = dataView.Rows[rowIndex].Cells[1].Value.ToString();
            lblCategoryValue.Text = dataView.Rows[rowIndex].Cells[2].Value.ToString();
            lblInstructorValue.Text = dataView.Rows[rowIndex].Cells[3].Value.ToString();
            lblVenueValue.Text = dataView.Rows[rowIndex].Cells[4].Value.ToString();
            lblStartDateValue.Text = dataView.Rows[rowIndex].Cells[5].Value.ToString().Remove(10);
            lblFeeValue.Text = dataView.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void View_User_Registered_Load(object sender, EventArgs e)
        {
            //Set the rowIndex to the first record
            rowIndex = 0;

            //Display the first record
            navigateRecord(rowIndex);
        }
    }
}
