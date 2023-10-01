using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVVnew.Sprint0.Task2.Lib;

namespace Tyuiu.TolmachevVVnew.Sprint0.Task2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMessageValid()
        {
            var name = "Виталий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Виталий", res);
        }
    }
}
