using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication.Algorithms;
using System.Linq;

namespace Test
{
    [TestClass]
    public class DancesWithWolvesTests
    {

        #region Duplicate Integer Tests

        // Given the very limited constraints of the test problem,
        // no negative test cases exist.

        private int[] DuplicateIntegerSetup(int dupNum)
        {
            int[] nums = new int[1000001];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = i + 1;

            nums[1000000] = dupNum;

            // Random and LINQ OrderBy used to shuffle the integers around
            // for a more realistic input.
            Random rnd = new Random();
            nums = nums.OrderBy(r => rnd.Next()).ToArray();

            return nums;
        }

        [TestMethod]
        public void DuplicateIntegerLowerBound()
        {
            // Arrange
            int dupNum = 1;
            int[] nums = DuplicateIntegerSetup(dupNum);

            // Act
            int answer = DancesWithWolves.DuplicateInteger(nums);

            // Assert
            Assert.AreEqual(dupNum, answer);
        }

        [TestMethod]
        public void DuplicateIntegerUpperBound()
        {
            // Arrange
            int dupNum = 1000000;
            int[] nums = DuplicateIntegerSetup(dupNum);

            // Act
            int answer = DancesWithWolves.DuplicateInteger(nums);

            // Assert
            Assert.AreEqual(dupNum, answer);
        }

        [TestMethod]
        public void DuplicateIntegerRandomMid()
        {
            // Arrange
            int dupNum = 239781;
            int[] nums = DuplicateIntegerSetup(dupNum);

            // Act
            int answer = DancesWithWolves.DuplicateInteger(nums);

            // Assert
            Assert.AreEqual(dupNum, answer);
        }

        #endregion

        #region First Non-Repeating Character

        [TestMethod]
        public void NullString()
        {
            // Arrange
            string str = null;

            // Act
            try
            {
                DancesWithWolves.FirstNonRepeatingCharacter(str);
            }

            // Assert
            catch (Exception ex)
            {
                Assert.AreEqual("A null or empty string cannot be provided.", ex.Message);
            }
        }

        [TestMethod]
        public void EmptyString()
        {
            // Arrange
            string str = "";

            // Act
            try
            {
                DancesWithWolves.FirstNonRepeatingCharacter(str);
            }

            // Assert
            catch (Exception ex)
            {
                Assert.AreEqual("A null or empty string cannot be provided.", ex.Message);
            }
        }

        [TestMethod]
        public void StringLength1()
        {
            // Arrange
            string str = "A";

            // Act
            string answer = DancesWithWolves.FirstNonRepeatingCharacter(str);

            // Assert
            Assert.AreEqual("A", answer);
        }

        [TestMethod]
        public void NoNonRepeatingCharactersString()
        {
            // Arrange
            string str = "AABCBC";

            // Act
            string answer = DancesWithWolves.FirstNonRepeatingCharacter(str);

            // Assert
            Assert.AreEqual(null, answer);
        }

        [TestMethod]
        public void NonRepeatingCharacterString()
        {
            // Arrange
            string str = "DEFD";

            // Act
            string answer = DancesWithWolves.FirstNonRepeatingCharacter(str);

            // Assert
            Assert.AreEqual("E", answer);
        }

        #endregion
    }
}
