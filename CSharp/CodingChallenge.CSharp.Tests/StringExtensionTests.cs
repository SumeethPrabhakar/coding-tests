using Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.CSharp.Tests
{
    /*
    Note:
    This tests can be written using Nunit and make use of single test with different parameters
    Unfortunately VS unit testing does not provide out of the box this functionality.So tests are repeated
    */

    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void ShouldReturnTrueIfInputStringIsNull()
        {
            //arrange
            string inputString = null;
            var expected = string.IsNullOrEmpty(inputString);
            //act
            var actual = inputString.IsNullOrEmpty();

            //assert
            Assert.IsTrue(actual);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ShouldReturnTrueIfInputStringIsEmpty()
        {
            //arrange
            string inputString = "";
            var expected = string.IsNullOrEmpty(inputString);
            //act
            var actual = inputString.IsNullOrEmpty();

            //assert
            Assert.IsTrue(actual);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ShouldReturnFalseIfInputStringIsNullString()
        {
            //arrange
            string inputString = "null";
            var expected = string.IsNullOrEmpty(inputString);
            //act
            var actual = inputString.IsNullOrEmpty();

            //assert
            Assert.IsFalse(actual);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ShouldReturnFalseIfInputStringIsValidString()
        {
            //arrange
            string inputString = "a";
            var expected = string.IsNullOrEmpty(inputString);
            //act
            var actual = inputString.IsNullOrEmpty();

            //assert
            Assert.IsFalse(actual);
            Assert.AreEqual(actual, expected);
        }
    }
}
