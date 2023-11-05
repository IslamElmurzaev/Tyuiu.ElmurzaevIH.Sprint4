using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint4.Task3.V6.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint4.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 8, 8, 3, 4, 5 },
                                           { 8, 6, 6, 4, 6 },
                                           { 3, 6, 5, 3, 4 },
                                           { 5, 6, 3, 7, 5 },
                                           { 7, 8, 5, 6, 6 } };
            int res = ds.Calculate(array);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}
