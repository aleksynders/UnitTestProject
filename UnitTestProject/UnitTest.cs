using WSUniversalLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodAreEqual_1()
        {
            // Метод, подтверждающий, что фактический результат равен ожидаемому
            int productType = 4, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = -1;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void TestMethodAreEqual_2()
        {
            // Метод, подтверждающий, что фактический результат равен ожидаемому
            int productType = 2, materialType = 1, count = 12;
            int width = 15, length = 33;
            int except = 14895;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void TestMethodAreEqual_3()
        {
            // Метод, подтверждающий, что фактический результат равен ожидаемому
            int productType = 3, materialType = 2, count = 15;
            int width = 17, length = 22;
            int except = 47350;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void TestMethodAreNotEqual()
        {
            // Метод, подтверждающий, что фактический результат не равен ожидаемому
            int productType = 2, materialType = 1, count = 17;
            int width = 10, length = 35;
            int except = 14348;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreNotEqual(except, actual);
        }

        [TestMethod]
        public void TestMethodIsTrue()
        {
            // Метод, подтверждающий, что фактический результат равен ожидаемому
            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = 114147;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(actual == except);
        }

        [TestMethod]
        public void TestMethodIsFalse()
        {
            // Метод, подтверждающий, что фактический результат не равен ожидаемому
            int productType = 1, materialType = 2, count = 13;
            float width = 10, length = 22;
            int except = 13468;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(actual == except);
        }

        [TestMethod]
        public void TestMethodIsType()
        {
            // Метод, подтверждающий, что ожидается итог в виде int-вого числа
            int productType = 2, materialType = 2, count = 10;
            int width = 10, length = 25;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsInstanceOfType(except, typeof(int));
        }

        [TestMethod]
        public void TestMethodIsNotType_Double()
        {
            // Метод, подтверждающий, что не ожидается итог в виде double числа
            int productType = 2, materialType = 2, count = 25;
            int width = 10, length = 35;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotInstanceOfType(except, typeof(double));
        }

        [TestMethod]
        public void TestMethodIsNotType_String()
        {
            // Метод, подтверждающий, что не ожидается итог в виде string числа
            int productType = 3, materialType = 1, count = 15;
            int width = 5, length = 25;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotInstanceOfType(except, typeof(string));
        }

        [TestMethod]
        public void TestMethodIsNotNull_true()
        {
            // Метод, подтверждающий, что итог не равен NULL
            int productType = 2, materialType = 1, count = 35;
            int width = 23, length = 15;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(except);
        }
    }
}
