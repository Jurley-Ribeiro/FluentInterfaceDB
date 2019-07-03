using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Cart
{
    public class CartSummaryVerify
    {
        private CartSummaryElements CartSummary { get { return new CartSummaryElements(); } }

        public void ProductWasAdd(string product)
        {
           Assert.IsTrue(CartSummary.Product.Text.Contains(product));
        }
    }
}
