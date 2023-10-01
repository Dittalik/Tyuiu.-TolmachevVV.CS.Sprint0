using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVVnew.Sprint0.Task5.Lib;

namespace Tyuiu.TolmachevVVnew.Sprint0.Task5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(20, DataService.Addition(15, 5));
        }
        [TestMethod]
        public void CheckSubstractionValid()
        {
            Assert.AreEqual(10, DataService.Substraction(15, 5));
        }
        [TestMethod]
        public void CheckMultiplictationValid()
        {
            Assert.AreEqual(75, DataService.Multiplication(15, 5));
        }
        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(20, DataService.Division(100, 5));
        }
    }
}
