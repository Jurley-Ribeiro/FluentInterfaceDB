using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.OrderConfirmationPage
{
    public class OrderConfirmationPage
    {
        public OrderConfirmationActions Actions()
        {
            return new OrderConfirmationActions();
        }

        public OrderConfirmationVerify Verify()
        {
            return new OrderConfirmationVerify();
        }

    }
}
