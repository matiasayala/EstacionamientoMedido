using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Helpers
{
    public class SessionManager
    {
        public SessionManager()
        {
            Username = string.Empty;
            IsLoggedIn = false;
        }

        public string Username { get; set; }
        public bool IsLoggedIn { get; set; }

        public void Logout()
        {
            Username = string.Empty;
            IsLoggedIn = false;
        }


        public bool IsUserLoggedIn()
        {
            return IsLoggedIn;
        }

    }
}
