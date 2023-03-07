namespace BayWynCouriersWinForm
{
    /// <summary>
    /// Infomation relating to obtaining reports from the database
    /// </summary>
    internal class Reports
    {
        // String variables initialised with the corresponding report
        public static string reportDaily = "Day Courier Assignments";
        public static string reportMonthly = "Month Courier Assignments";
        public static string reportAll = "All assignments for given month";
        public static string reportValue = "Value of contracts for given month";

        // Function to get all the Access Level 1 available reports and return as an array
        public static string[] getAl1Reports()
        {
            string[] Al1Reports = {reportDaily, reportMonthly, reportAll, reportValue};
            return Al1Reports;
        }

        // Function to get all the Access Level 2 available reports and return as an array
        public static string getAl2Reports()
        {
            string Al2Reports = reportAll;
            return Al2Reports;
        }

        // Function to get all the Access Level 3 available reports and return as an array
        public static string[] getAl3Reports()
        {
            string[] Al3Reports = { reportDaily, reportMonthly };
            return Al3Reports;
        }
    }

}
