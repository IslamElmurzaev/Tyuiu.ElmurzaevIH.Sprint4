using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint4.Task5.V2.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { -1, 1, 2, -3, 5 }, { -1, -1, 2, -3, 5 }, { -1, 1, -2, -3, 5 }, { -1, -1, 2, -3, -5 }, { -1, 1, 2, -3, 5 } };
            int wait = 14;
            int res = ds.Calculate(mtrx);

            Assert.AreEqual(wait, res);
        }
    }
}
