using FluenteInterface.WebDriver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Environment = FluenteInterface.Environments.Environment;


namespace FluenteInterface.Tests
{
    [TestClass]
    public class TestInitialize
    {
        public static TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext tc)
        {
            DriverFactory.Browser = tc.Properties["WebDriver"].ToString();
            Environment.Application = tc.Properties["Application"].ToString();
        }
    }
}
