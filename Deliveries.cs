using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace BayWynCouriersWinForm
{
    class Deliveries
    {
        private int _DeliveryID;
        private int _CourierID;
        private int _ClientID;
        private DateTime _Date;
        private DateTime _Time;
        private string _Name;
        private int _ClientPhone;
        private string _Destination;

        // Declares a ClientID property of type int
        public int ClientID
        {
            get
            {
                return _ClientID;
            }

            set
            {
                _ClientID = value;
            }
        }


        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
            }
        }

        public DateTime Time

        {
            get
            {
                return _Time;
            }
            set
            {
                _Time = value;
            }
        }

        // Declare a ClientPhone property of type int
        public int ClientPhone
        {
            get
            {
                return _ClientPhone;
            }
            set
            {
                _ClientPhone = value;
            }
        }

        // Declare a Destination property of type string
        public string Destination
        {
            get
            {
                return _Destination;
            }
            set
            {
                
                _Destination = value;
            }
        }
        /// <summary>
        /// Method to add a new delivery 
        /// </summary>
        public void AddNewDelivery()
        {
            // Sets the connection
            string connnectionString = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbDataReader reader;
            OleDbConnection connection = new OleDbConnection(connnectionString);

            // XXX: SQL Statement works except for the client ID
            string sql = "SELECT ClientID FROM Clients WHERE ClientName = '" + _Name + "' AND INSERT INTO Deliveries (Date, ClientID, Destination) VALUES ('" + _Date + "', ClientID,'" + _Destination + "')";
            
            // Sets a new command and inserts the sql statement and connection string
            OleDbCommand command = new OleDbCommand(sql, connection);
            //Opens the connection
            connection.Open();
            reader = command.ExecuteReader();
            // Closed the connection
            connection.Close();

            // Window to show delivery added successfully
            MessageBox.Show("New delivery added.");
        }

        /// <summary>
        /// TODO: Fix the view slots section to show all available slots for courier for day
        /// </summary>
        /// <returns></returns>
        public DataSet ViewSlots()
        {
            DataSet dsVS = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the sql command and adapter to access the all contract data from the database
            OleDbCommand cmVS = new OleDbCommand();
            cmVS.Connection = con;
            cmVS.CommandType = CommandType.Text;
            cmVS.CommandText = "Select * From Slots";
            //AND Select * from Slots WHERE Date =  " + _Date + "'";
            OleDbDataAdapter daVS = new OleDbDataAdapter(cmVS);
            daVS.Fill(dsVS);
            con.Close();

            //Returns the filled dataset of clients to the be accessed
            return dsVS;
        }
    }
}