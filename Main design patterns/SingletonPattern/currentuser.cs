using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastFoodResturant.SingletonPattern
{
    public class CurrentUser
    {
        private static CurrentUser _instance;
        // this holds reference to the only class that should be able to exist
        private string username = "";
        // Constructor is 'protected'
        protected CurrentUser()
        {
        }

        // this function gets you the only possible instance of this class
        public static CurrentUser Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new CurrentUser();
            }

            return _instance;
        }

        public static String getCurrentUser()
        {
            if (_instance == null)
            {
                _instance = new CurrentUser();
            }
            return _instance.username;
        }

        public static void setCurrentUser(string newUserName)
        {
            if (_instance == null)
            {
                _instance = new CurrentUser();
            }
            _instance.username = newUserName;
        }
    }
}
