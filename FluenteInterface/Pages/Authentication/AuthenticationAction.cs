using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Authentication
{
    public class AuthenticationAction : PageBase
    {
        public AuthenticationElements Authentication { get { return new AuthenticationElements(); } }

        public AuthenticationAction SetEmail(string email)
        {
            //Send a random email
            Authentication.Email.SendKeys(email);
            return this;
        }

        public void GoToPersonalFormulary()
        {
            Authentication.CreateAccountButton.Click();
        }

    }
}
