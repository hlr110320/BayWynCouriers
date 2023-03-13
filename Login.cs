using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;



namespace BayWynCouriersWinForm
{
    public partial class Login : Form
    {
        public OleDbConnection con = new OleDbConnection();

        public Login()
        {
            InitializeComponent();
        }

        /// Login Method
        /// 
        /// Opens the connection to the BWC database which holds the login data.
        /// Queries the database using the Username and Password data inputted.
        /// If the data matches the Users table, the home page will open. otherwise an error message will be displayed.
        /// The database connection is closed.
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Initialisation of the database connection string
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Toxic\source\repos\hlr110320\BayWynCouriers\bwc.mdb";

            // Open connection to the database
            con.Open();
 
            //Initialises database command and query and fills the datatable with the returned results
            OleDbCommand cmdLogin = new OleDbCommand();
            OleDbDataAdapter daLogin = new OleDbDataAdapter(cmdLogin);
            cmdLogin.Connection = con;

            // The query is populated using the username and password inputs
            cmdLogin.CommandText = "select * FROM Users WHERE UserName='" + tbUserName.Text + "'AND Password='" + tbPassword.Text + "'";
            DataTable dt = new DataTable();
            daLogin.Fill(dt);

            // If the count is 1 the login is successful
            if (dt.Rows.Count > 0)
            {
                // The user access level and username are read from the database and stored in the users class

                OleDbDataReader reader = cmdLogin.ExecuteReader();
                dt.Load(reader);

                DataRow dr = dt.Rows[0];
                string un = dr[1].ToString();
                string ul = dr[3].ToString();
                User.UserName = un;
                User.AccessLevel = Convert.ToInt32(ul);
                this.Hide();
                Home h = new Home();
                h.Show();
            }

            else
            {
                //Error message displays and input text boxes are cleared
                MessageBox.Show("Username or Password is incorrect.");
                tbUserName.Text = "";
                tbPassword.Text = "";
            }

            // Close connection
            con.Close();
        }
    }
}

