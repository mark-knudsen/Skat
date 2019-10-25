using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBilAfgift
{
    [TestClass]
    public class UnitTest1
    {
        // Unit Test car price
        [TestMethod]
        public void CarPrice_WhenPriceIsNegative_ThrowArgumentOutOfRange()
        {
            // Arrange
            int bil = -200000;

            // Act
            try
            {
                Skat.Afgift.BilAfgift(bil);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, Skat.Afgift.CarPriceIsMinusOrNull);
            }
        }

        // Unit Test car tax
        [TestMethod]
        public void CarTax_CarPriceUnderTwoThousand_TestSucced()
        {
            // Arrange
            int bil = 199999;
            int expectedResult = Convert.ToInt32(bil * 0.85);

            // Act
            int result = Skat.Afgift.BilAfgift(bil);


            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void CarTax_CarPriceIsTwoThousand_TestSucced()
        {
            // Arrange
            int bil4 = 200000;
            int expectedResult = Convert.ToInt32(bil4 * 0.85);

            // Act
            int result = Skat.Afgift.BilAfgift(bil4);


            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void CarTax_CarPriceOverTwoThousand_TestSucced()
        {
            // Arrange
            int bil5 = 250000;
            int expectedResult = Convert.ToInt32((bil5 * 1.5) - 130000);

            // Act
            int result = Skat.Afgift.BilAfgift(bil5);


            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        // Unit Test elcar price

        [TestMethod]
        public void ElCarPrice_ElCarPriceIsNegative_ThrowArgumentOutOfRange()
        {
            // Arrange
            int bil = -150000;

            // Act
            try
            {
                Skat.Afgift.ElBilAfgift(bil);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, Skat.Afgift.CarPriceIsMinusOrNull);
            }

        }

        // Unit Test elcar tax
        [TestMethod]
        public void ElCarTax_CarPriceUnderTwoHundredThousand_TestSucced()
        {
            // Arrange
            int bil3 = 199999;
            int expectedResult = Convert.ToInt32((bil3 * 0.85) * 0.2);

            // Act
            int result = Skat.Afgift.ElBilAfgift(bil3);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ElCarTax_CarValueIsTwoHundredThousand_TestSucced()
        {
            // Arrange
            int bil4 = 200000;
            int expectedResult = Convert.ToInt32((bil4 * 0.85) * 0.2);

            // Act
            int result = Skat.Afgift.ElBilAfgift(bil4);


            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ElCarTax_ElCarPriceOverTwoHundredThousand_TestSucced()
        {
            // Arrange
            int bil5 = 250000;
            int expectedResult = Convert.ToInt32(((bil5 * 1.5) - 130000) * 0.2);

            // Act
            int result = Skat.Afgift.ElBilAfgift(bil5);


            // Assert
            Assert.AreEqual(expectedResult, result);
        }

    }
}
