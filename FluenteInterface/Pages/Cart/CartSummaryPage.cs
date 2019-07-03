using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Cart
{
    public class CartSummaryPage
    {
        public CartSummaryActions Actions()
        {
            return new CartSummaryActions();
        }

        public CartSummaryVerify Verify()
        {
            return new CartSummaryVerify();
        }
    }
}
