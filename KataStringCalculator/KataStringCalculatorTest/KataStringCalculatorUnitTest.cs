using KataStringCalculator;
using NUnit.Framework;
using System;
using KataStringCalculator.Exceptions;
using Moq;
using System.Collections;
using System.Collections.Generic;

namespace KataStringCalculatorTest
{
    public class Tests
    {

        private ICalculator _sut;

        [SetUp]
        public void Setup()
        {
            Mock<IValidate> validator = new Mock<IValidate>();
            validator.Setup(x => x.Validate(It.IsAny<IList<int>>())).Returns(true);
            _sut = new Calculator(validator.Object);
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [TestCase("1,2", ExpectedResult = 3)]
        [TestCase("10,20,4,5,8", ExpectedResult = 47)]
        [TestCase("10,20,4", ExpectedResult = 34)]
        [TestCase("1,2\n3", ExpectedResult = 6)]
        [TestCase("1\n2,4", ExpectedResult = 7)]
        [TestCase("//;\n1;3", ExpectedResult = 4)]
        [TestCase("//|\n1|2|3", ExpectedResult = 6)]
        [TestCase("//sep\n2sep5", ExpectedResult = 7)]
        public int Test(string input)
            {
           
             return _sut.Add(input);
            }

        [Test]
        public void TestReturnException()
        {
            var input = "1\n2,4,";
            Assert.Throws<SeparatorAtTheEndOfStringException>(() => _sut.Add(input));
        }


        [Test]
        public void TestException()
        {
            var input = "1\n2,b";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }

        [Test]
        public void TestExceptionInvalid()
        {
            var input = "//|\n1|2,3";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }

        [Test]
        public void TestExceptionInvalidv2()
        {
            var input = "//|\n1|2\n3";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }


        [Test]
        public void TestExceptionInvalidForMissingSeparator()
        {
            var input = "//\n1|2|3";
            Assert.Throws<FormatException>(() => _sut.Add(input));
        }


        [Test]
        public void TestExceptionInvalidWithNegativeNumbers()
        {

            var validator = new Validator();
            _sut = new Calculator(validator);
            var input = "//sep\n2sep5sep-100";
            Assert.Throws<NegativeNumbersException>(() => _sut.Add(input));
        }
    }
}