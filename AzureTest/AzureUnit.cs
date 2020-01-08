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
    }
}
