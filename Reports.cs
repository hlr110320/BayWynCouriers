using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace BayWynCouriersWinForm
{
    /// <summary>
    /// Infomation relating to obtaining reports from the database
    /// </summary>
    class Reports
    {
        // String variables initialised with the corresponding report. Used to populate the reports combo box on the reports page
        private static string DayAssignmentsReport = "Day Courier Assignments";
        private static string MonthAssignmentsReport = "Month Courier Assignments";
        private static string AllAssignmentsMonthReport = "All assignments for given month";
        private static string MonthContractValueReport = "Value of contracts for given month";

        public string ChosenReport;


        // Function to get all the Access Level 1 available reports and return as an array
        public static string[] getAl1Reports()
        {
            string[] Al1Reports = { DayAssignmentsReport, MonthAssignmentsReport, AllAssignmentsMonthReport, MonthContractValueReport };
            return Al1Reports;
        }

        // Function to get all the Access Level 2 available reports and return as an array
        public static string getAl2Reports()
        {
            string Al2Reports = AllAssignmentsMonthReport;
            return Al2Reports;
        }

        // Function to get all the Access Level 3 available reports and return as an array
        public static string[] getAl3Reports()
        {
            string[] Al3Reports = { DayAssignmentsReport, MonthAssignmentsReport };
            return Al3Reports;
        }


        // Parameters for getting and setting the chosen report
        public string _ChosenReport
        {
            get
            {
                return ChosenReport;
            }

            set
            {
                ChosenReport = value;
            }
        }


        /// <summary>
        /// A report to get all todays deliveries for chosen courier
        /// </summary>
        /// <param name="cID"></param>
        /// <returns>dsR</returns>
        public DataSet GetDayAssignmentsReport()
        {
            DateTime Today = new DateTime();
            Today = DateTime.Today;
            DataSet dsR = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the sql command and adapter to access the all report data from the database
            OleDbCommand cmR = new OleDbCommand();
            cmR.Connection = con;
            cmR.CommandType = CommandType.Text;
            cmR.CommandText = "Select * from Deliveries, Couriers, WHERE Deliveries.CourierID = Couriers.CourierID AND Deliveries.Date = " + Today + "'";
            //+ cID + "" ;
            OleDbDataAdapter daR = new OleDbDataAdapter(cmR);
            daR.Fill(dsR);
            con.Close();

            //Returns the filled dataset of clients to the be accessed
            return dsR;
        }

        /// <summary>
        /// A report to get all deliveries for the chosen month
        /// </summary>
        /// <returns></returns>
        public DataSet GetMonthAssignmentsReport()
        {
            DataSet dsR = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the sql command and adapter to access the all report data from the database
            OleDbCommand cmR = new OleDbCommand();
            cmR.Connection = con;
            cmR.CommandType = CommandType.Text;
            cmR.CommandText = "Select * from Deliveries WHERE Deliveries.Date = MONTH()";
            OleDbDataAdapter daR = new OleDbDataAdapter(cmR);
            daR.Fill(dsR);
            con.Close();

            //Returns the filled dataset of clients to the be accessed
            return dsR;
        }

        public DataSet GetAllAssignmentsMonthReport()
        {
            DataSet dsR = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the sql command and adapter to access the all report data from the database
            OleDbCommand cmR = new OleDbCommand();
            cmR.Connection = con;
            cmR.CommandType = CommandType.Text;
            cmR.CommandText = "Select * from Deliveries WHERE Deliveries.Date = MONTH()";
            OleDbDataAdapter daR = new OleDbDataAdapter(cmR);
            daR.Fill(dsR);
            con.Close();

            //Returns the filled dataset
            return dsR;
        }

        public DataSet GetMonthContractValueReport()
        {
            DataSet dsR = new DataSet();

            // Getting and opening the connection string
            string bwcCon = ConfigurationManager.ConnectionStrings["bwcCon"].ConnectionString;
            OleDbConnection con = new OleDbConnection(bwcCon);
            con.Open();

            // Setting the sql command and adapter to access the all report data from the database
            OleDbCommand cmR = new OleDbCommand();
            cmR.Connection = con;
            cmR.CommandType = CommandType.Text;
            cmR.CommandText = "Select * from Clients";
            OleDbDataAdapter daR = new OleDbDataAdapter(cmR);
            daR.Fill(dsR);
            con.Close();

            //Returns the filled dataset of clients to the be accessed
            return dsR;
        }
    }
}
