using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace DancingManagementSystem
{
    public class MySQLConnection
    {
        //
        //Variables Declaration
        //
        private MySqlConnection conn;
        private MySqlDataAdapter dtAdapter;
        private DataTable dtTable;
        private string sqlString;

        //
        //Static variable session_user_id to store the user_id of the current logging in User
        //
        private static int session_user_id;

        //
        //Constructors
        //
        public MySQLConnection()
        {
            //Assign values
            string srv = "localhost";
            string db = "dancing_system";
            string user = "root";
            string pass = "tr*baV4S";

            //A single string that will be passed to the object MysqlConnection as a parameter
            sqlString = "SERVER=" + srv + ";" + "DATABASE=" +
                                db + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";

            //Call initialize() to initiate a connection object
            initialize();
            
        }

        //
        // Overload the constructor with a different parameter
        //
        public MySQLConnection(string sqlString)
        {
            //Assign sqlString
            this.sqlString = sqlString;

            //Call initialize() to initiate a connection object
            initialize();
        }

        //
        //Initialize() method
        //
        public void initialize()
        {
            //
            //Initiate a connection object
            conn = new MySqlConnection(sqlString);
        }//end of initialize()

        //
        // Method open(): open the connection to MySQL Database using the connection object that's already
        // been initiated in the Constructor.
        // This method return true if the connection is established successfully and return false 
        // the other way around!
        public bool open()
        {
            try
            {
                //
                //open the connection
                conn.Open();
                //
                // When application reaches this "return true" command,
                // it means that the previous statement "conn.Open()" was successfully executed,
                // and the connection has been established!
                // If "conn.Open()" can't be executed successfully, the application skip "return true" 
                // and jumps to catch block below to show error's details.
                return true;
            }
            catch (MySqlException ex)
            {
                //
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }//end of open()

        //
        // Method close(): close the existing connection to MySQL Database.
        // This method return true if the connection is closed successfully and return false 
        // the other way around!
        public bool close()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }//end of close()

        //
        //Method insert():  + Open connection to MySQL
        //                  + Pass the parameter to the MySqlCommand object and execute this object to
        //                      apply the SQL commands to the Database
        //                  + Finally, close the connection.
        public void insert(string sqlCommand)
        {
            //Open connection
            if (this.open() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                //
                //Execute command
                cmd.ExecuteNonQuery();
                //
                //close connection
                this.close();
            }
        }

        //
        //Method update():  + Open connection to MySQL
        //                  + Pass the parameter to the MySqlCommand object and execute this object to
        //                      apply the SQL commands to the Database
        //                  + Finally, close the connection.
        public void update(string sqlCommand)
        {
            //Open connection
            if (this.open() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                //
                //Execute query
                cmd.ExecuteNonQuery();
                //
                //close connection
                this.close();
            }
        }

        //
        //Method delete():  + Open connection to MySQL
        //                  + Pass the parameter to the MySqlCommand object and execute this object to
        //                      apply the SQL commands to the Database
        //                  + Finally, close the connection.
        public void delete(string sqlCommand)
        {
            if (this.open() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                cmd.ExecuteNonQuery();

                this.close();
            }
        }// end of delete()

        //
        //Method select_Using_DataReader():  
        //                  + Open connection to MySQL
        //                  + Pass the string parameter to the MySqlCommand object and execute this command
        //                      by calling method ExecuteReader to apply to the Database.
        //                  + The result of the query will be stored in the parameter dtReader
        //                  + Finally, return MySqlDataReader object
        //                  + REMEMBER: This method will NOT close the SQL connection. Therefore, after calling this method,
        //                              we have to manually close the connection using method close()
        public MySqlDataReader select_Using_DataReader(string sqlCommand)
        {
            //
            //Open connection
            if (this.open() == true)
            {

                // Create Command
                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dtReader = cmd.ExecuteReader();

                return dtReader;
            }
            return null;
        }// end of select_Using_DataReader()

        //
        //
        public DataTable select_Using_DataAdapter(string sqlCommand)
        {
            //
            //Open connection
            if (this.open() == true)
            {
                //Create a DataAdapter object
                dtAdapter = new MySqlDataAdapter(sqlCommand, conn);
                dtTable = new DataTable();
                dtAdapter.Fill(dtTable);
                return dtTable;
            }
            return null;
        }// end of select_Using_DataAdapter()

        //
        // Static set() method to assign the private static variable 'session_user_id'
        //
        public static void setUserId(int user_id)
        {
            session_user_id = user_id;
        }

        //
        // Static get() method to retrieve the value of 'session_user_id'
        //
        public static int getUserId()
        {
            return session_user_id;
        }

    }// end of class MySQLConnection
}// end of namespace DancingManagementSystem
