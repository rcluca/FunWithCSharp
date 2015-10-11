using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication.Algorithms;

namespace Test
{
    [TestClass]
    public class MathWithOnlyAddOperatorTests
    {
        #region Subtract

        [TestMethod]
        public void SubtractPositiveLargerPositiveSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(10, 5);

            // Assert
            Assert.AreEqual(5, answer);
        }

        [TestMethod]
        public void SubtractPositiveSmallerPositiveLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(7, 11);

            // Assert
            Assert.AreEqual(-4, answer);
        }

        [TestMethod]
        public void SubtractPositiveEqualPositiveEqual()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(12, 12);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void SubtractLargerZero()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(9, 0);

            // Assert
            Assert.AreEqual(9, answer);
        }

        [TestMethod]
        public void SubtractZeroLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(0, 6);

            // Assert
            Assert.AreEqual(-6, answer);
        }

        [TestMethod]
        public void SubtractNegativeLargerNegativeSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(-10, -5);

            // Assert
            Assert.AreEqual(-5, answer);
        }

        [TestMethod]
        public void SubtractNegativeSmallerNegativeLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(-7, -11);

            // Assert
            Assert.AreEqual(4, answer);
        }

        [TestMethod]
        public void SubtractNegativeEqualNegativeEqual()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(-12, -12);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void SubtractSmallerZero()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(-9, 0);

            // Assert
            Assert.AreEqual(-9, answer);
        }

        [TestMethod]
        public void SubtractZeroSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(0, -6);

            // Assert
            Assert.AreEqual(6, answer);
        }

        [TestMethod]
        public void SubtractPositiveNegative()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(4, -5);

            // Assert
            Assert.AreEqual(9, answer);
        }

        [TestMethod]
        public void SubtractNegativePositive()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(-7, 8);

            // Assert
            Assert.AreEqual(-15, answer);
        }

        [TestMethod]
        public void SubtractZeroZero()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Subtract(0, 0);

            // Assert
            Assert.AreEqual(0, answer);
        }

        #endregion

        #region Multiply

        [TestMethod]
        public void MultiplyPositiveLargerPositiveSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(10, 5);

            // Assert
            Assert.AreEqual(50, answer);
        }

        [TestMethod]
        public void MultiplyPositiveSmallerPositiveLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(7, 11);

            // Assert
            Assert.AreEqual(77, answer);
        }

        [TestMethod]
        public void MultiplyPositiveEqualPositiveEqual()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(12, 12);

            // Assert
            Assert.AreEqual(144, answer);
        }

        [TestMethod]
        public void MultiplyLargerZero()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(9, 0);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void MultiplyZeroLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(0, 6);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void MultiplyNegativeLargerNegativeSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(-10, -5);

            // Assert
            Assert.AreEqual(50, answer);
        }

        [TestMethod]
        public void MultiplyNegativeSmallerNegativeLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(-7, -11);

            // Assert
            Assert.AreEqual(77, answer);
        }

        [TestMethod]
        public void MultiplyNegativeEqualNegativeEqual()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(-12, -12);

            // Assert
            Assert.AreEqual(144, answer);
        }

        [TestMethod]
        public void MultiplySmallerZero()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(-9, 0);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void MultiplyZeroSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(0, -6);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void MultiplyPositiveNegative()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(4, -5);

            // Assert
            Assert.AreEqual(-20, answer);
        }

        [TestMethod]
        public void MultiplyNegativePositive()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(-7, 8);

            // Assert
            Assert.AreEqual(-56, answer);
        }

        [TestMethod]
        public void MultiplyZeroZero()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Multiply(0, 0);

            // Assert
            Assert.AreEqual(0, answer);
        }

        #endregion

        #region Divide

        [TestMethod]
        public void DividePositiveLargerPositiveSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(10, 5);

            // Assert
            Assert.AreEqual(2, answer);
        }

        [TestMethod]
        public void DividePositiveSmallerPositiveLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(7, 11);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void DividePositiveEqualPositiveEqual()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(12, 12);

            // Assert
            Assert.AreEqual(1, answer);
        }

        [TestMethod]
        public void DivideLargerZero()
        {
            // Arrange

            // Act
            try
            {
                int answer = MathWithOnlyAddOperator.Divide(9, 0);
            }

            // Assert
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(DivideByZeroException));
            }
        }

        [TestMethod]
        public void DivideZeroLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(0, 6);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void DivideNegativeLargerNegativeSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(-10, -5);

            // Assert
            Assert.AreEqual(2, answer);
        }

        [TestMethod]
        public void DivideNegativeSmallerNegativeLarger()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(-7, -11);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void DivideNegativeEqualNegativeEqual()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(-12, -12);

            // Assert
            Assert.AreEqual(1, answer);
        }

        [TestMethod]
        public void DivideSmallerZero()
        {
            // Arrange

            // Act
            try
            {
                int answer = MathWithOnlyAddOperator.Divide(-9, 0);
            }

            // Assert
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(DivideByZeroException));
            }
        }

        [TestMethod]
        public void DivideZeroSmaller()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(0, -6);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void DividePositiveNegative()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(4, -5);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void DivideNegativePositive()
        {
            // Arrange

            // Act
            int answer = MathWithOnlyAddOperator.Divide(-7, 8);

            // Assert
            Assert.AreEqual(0, answer);
        }

        [TestMethod]
        public void DivideZeroZero()
        {
            // Arrange

            // Act
            try
            {
                int answer = MathWithOnlyAddOperator.Divide(0, 0);
            }

            // Assert
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(DivideByZeroException));
            }
        }

        #endregion
    }
}
