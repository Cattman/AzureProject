using Microsoft.VisualStudio.TestTools.UnitTesting;
using AzureLibrary;

namespace AzureTest
{
    [TestClass]
    public class AzureUnit
    {
        [TestMethod]
        public void TestAddMethod()
        {
            var first = 5;
            var second = 7;
            var sum = first + second;

            var lib = new Azure();

            Assert.AreEqual(sum, lib.Add(first, second), "Add did not correctly sum the 2 values.");
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            var first = 10;
            var second = 7;
            var diff = first - second;

            var lib = new Azure();

            Assert.AreEqual(diff, lib.Subtract(first, second), "Subtract did not correctly find the difference of the 2 values.");
        }
    }
}
