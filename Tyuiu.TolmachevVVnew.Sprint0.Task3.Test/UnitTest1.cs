using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVVnew.Sprint0.Task3.Lib;

namespace Tyuiu.TolmachevVVnew.Sprint0.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
