using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldAPI.Services;

namespace HelloWorldAPITests.Tests
{


    [TestClass()]
    public class HelloWorldServiceTests
    {
       

        [TestMethod()]
        public void GetMessageTest()
        {
            // Create return models for dependencies
            string expectedValue = "Hello World... sent from TEST";

            HelloWorldServiceClient client = new HelloWorldServiceClient();

            // Call the method to test
            var response = client.GetMessage("TEST");

            // Check value
            Assert.AreEqual(response, expectedValue);
        }
    }
}