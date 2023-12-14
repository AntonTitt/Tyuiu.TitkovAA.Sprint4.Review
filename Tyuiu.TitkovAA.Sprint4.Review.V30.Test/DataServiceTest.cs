using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint4.Review.V30.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Review.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService dt = new DataService();
            int rows = 3;
            int colums = 5;
            int[,] mtrx = new int[rows, colums];
            string sstr = "684259137159648";


            Assert.AreEqual(73728, dt.Calculate(rows, colums, sstr));
        }
    }
}
