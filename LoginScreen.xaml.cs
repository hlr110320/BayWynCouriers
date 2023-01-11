//BayWynCouriers tracking system
//Hayley Roberts
//110320

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BayWynCouriersWPF
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        //Method to allow the login window to be moved using the left click mouse button
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        //Method to minimize the login window on minimize button click.
        private void BtnLoginMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //Method to close the login window on close button click.
        private void BtnLoginClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Event handler for clicking the submit button to call the login method
        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            LoginCon();
        }

        //Event handler for the password box to call the login method when pressing the ENTER key
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //IF statement checks that the ENTER key is pressed and then calls the method to login
            if (e.Key == Key.Return)
            {
                LoginCon();
            }
            else if (e.Key == Key.Enter)
            {
                LoginCon();
            }
            else if (e.Key == Key.Enter)
            {
                LoginCon();
            }
        }

        //The login method for connecting to the Users table and checking login details.
        void LoginCon()
        { 
            SqlConnection sqlCon = new SqlConnection(@"Data Source=mystic-haylo; Initial Catalog = LoginDB; Integrated Security = True");          
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                
                //Query to the users table for username and password
                String query = "SELECT COUNT(1) FROM tblUsers WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon)
                {
                    CommandType = CommandType.Text
                };

                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.");
                }
            }
            
            //Error message display for incorrect username OR password
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Closes the SQL connection after Login attempt
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
