﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVVnew.Sprint0.Task7.Lib;

namespace Tyuiu.TolmachevVVnew.Sprint0.Task7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArray()
        {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums3 = new int[] { 2, 2, 2, 2, 2 };

            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }
    }
}
