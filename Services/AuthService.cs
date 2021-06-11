using EstacionamientoMedido.Entities;
using EstacionamientoMedido.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Services
{
    public class AuthService
    {

        public string Validate(string userName, string password)
        {
            if (userName == "admin" && password == "admin")
            {
                return userName;
            }

            return null;
        }

    }
}
