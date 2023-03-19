using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BayWynCouriersWinForm
{
    class Clients
    {
        /// <summary>
        ///  Initialisation of properties and variables of the clients class
        /// </summary>
        private int _ClientID;
        private string _ClientName;
        private string _ClientAdd;
        private string _ClientPhone;
        private string _ClientEmail;
        private string _ClientInfo;
        private string _ContractType;
        private DateTime _ClientStartDate;
        private int _ClientRunTotal;
        private int _CourierRuns;
        internal static object cbBName;
        internal DataSet dsVC;
        internal OleDbDataAdapter daVC;


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

        // Declares a ClientName property of type string
        public string ClientName
        {
            get
            {
                return _ClientName;
            }
            set
            {
                _ClientName = value;
            }
        }

        // Declare a ClientAdd property of type string
        public string ClientAdd
        {
            get
            {
                return _ClientAdd;
            }
            set
            {
                _ClientAdd = value;
            }
        }

        // Declare a ClientPhone property of type string
        public string ClientPhone
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

        // Declare a ClientEmail property of type string
        public string ClientEmail
        {
            get
            {
                return _ClientEmail;
            }
            set
            {
                _ClientEmail = value;
            }
        }


        // Declare a ClientInfo property of type string
        public string ClientInfo
        {
            get
            {
                return _ClientInfo;
            }
            set
            {
                _ClientInfo = value;
            }
        }


        // Declare a ContractType property of type string
        public string ContractType
        {
            get
            {
                return _ContractType;
            }
            set
            {
                _ContractType = value;

            }
        }


        // Declare a ClientStartDate property of type date time
        public DateTime ClientStartDate
        {
            get
            {
                return _ClientStartDate;
            }
            set
            {
                _ClientStartDate = value;

            }
        }


        // Declare a ClientRunTotal property of type int
        public int ClientRunTotal
        {
            get
            {
                return _ClientRunTotal;
            }
            set
            {
                _ClientRunTotal = value;
            }
        }
        // Declares a CourierRuns property of type int
        public int CourierRuns
        {
            get
            {
                return _CourierRuns;
            }
            set
            {
                _CourierRuns = value;
            }
        }

        /// <summary>
        /// Method to add a new contract using the data input on the 'create new contract' screen
        /// </summary>
        public void AddNewContract()
        {
            // Getting the connection string
            string connnectionString = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;

            // Setting up the reader and database connection
            OleDbDataReader reader;
            OleDbConnection connection = new OleDbConnection(connnectionString);
            // Setting the SQL command
            string sql = "INSERT INTO Clients (ClientName, ClientAdd, ClientPhone, ClientEmail, ClientInfo, ContractType, ClientStartDate, ContractedCourierRuns) VALUES('" + _ClientName + "','" + _ClientAdd + "','" + _ClientPhone + "','" + _ClientEmail + "','" + _ClientInfo + "','" + _ContractType + "','" + _ClientStartDate + "','" + _CourierRuns + "')";
            OleDbCommand command = new OleDbCommand(sql, connection);
            connection.Open();
            reader = command.ExecuteReader();
            connection.Close();

            // Messagebox to show new client contract added
            MessageBox.Show("New client contract added!");
        }
        public DataSet ViewContracts()
        {
            DataSet dsVC = new DataSet();
            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();
            // Setting the sql command and adapter to access all contract data from the database
            OleDbCommand cmVC = new OleDbCommand();
            cmVC.Connection = con;
            cmVC.CommandType = CommandType.Text;
            // SQL command
            cmVC.CommandText = "Select * from Clients";

            //Sets a dataadapted and fills it with the dataset rturned from the database query
            OleDbDataAdapter daVC = new OleDbDataAdapter(cmVC);
            daVC.Fill(dsVC);

            //Returns the filled dataset of clients to the be accessed
            return dsVC;
        }

        public void SaveContracts()

        {
            //  daVC.Update(dsVC)



        }

        /// <summary>
        /// The SortedList ViewClients method is used to get a list of the Client names from the database. 
        /// This is used to populate the business name combo box, so
        /// the user can select a business name when booking a delivery. 
        /// </summary>
        /// <returns></returns>
        /// 
        public DataSet ViewClients()
        {
            DataSet dsVC = new DataSet();
            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the sql command and adapter to access the all contract data from the database

            OleDbCommand cmVC = new OleDbCommand();
            cmVC.Connection = con;
            cmVC.CommandType = CommandType.Text;
            // Selects all from the ClientName column in the Clients table
            cmVC.CommandText = "Select ClientName FROM Clients";
            using (OleDbDataAdapter daVC = new OleDbDataAdapter(cmVC))
            {
                daVC.Fill(dsVC);
            }

            con.Close();
            // Returns the filled dataset of clients
            return dsVC;

        }
    }
}

