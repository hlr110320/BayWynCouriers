using BayWynCouriersWinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BayWynCouriersWinForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //The login method for connecting to the Users table and checking login details.

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\Software Engineering\BayWynCouriersWinForm\LoginDB.mdf; Integrated Security = True; Connect Timeout = 30";
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserName,Password FROM tblUsers WHERE UserName='" + tbUserName.Text + "'AND Password='" + tbPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Home h = new Home();
                h.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect.");
                tbUserName.Text = "";
                tbPassword.Text = "";

            }
        }
    }
}



//            try
//                {
//                    if (sqlCon.State == System.Data.ConnectionState.Closed)
//                        sqlCon.Open();

//                    //Query to the users table for username and password
//                    String query = "SELECT COUNT(1) FROM tblUsers WHERE Username=@Username AND Password=@Password";
//                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon)
//                    {
//                        CommandType = CommandType.Text
//                    };

//                    sqlCmd.Parameters.AddWithValue("@Username", tbUserName.Text);
//                    sqlCmd.Parameters.AddWithValue("@Password", tbPassword.PasswordChar);
//                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

//                    if (count == 1)
//                    {
//                        Home h = new Home();
//                        h.Show();
//                        this.Close();
//                    }
//                    else
//                    {
//                        MessageBox.Show("Username or Password is incorrect.");
//                        tbUserName.Text = "";
//                        tbPassword.Text = "";
//                    }
//                }

//                //Error message display for incorrect username OR password
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message);
//                }

//                //Closes the SQL connection after Login attempt
//                finally
//                {
//                    sqlCon.Close();
//                }
//            }
//        }
//    }


//////Method to allow the login window to be moved using the left click mouse button
////private void Form_MouseDown(object sender, MouseButtonEventArgs e)
////{
////    if
////                if (e.LeftButton == MouseButtonState.Pressed)
////            DragMove();
////}

//////Method to minimize the login window on minimize button click.
////private void BtnLoginMin_Click(object sender, RoutedEventArgs e)
////{
////    WindowState = WindowState.Minimized;
////}

//////Method to close the login window on close button click.
////private void BtnLoginClose_Click(object sender, RoutedEventArgs e)
////{
////    Application.Current.Shutdown();
////}

//////Event handler for clicking the submit button to call the login method
////private void BtnSubmit_Click(object sender, RoutedEventArgs e)
////{
   
////}

//////Event handler for the password box to call the login method when pressing the ENTER key
////private void txtPassword_KeyDown(object sender, KeyEventArgs e)
////{
////    //IF statement checks that the ENTER key is pressed and then calls the method to login
////    if (e.Key == Key.Return)
////    {
//        LoginCon();
//    }
//    else if (e.Key == Key.Enter)
//    {
//        LoginCon();
//    }
//    else if (e.Key == Key.Enter)
//    {
//        LoginCon();
//    }
//}


//        }
//    }

