using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BayWynCouriersWinForm;

namespace BayWynCouriersWinForm
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string ual = global.AccessLevel.ToString();
            lbTest.Text = ual;
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
            int AccessLevel = 2;
            string reportDaily = "Day Courier Assignments";
            string reportMonthly = "Month Courier Assignments";
            string reportAll = "All assignments for given month";
            string reportValue = "Value of contracts for given month";

            if (AccessLevel == 1)
            { 
                cbReports.Items.AddRange(new string[] { reportDaily, reportMonthly, reportAll, reportValue });
            }
            else if (AccessLevel == 2)
            {
                cbReports.Items.Add(reportAll);
            }
            else if (AccessLevel == 3)
            {
                cbReports.Items.AddRange(new string[] { reportDaily, reportMonthly });
            }
        }

        private void dataGridReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }
    }
}
