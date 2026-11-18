using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void IsPower_ExponentZero_ReturnsTrue()
        {
            // Arrange
            long n = 1;      // 5^0
            long a = 5;
            bool expected = true;

            // Act
            bool actual = MathHelper.IsPower(n, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPower_ExponentInsideRange_ReturnsTrue()
        {
            // Arrange
            long n = 8;      // 2^3
            long a = 2;
            bool expected = true;

            // Act
            bool actual = MathHelper.IsPower(n, a);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPower_ExponentUpperBound_ReturnsTrue()
        {
            // Arrange
            long n = 81;     // 3^4
            long a = 3;

            // Act
            bool actual = MathHelper.IsPower(n, a);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsPower_ExponentOutOfRange_ReturnsFalse()
        {
            // Arrange
            long n = 32;     // 2^5, показатель вне диапазона 0..4
            long a = 2;

            // Act
            bool actual = MathHelper.IsPower(n, a);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsPower_NotAPower_ReturnsFalse()
        {
            // Arrange
            long n = 10;
            long a = 3;

            // Act
            bool actual = MathHelper.IsPower(n, a);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}