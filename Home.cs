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
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Toxic\source\repos\hlr110320\BayWynCouriers\bwc.accdb";
        }

        private void Home_Load(object sender, EventArgs e)
        {

            panelReports.Hide();
            panelDeliveries.Hide();
            panelClients.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panelDeliveries.Hide();
            panelClients.Hide();
            panelReports.Show();

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            panelReports.Hide();
            panelDeliveries.Hide();
            panelClients.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            panelClients.Hide();
            panelReports.Hide();
            panelDeliveries.Show();
        }

        private void tbBAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reportDaily = "Day Courier Assignments";
            string reportMonthly = "Month Courier Assignments";
            string reportAll = "All assignments for given month";
            string reportValue = "Value of contracts for given month";

            if (User.AccessLevel == 1)
            {
                cbReports.Items.Add(reportDaily).ToString();
                cbReports.Items.Add(reportMonthly).ToString();
                cbReports.Items.Add(reportAll).ToString();
                cbReports.Items.Add(reportValue).ToString();
  
            }
            else if (User.AccessLevel == 2)
            {
                MessageBox.Show("htest");
                cbReports.DataSource = (new string[] { "hello", "EGG" });
                // cbReports.Items.Add(reportAll);
            }
            else if (User.AccessLevel == 3)
            {

                cbReports.Items.AddRange(new string[] { reportDaily, reportMonthly });
            }
        }

        private void dataGridReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {

        }
    }
}
