using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Payment
{
    public class PaymentPage
    {
        public PaymentActions Actions()
        {
            return new PaymentActions();
        }

        public PaymentVerify Verify()
        {
            return new PaymentVerify();
        }
    }
}
