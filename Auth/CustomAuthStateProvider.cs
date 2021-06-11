using EstacionamientoMedido.Auth;
using EstacionamientoMedido.Entities;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Helpers
{
    public class CustomAuthStateProvider : AuthenticationStateProvider, ILoginService
    {
        private SessionManager _Session;
        private AuthenticationState Anonimo => new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        public CustomAuthStateProvider(SessionManager session)
        {
            _Session = session;
        }
        public Task Login(string userName)
        {
            _Session.Username = userName;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            return Task.CompletedTask;
        }

        public Task Logout()
        {
            _Session.Username = null;
            NotifyAuthenticationStateChanged(Task.FromResult(Anonimo));
            return Task.CompletedTask;
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (_Session.IsUserLoggedIn())
            {
                return Task.FromResult(BuildAuthState(_Session.Username));
            }
            return Task.FromResult(Anonimo);
        }

        private AuthenticationState BuildAuthState(string username)
        {
            var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, _Session.Username)}, _Session.Username);

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(identity)));
        }




    }
}
