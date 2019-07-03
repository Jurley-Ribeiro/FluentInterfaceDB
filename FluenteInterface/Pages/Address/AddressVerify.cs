using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluenteInterface.Pages.Address
{
    public class AddressVerify
    {
        private AddressElements AddressPage { get { return new AddressElements(); } }

        public AddressVerify AssertAddressIsCorrect (string address)
        {
            List<string> items = new List<string>();
            var itemsBox = AddressPage.AddressBox.FindElements(By.TagName("li"));

            foreach (var item in itemsBox)
            {
                items.Add(item.Text);
            }

            Assert.IsTrue(items.Contains(address));

            return this;
        }

    }
}
