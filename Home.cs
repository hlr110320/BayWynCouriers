using System;
using System.ComponentModel.Design;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BayWynCouriersWinForm
{
    public partial class Home : Form
    {
        Assignments objA;
        Clients objC;
        Clients objVC;
        Reports objR;

        DataRow dr;
        DataSet ds;

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
            btnReports.Hide();
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

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            HidePanels();

            panelClients.Show();

            if (User.AccessLevel == 3)
            {
                ContractRuns.Show();
                cbClientType.Hide();
                tbCourierRuns.Hide();
                ContractRuns.Hide();
                tabContracts.TabPages.Remove(tabContracts.TabPages[2]);

            }
            ClearDGViewContracts();
            objVC = new Clients();
            ds = objVC.ViewContracts();

            // Gets the data and populates the Data grid with values
            dr = ds.Tables[0].Rows[0];
            dataGridViewContracts.DataSource = ds.Tables[0];

            ClearDGEditContracts();
            objVC = new Clients();
            ds = objVC.ViewContracts();

            // Gets the data and populates the Data grid with values
            dr = ds.Tables[0].Rows[0];
            dataGridEditContracts.DataSource = ds.Tables[0];
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

        private void ClearDGViewContracts()
        {
            dataGridViewContracts.DataSource = null;
            dataGridViewContracts.Rows.Clear();
        }
        private void ClearDGEditContracts()
        {
            dataGridEditContracts.DataSource = null;
            dataGridEditContracts.Rows.Clear();
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

            DateTime date = DatePicker.Value;

            //Clients objVC = new Clients();

            //cbBName.DataSource = objVC.ViewClients();
            //SortedList clients = new SortedList();
            //clients = objVC.ViewClients();
            //cbBName.Items.Add(clients);

            Deliveries objD = new Deliveries();

            objD.Date = date;

            dataGridBookSlots.DataSource = objD.ViewSlots();
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            Deliveries objD = new Deliveries();
            DateTime date = DatePicker.Value;
            DateTime time = cbTime;

            objD.Date = date;

            dataGridBookSlots.DataSource = objD.ViewSlots();
        }
        private void BtnGenReport_Click(object sender, EventArgs e)
        {
            // Calls the method to clear the datagrid to avoid re-adding existing data
            ClearDGReports();

            // Creates a new instance of the report class
            objR = new Reports();

            string chosenReport = cbReports.Text;
            objR._ChosenReport = chosenReport;


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

            if (cbAssignments.Text == "Please select")
            {
                MessageBox.Show("Please select a choice from the combo box.");
            }
            else
            {
                if (cbAssignments.Text == "Get Unassigned Deliveries")
                {
                    ds = objA.GetAssignments();
                }

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

            else
            {
                // Creates a new instance of the Deliveries class
                Deliveries objD = new Deliveries();

                // Sets the client class parameters with the values inputted on the form
                //objD._ClientName = cbBName.Text;
                //objD._Date = DatePicker.Value;
                //objD._Time = cbTime.ValueMember; 

            }

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}