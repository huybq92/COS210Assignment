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
    public partial class View_User_User : Form
    {
        //
        //Constructor
        //
        public View_User_User(DataGridView dataView)
        {
            InitializeComponent();

            //Assign values 
            lblFirstNameValue.Text = dataView.Rows[0].Cells[1].Value.ToString();
            lblLastNameValue.Text = dataView.Rows[0].Cells[2].Value.ToString();
            lblBirthdayValue.Text = dataView.Rows[0].Cells[3].Value.ToString().Remove(10);
            lblEmailValue.Text = dataView.Rows[0].Cells[4].Value.ToString();
            lblMobileValue.Text = dataView.Rows[0].Cells[5].Value.ToString();
            lblUsernameValue.Text = dataView.Rows[0].Cells[6].Value.ToString();
        }

        //
        // Overload the above constructor with different parameters
        //
        public View_User_User(string[] user)
        {
            InitializeComponent();

            //Assign values 
            lblFirstNameValue.Text = user[1];
            lblLastNameValue.Text = user[2];
            lblBirthdayValue.Text = user[3].Remove(10);
            lblEmailValue.Text = user[4];
            lblMobileValue.Text = user[5];
            lblUsernameValue.Text = user[6];
        }

    }
}
