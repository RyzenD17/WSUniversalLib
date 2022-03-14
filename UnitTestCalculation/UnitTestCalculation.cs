using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestCalculation
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void Check_BadProductType_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(4, 1, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_BadMaterialType_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 3, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeFirstMaterialTypeEasy_True()
        {
            int rezult = 7;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 1, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_SecondProductTypeFirstMaterialTypeEasy_True()
        {
            int rezult = 16;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(2, 1, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeFirstMaterialTypeEasy_True()
        {
            int rezult = 51;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 1, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeSecondMaterialTypeEasy_True()
        {
            int rezult = 7;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 2, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_SecondProductTypeSecondMaterialTypeEasy_True()
        {
            int rezult = 16;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(2, 2, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeSecondMaterialTypeEasy_True()
        {
            int rezult = 51;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, 1, 2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_NegativeArea_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, 1, -2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_NegativeCount_True()
        {
            int rezult = -1;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, -1, -2, 3);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeFirstMaterialTypeHard_True()
        {
            int rezult = 16;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 1, 1, (float)5.6, (float)2.5);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeFirstMaterialTypeHard_True()
        {
            int rezult = 119;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 1, 1, (float)5.6, (float)2.5);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_FirstProductTypeSecondMaterialTypeHard_True()
        {
            int rezult = 16;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(1, 2, 1, (float)5.6, (float)2.5);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_SecondProductTypeSecondMaterialTypeHard_True()
        {
            int rezult = 36;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(2, 2, 1, (float)5.6, (float)2.5);

            Assert.AreEqual(rezult, actual);
        }

        [TestMethod]
        public void Check_ThirdProductTypeSecondMaterialTypeHard_True()
        {
            int rezult = 119;

            Calculation calc = new Calculation();
            int actual = calc.GetQuantityForProduct(3, 2, 1, (float)5.6, (float)2.5);

            Assert.AreEqual(rezult, actual);
        }
    }
}
