using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BayWynCouriersWinForm
{
    public partial class Home : Form
    {
        Assignments objA;
        Clients objC;
        Clients objVC;
        Reports objR;
        Reports objEC;
        DataRow dr;
        DataSet ds;
        DataSet ds1;

        private readonly OleDbConnection con = new OleDbConnection();
        public Home()
        {
            InitializeComponent();

            HidePanels();

            // Checks the user access level to set form controls
            CheckLevel();
            // Displays logged in username and access level on the form
            lbUser.Text = "Logged in User: " + User.UserName.ToString() + ", Access: " + User.AccessLevel.ToString();
        }

        /// <summary>
        /// Method for checking the user access keveks and showing/hiding the relevant form controls.
        /// !! Further development - a more efficient way of doing this.
        /// </summary>
        public void CheckLevel()
        {
            if (User.AccessLevel == 4)
            {
                HideForAl4();
                HidePanels();
                btnAssignments.Show();
                panelAssignments.Show();
            }

            if (User.AccessLevel == 3)
            {
                HideForAl3();
                HidePanels();
                btnContracts.Show();
            }
        }


        /// <summary>
        /// Method to open the database connection
        /// </summary>
        public void ConnectToDb()
        {
            con.Open();
        }


        /// <summary>
        /// Method to hide the buttons which access level 4 users do not have permission to access - used for user access control
        /// </summary>
        private void HideForAl4()
        {
            btnReports.Hide();
            btnContracts.Hide();
            btnDeliveries.Hide();
        }

        /// <summary>
        /// Method to hide the buttons which access level 3 users do not have permission to access - used for user access control
        /// </summary>
        private void HideForAl3()
        {
            btnContracts.Hide();
            btnDeliveries.Hide();
        }

        /// <summary>
        /// Method to hide all panels on the form - used for user access control and to only show the panel associated with the button clicked.
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
        private void BtnReports_Click(object sender, EventArgs e)
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

        // Client event for the Contracts button
        private void BtnContracts_Click(object sender, EventArgs e)
        {
            // Calls the hide panels method to hide all panels
            HidePanels();

            //Shows the clients panel
            panelClients.Show();

            //Checks if access level is 3
            if (User.AccessLevel == 3)
            {
                // Shows and hides the appropriate controls
                ContractRuns.Show();
                cbClientType.Hide();
                tbCourierRuns.Hide();
                ContractRuns.Hide();
                this.dataGridViewContracts.ReadOnly = true;
            }

            // Calls the ClearDGContracts method to clear the datagridview
            ClearDGContracts();

            // Calls the update view contracts method to refresh the contracts datagrid from the database
            ViewContractsDG();

        }

        // The method to update the datagrid with the clients table
        private void ViewContractsDG()
        {
            objVC = new Clients();
            ds = objVC.ViewContracts();

            // Gets the data and populates the Data grid with values
            dr = ds.Tables[0].Rows[0];
            DGViewContracts.DataSource = ds.Tables[0];
        }
        private void btnCreateContract_Click(object sender, EventArgs e)
        {

            //If statement to provide an error message if client type is default and only adds a new client if aa type is selected
            if (cbClientType.Text == "Client Type")
            {
                MessageBox.Show("Please select a client type");
            }

            else
            {
                // Creates a new object of the client class
                objC = new Clients();

                // Sets the client class parameters with the values inputted on the form
                objC.ClientName = tbBName.Text;
                objC.ClientPhone = tbBTel.Text;
                objC.ClientEmail = tbBEmail.Text;
                objC.ClientAdd = tbBAdd.Text;
                objC.ClientInfo = tbBNotes.Text;
                objC.ClientStartDate = DateTime.Today;
                objC.ContractType = cbClientType.Text;

                // Calls the function to add the new contract to the database
                objC.AddNewContract();

                //Clears the form
                btnCClear.PerformClick();
            }
        }

        private void btnCClear_Click(object sender, EventArgs e)
        {
            // Clears the contracts form
            tbCourierRuns.Text = "";
            tbBName.Text = "";
            tbBAdd.Text = "";
            tbBEmail.Text = "";
            tbBNotes.Text = "";
            tbBTel.Text = "";
            tbBTel.Text = "";
        }

        // Clears the datagrid view
        private void ClearDGContracts()
        {
            DGViewContracts.DataSource = null;
            DGViewContracts.Rows.Clear();
        }

        //Click event to call the ViewContractsDG method which will refresh the datagrid with the current data in the 
        // clients table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewContractsDG();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DGViewContracts.Update();
             
        }


        private void BtnAssignments_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelAssignments.Show();
        }

        private void BtnDeliveries_Click(object sender, EventArgs e)
        {
            HidePanels();
            panelDeliveries.Show();

            BindcbBName();

            DateTime date = DatePicker.Value;

            Deliveries objD = new Deliveries();
            objD.Date = date;
        }

        private void BindcbBName()
        {
            ds = bwcDataSet;
            cbBName.DataSource = ds.Tables["Clients"];
            cbBName.DisplayMember = "ClientName";
        }

        private void BindcbCouriers()
        {
            ds1 = bwcDataSet;
            cbCouriers.DataSource = ds.Tables["Couriers"];
            cbCouriers.DisplayMember = "CourierID";
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            Deliveries objD = new Deliveries();
            DateTime date = DatePicker.Value;

            objD.Date = date; 
        }
        private void BtnGenReport_Click(object sender, EventArgs e)
        {
            // Calls the method to clear the datagrid to avoid re-adding existing data
            ClearDGReports();

            // Creates a new instance of the report class
            objR = new Reports();

            string chosenReport = cbReports.Text;
            objR._ChosenReport = chosenReport;
            string courier = cbCouriers.Text;
            objR._CourierID = courier;


            if (cbReports.Text == "Choose a report")
            {
                MessageBox.Show("Please select a choice from the combo box.");
            }

            if (cbReports.Text == "Day Courier Assignments")
            {
                ds = objR.GetDayAssignmentsReport();
            }

            else if (cbReports.Text == "Month Courier Assignments")
            {
                ds = objR.GetMonthAssignmentsReport();
            }

            if (cbReports.Text == "All assignments for given month")
            {
                ds = objR.GetAllAssignmentsMonthReport();
            }

            else if (cbReports.Text == "Value of contracts for given month")
            {
                ds = objR.GetMonthContractValueReport();
            }

            // Gets the data and populates the Data grid with values
            dr = ds.Tables[0].Rows[0];
            dataGridAssignments.DataSource = ds.Tables[0];
        }

        //Method to clear the reports datagrid data
        private void ClearDGReports()
        {
            dataGridReports.DataSource = null;
            dataGridReports.Rows.Clear();
        }

        // Setting up access to the data retrived from the assignments class and populates the datagrid
        private void BtnAssignmentsLoad_Click(object sender, EventArgs e)
        {
            // Clears the datagrid
            ClearDGAssignments();

            // Checks the see which option selected in the combo box and gets the corresponding data from the assignmnets class
            objA = new Assignments();
    
            // IF statement for checking that a report is selected.
            if (cbAssignments.Text == "Please select")
            {
                MessageBox.Show("Please select a choice from the combo box.");
            }
            else
            {
                // Calls the GetAssignments method in the Assignments class
                if (cbAssignments.Text == "Get Unassigned Deliveries")
                {
                    ds = objA.GetAssignments();
                }

                //Calls the GetUndelivered method in the Assignments class

                else if (cbAssignments.Text == "Get Undelivered Assignments")
                {
                    ds = objA.GetUndelivered();
                }

                // Gets the data and populates the Data grid with values
                dr = ds.Tables[0].Rows[0];
                dataGridAssignments.DataSource = ds.Tables[0];
            }
        }

        private void CbAssignments_Click(object sender, EventArgs e)
        {
            // Clears the combo box
            cbAssignments.Items.Clear();
            // Adds the combo box items from the assignments class
            cbAssignments.Items.AddRange(Assignments.fillCbA());
        }

        // Method to clear the assignments datagrid
        private void ClearDGAssignments()
        {
            dataGridAssignments.DataSource = null;
            dataGridAssignments.Rows.Clear();
        }


        private void cbDeliverySlot_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the form, sets a new instance of the Login screen and shows the login screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            //Resets the user access level to 0;
            User.AccessLevel = 0;
            Login login = new Login();
            login.Show();
        }

        private void btnBookDel_Click(object sender, EventArgs e)
        {
            //If statement to provide an error message if client type is default and only adds a new client if aa type is selected
            if (cbBName.Text == "Please choose")
            {
                MessageBox.Show("Please select a business");
            }
            //If statement to provide an error message if client type is default and only adds a new client if aa type is selected
            if (tbDestination.Text == "")
            {
                MessageBox.Show("Please input a destination");
            }

            else
            {
                // Creates a new instance of the Deliveries class
                Deliveries objD = new Deliveries();

                //  Sets the client class parameters with the values inputted on the form
                objD.Name = cbBName.Text;
                objD.Date = DatePicker.Value;
                objD.Destination = tbDestination.Text;

                objD.AddNewDelivery();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bwcDataSet.Couriers' table. You can move, or remove it, as needed.
            this.couriersTableAdapter.Fill(this.bwcDataSet.Couriers);
            // TODO: This line of code loads data into the 'bwcDataSet.Deliveries' table. You can move, or remove it, as needed.
            //  this.deliveriesTableAdapter.Fill(this.bwcDataSet.Deliveries);
            // TODO: This line of code loads data into the 'bwcDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.bwcDataSet.Clients);

        }

        private void cbAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelAssignments_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbBName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}