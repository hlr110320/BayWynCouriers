namespace BayWynCouriersWinForm
{
    /// <summary>
    /// Class for getting the user access level from the data base when the user logs in. This is used to conttrol objects within the form to confirm with permissions.
    /// </summary>
    internal class User
    {
        private static int _AccessLevel;
        public static int AccessLevel
        {
            get
            {
                return _AccessLevel;
            }

            set
            {
                _AccessLevel = value;
            }
        }

    }
}
