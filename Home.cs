using BayWynCouriersWinForm.bwcDSTableAdapters;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BayWynCouriersWinForm
{
 
    public partial class Home : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Home()
        {
            InitializeComponent();
            HidePanels();   
            CheckLevel();   
        }

        private void CheckLevel()
        { 
            if (User.AccessLevel == 4)
            {
                btnAssignments.Show();
                panelAssignments.Show();
            }
        }


        /// <summary>
        /// Method to open the databadsse connection
        /// </summary>
        private void ConnectToDb()
        {
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Toxic\source\repos\hlr110320\BayWynCouriers\bwc.accdb";
        }


        /// <summary>
        /// Method to hide all panels on the form - used for user access control
        /// </summary>
        private void HidePanels()
        {  
            panelReports.Hide();
            panelDeliveries.Hide();
            panelClients.Hide();
            panelAssignments.Hide();
        }


        /// <summary>
        /// Reports function which queries the database. The access level determins which reports are available and are set in the Reports class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReports_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelReports.Show();

            // Logic to check which access level is logged in, and populate the combo box with reports for the access level.
            if (User.AccessLevel == 1)
            {
                cbReports.Items.Clear();
                cbReports.Items.AddRange(Reports.getAl1Reports());

            }
            else if (User.AccessLevel == 2)
            {
                cbReports.Items.Clear();
                cbReports.Items.Add(Reports.getAl2Reports());
            }
            else if (User.AccessLevel == 3)
            {
                cbReports.Items.Clear();
                cbReports.Items.AddRange(Reports.getAl3Reports());
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelClients.Show();
        }

        private void btnAssignments_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelAssignments.Show();
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelDeliveries.Show();
        }

    
        private void btnGenReport_Click(object sender, EventArgs e)
        {

        }
    }
}
