using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            panelReports.Hide();
            panelDeliveries.Hide();
            panelCustomers.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            panelReports.Show();
            panelDeliveries.Hide();
            panelCustomers.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            panelCustomers.Show();
            panelReports.Hide();
            panelDeliveries.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            panelDeliveries.Show();
            panelCustomers.Hide();
            panelReports.Hide();
        }
    }
}
