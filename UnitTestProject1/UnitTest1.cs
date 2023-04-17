using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Name_WithLessThan3Characters_ReturnsFalse()
        {
            // Arrange
            string name = "ab";

            // Act
            bool result = IsNameValid(name);

            // Assert
            Assert.IsFalse(result);
        }




        public void Name_WithMoreThan15Characters_ReturnsFalse()
        {
            // Arrange
            string name = "abcdefghijklmnop";

            // Act
            bool result = IsNameValid(name);

            // Assert
            Assert.IsFalse(result);
        }


        public void Name_With3To15Characters_ReturnsTrue()
        {
            // Arrange
            string name1 = "abc";
            string name2 = "abcdefghijklmno";

            // Act
            bool result1 = IsNameValid(name1);
            bool result2 = IsNameValid(name2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        private bool IsNameValid(string name)
        {
           
            if (name.Length < 3 || name.Length > 15)
            {
                return false;
            }

            return true;
        }



    }
}