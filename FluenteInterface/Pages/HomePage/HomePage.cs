using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluenteInterface.Pages
{
    public class HomePage
    {         
        public HomePageActions Actions()
        {
            return new HomePageActions();
        }

        public HomePageVerify Verify()
        {
            return new HomePageVerify();
        }
    }
}
