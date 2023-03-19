using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace BayWynCouriersWinForm
{
    class Assignments
    {
        // Initiliasing the assignments page combo box strings
        private static string CbAUnassigned = "Get Unassigned Deliveries";
        private static string CbAUndelivered = "Get Undelivered Assignments";

        // Method to get the assignments combo box values and return as an array
        public static string[] fillCbA()
        {
            string[] _fillCbA = { CbAUnassigned, CbAUndelivered };
            return _fillCbA;
        }

        /// <summary>
        /// Gets all jobs which are unassigned. The couriers and logistics coordinator can then accept assignments.
        /// </summary>
        /// <returns>The dataset of unassigned deliveries</returns>
        public DataSet GetAssignments()
        {
            // Initialises a new dataset
            DataSet dsA = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);

            //Opens the connection
            con.Open();

            // Setting the database command and adapter
            OleDbCommand cmA = new OleDbCommand();
            cmA.Connection = con;
            cmA.CommandType = CommandType.Text;
            // SQL statement for getting all uinassigned deliveries
            cmA.CommandText = "Select Deliveries.DeliveryID, Deliveries.Date, Deliveries.ClientID, Clients.ClientName FROM Deliveries Inner Join Clients On Deliveries.ClientID = Clients.ClientID WHERE SlotID IS NULL";
            
            //Initialies a new data adapter
            OleDbDataAdapter dA = new OleDbDataAdapter(cmA);

            //Fills the data adapter with the dataset returned from the database
            dA.Fill(dsA);

            //Closed the connection to the database
            con.Close();

            //Returns the dataset from the class
            return dsA;
        }

        public DataSet AcceptAssignments()
        {
            // Initialises a new dataset
            DataSet ds = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["BayWynCouriersWinForm.Properties.Settings.bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the database command and adapter
            OleDbCommand cmA = new OleDbCommand();
            cmA.Connection = con;
            cmA.CommandType = CommandType.Text;
            // SQL statement for accepting a delivery
            cmA.CommandText = "Select * from Deliveries where SlotID Is NULL";
            OleDbDataAdapter dA = new OleDbDataAdapter(cmA);

            dA.Fill(ds);
            con.Close();

            return ds;

        }


        /// <summary>
        /// Gets all jobs which are undelivered. The couriers and logistics coordinator can then update the delivery date when the delivery has occurred.
        /// </summary>
        /// <returns>The dataset of undelivered jobs</returns>
        public DataSet GetUndelivered()
        {
            DataSet dsU = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the sql command and adapter
            OleDbCommand cmU = new OleDbCommand();
            cmU.Connection = con;
            cmU.CommandType = CommandType.Text;
            cmU.CommandText = "SELECT Deliveries.DeliveryID, Deliveries.Date, Deliveries.ClientID, Deliveries.Delivered, Deliveries.Destination, Clients.ClientID, Clients.ClientName, Slots.SlotID, FROM Deliveries, Clients, Slots, Couriers WHERE Deliveries.Delivered IS NULL";
            OleDbDataAdapter daU = new OleDbDataAdapter(cmU);

            daU.Fill(dsU);
            con.Close();

            return dsU;
        }

    }
}
