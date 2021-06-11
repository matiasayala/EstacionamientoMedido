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
        }

        public string Username { get; set; }


        public bool IsUserLoggedIn()
        {
            return Username != null;
        }

    }
}
