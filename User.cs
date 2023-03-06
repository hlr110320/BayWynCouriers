namespace BayWynCouriersWinForm
{
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
