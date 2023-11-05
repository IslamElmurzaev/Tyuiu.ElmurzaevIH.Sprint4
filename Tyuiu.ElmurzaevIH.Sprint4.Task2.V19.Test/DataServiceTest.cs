using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint4.Task2.V19.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] arr = new int[14] { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9, 4, 5 };

            int res = ds.Calculate(arr);
            int wait = 47;

            Assert.AreEqual(wait, res);
        }
    }
}
