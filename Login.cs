using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BayWynCouriersWinForm
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        public static string UserAccess;
        public static string UA
        {
            get { return UserAccess; }
            set { UserAccess = value; }
        }

        //The login method for connecting to the Users table and checking login details.

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = F:\Software Engineering\BayWynCouriersWinForm\LoginDB.mdf; Integrated Security = True; Connect Timeout = 30";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * FROM tblUsers WHERE UserName='" + tbUserName.Text + "'AND Password='" + tbPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader sdr = cmd.ExecuteReader();
                
            if (dt.Rows.Count > 0)
            {   
                dt.Load(sdr);
                DataRow dr = dt.Rows[0];
                global.AccessLevel = Convert.ToInt32(dr["AccessLevel"]);
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