using BusinessService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulWebApi.Tests
{
    [TestClass]
    public class BusinessTestClass
    {
        [TestMethod]
        public void GenerateReferenceNumber_TestCase()
        {
            
            // Arrange
            string expectedResult = "1";
            Calculator calculator = new Calculator();

            // Act
            string actulResult = calculator.GenerateReferenceNumber("123456");

            // Assert
            Assert.IsNotNull(actulResult);
            Assert.AreEqual(actulResult, expectedResult);
        }
    }
}
