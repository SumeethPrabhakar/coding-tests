using Exceptions;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.CSharp.Tests
{
    [TestClass]
    public class TriangleTests
    {
        private readonly ITriangle _triangle;
        public TriangleTests()
        {
            _triangle = new Triangle();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void ShouldThrowExceptionIfAnyInputsAreNegativeForCalculatingAreaByAngle()
        {
            _triangle.CalculateAreaByAngle(-1, -3, 9);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void ShouldThrowExceptionIfAnyInputsAreNegativeForCalculatingAreaBySides()
        {
            _triangle.CalculateAreaByAngle(1, 3, -9);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void ShouldThrowExceptionIfAnyInputsAreNegativeForCalculatingAre()
        {
            _triangle.CalculateArea(1, -3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void ShouldThrowExceptionIfAnyInputsAreNotValidToFormTriangle1()
        {
            _triangle.CalculateAreaBySides(1, 1, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void ShouldThrowExceptionIfAnyInputsAreNotValidToFormTriangle2()
        {
            _triangle.CalculateAreaBySides(3, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void ShouldThrowExceptionIfAnyInputsAreNotValidToFormTriangle3()
        {
            _triangle.CalculateAreaBySides(1, 3, 1);
        }


        [TestMethod]
        public void ShouldReturnCorrectResultForRightAngleTriangle()
        {
            var expected = 12;
            var actual = _triangle.CalculateAreaByAngle(6, 4, 90);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForValidSides()
        {
            var expected = 6;
            var actual = _triangle.CalculateAreaBySides(3,4,5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnCorrectResultForValidBaseAndHeight()
        {
            var expected = 12;
            var actual = _triangle.CalculateArea(6,4);
            Assert.AreEqual(expected, actual);
        }
    }
}
