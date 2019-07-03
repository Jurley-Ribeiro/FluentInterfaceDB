using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Address
{
    public class AddressActions : PageBase
    {
        
            public AddressElements Home { get { return new AddressElements(); } }

            public AddressActions GoToUrl()
            {
                Driver.Navigate().GoToUrl(BaseAddress);
                return this;
            }


            public void GoToShipping()
            {
                Home.AddressButton.Click();
            }
        }

   
}
