using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Saab;

namespace CalculationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Calculation_Smabil()
        {
            
        }

        [TestMethod]
        public void Test_Calculation_Van()
        {
            Form1 sb = new Form1();
            DateTime dtRent = new DateTime(2020, 11, 05, 12, 00, 00);
            DateTime dtReturn = new DateTime(2020, 11, 06, 11, 00, 00);
            int rentDistance = 1000;
            int returnDistance = 1500;

            double res = sb.VanCostTest(dtRent, dtReturn, rentDistance, returnDistance);
            Assert.AreEqual(res, 5180);
        }

        [TestMethod]
        public void Test_Calculation_Minibuss()
        {
            Form1 sb = new Form1();
            DateTime dtRent = new DateTime(2020, 11, 05, 12, 00, 00);
            DateTime dtReturn = new DateTime(2020, 11, 06, 11, 00, 00);
            int rentDistance = 1000;
            int returnDistance = 1500;

            double res = sb.MinibussCostTest(dtRent, dtReturn, rentDistance, returnDistance);
            Assert.AreEqual(res, 7755);
        }
    }
}
