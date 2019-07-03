using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Shipping
{
    public class ShippingPage
    {
        public ShippingActions Actions()
        {
            return new ShippingActions();
        }

        public ShippingVerify Verify()
        {
            return new ShippingVerify();
        }
    }
}
