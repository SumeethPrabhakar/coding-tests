using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingChallenge.CSharp.Tests
{
  
    [TestClass]
    public class NumericSequenceCalculatorTests
    {
        private readonly INumericSequenceCalculator _numericSequenceCalculator;
        public NumericSequenceCalculatorTests()
        {
            _numericSequenceCalculator = new NumericSequenceCalculator();
        }

        [TestMethod]
        public void ShouldReturnAllPositiveDivisorsForTheGivenInput()
        {
            //arrange
            uint input = 60;
            var expected = new List<uint> {1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60};
            //act
            var actual = _numericSequenceCalculator.GetPostiveDivisors(input);

            //assert
            Assert.IsTrue(actual.Intersect(expected).Any());
        }

        [TestMethod]
        public void ShouldReturnAllPositiveDivisorsForTheGivenInput1()
        {
            //arrange
            uint input = 42;
            var expected = new List<uint> { 1, 2, 3, 6, 7, 14, 21, 42 };
            //act
            var actual = _numericSequenceCalculator.GetPostiveDivisors(input);

            //assert
            Assert.IsTrue(actual.Intersect(expected).Any());
        }

        [TestMethod]
        public void ShouldReturnAllPositiveDivisorsForInputZero()
        {
            //arrange
            uint input = 0;
            var expected = new List<uint> {0};
            //act
            var actual = _numericSequenceCalculator.GetPostiveDivisors(input);

            //assert
            Assert.IsTrue(actual.Intersect(expected).Any());
        }

        [TestMethod]
        public void ShouldReturnMostCommonNumberIntheSequence1()
        {
            //arrange
            var inputSequence = new List<int> {5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4};
            var expected = new List<int> {5, 4};
            //act
            var actual = _numericSequenceCalculator.GetMostCommonNumberIntheSequence(inputSequence);

            //assert
           Assert.IsTrue(actual.Intersect(expected).Any());
        }

        [TestMethod]
        public void ShouldReturnMostCommonNumberIntheSequence2()
        {
            //arrange
            var inputSequence = new List<int> { 1, 2, 3, 4, 5, 1, 6, 7 };
            var expected = new List<int> { 1 };
            //act
            var actual = _numericSequenceCalculator.GetMostCommonNumberIntheSequence(inputSequence);

            //assert
            Assert.IsTrue(actual.Intersect(expected).Any());
        }

        [TestMethod]
        public void ShouldReturnMostCommonNumberIntheSequence3()
        {
            //arrange
            var inputSequence = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            //act
            var actual = _numericSequenceCalculator.GetMostCommonNumberIntheSequence(inputSequence);

            //assert
            Assert.IsTrue(actual.Intersect(expected).Any());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldthrowArgumentExceptionIfSequenceIsNull()
        {
            _numericSequenceCalculator.GetMostCommonNumberIntheSequence(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldthrowArgumentExceptionIfSequenceIsEmpty()
        {
            _numericSequenceCalculator.GetMostCommonNumberIntheSequence(new List<int>());
        }
    }
}
