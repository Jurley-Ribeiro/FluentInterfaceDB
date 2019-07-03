using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Address
{
    public class AddressPage
    {
        public AddressActions Actions()
        {
            return new AddressActions();
        }

        public AddressVerify Verify()
        {
            return new AddressVerify();
        }
    }
}
