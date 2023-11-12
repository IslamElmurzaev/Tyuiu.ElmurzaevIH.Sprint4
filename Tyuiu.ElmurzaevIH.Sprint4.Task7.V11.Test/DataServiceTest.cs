using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint4.Task7.V11.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint4.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            int[,] mt = new int[n, m];
            string str = "56789012";

            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);

            
        }
    }
}
