using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Saab;

namespace CalculationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Calculation_Van()
        {
            VehicleRentalForm sb = new VehicleRentalForm();
            DateTime dtRent = new DateTime(2020, 11, 05, 12, 00, 00);
            DateTime dtReturn = new DateTime(2020, 11, 06, 11, 00, 00);
            int rentDistance = 1000;
            int returnDistance = 1500;

            double res = sb.VanCost(dtRent, dtReturn, rentDistance, returnDistance);
            Assert.AreEqual(res, 5180);
        }

        [TestMethod]
        public void Test_Calculation_Minibuss()
        {
            VehicleRentalForm sb = new VehicleRentalForm();
            DateTime dtRent = new DateTime(2020, 11, 05, 12, 00, 00);
            DateTime dtReturn = new DateTime(2020, 11, 06, 11, 00, 00);
            int rentDistance = 1000;
            int returnDistance = 1500;

            double res = sb.MinibussCost(dtRent, dtReturn, rentDistance, returnDistance);
            Assert.AreEqual(res, 7755);
        }
    }
}
