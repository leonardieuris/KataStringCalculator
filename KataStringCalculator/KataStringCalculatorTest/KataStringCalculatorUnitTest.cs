using KataStringCalculator;
using NUnit.Framework;
using System;
using KataStringCalculator.Exceptions;
using KataStringCalculator.Validators;

namespace KataStringCalculatorTest
{
    public class Tests
    {

        private ICalculator _sut;

        [SetUp]
        public void Setup()
        {

            var validatorNotNegativeValidator = new NotNegativeValidator();
            validatorNotNegativeValidator.SetNext(new NumberLimitValidator());
            _sut = new Sum(validatorNotNegativeValidator);

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
        [TestCase("//sep\n2sep5000", ExpectedResult = 2)]
        [TestCase("//sep\n2sep5000sep4sep5", ExpectedResult = 11)]
        public int Test(string input)
        {
            return _sut.Calculate(input);
        }

        [Test]
        public void TestReturnException()
        {
            var input = "1\n2,4,";
            Assert.Throws<SeparatorAtTheEndOfStringException>(() => _sut.Calculate(input));
        }


        [Test]
        public void TestException()
        {
            var input = "1\n2,b";
            Assert.Throws<FormatException>(() => _sut.Calculate(input));
        }

        [Test]
        public void TestExceptionInvalid()
        {
            var input = "//|\n1|2,3";
            Assert.Throws<FormatException>(() => _sut.Calculate(input));
        }

        [Test]
        public void TestExceptionInvalidv2()
        {
            var input = "//|\n1|2\n3";
            Assert.Throws<FormatException>(() => _sut.Calculate(input));
        }


        [Test]
        public void TestExceptionInvalidForMissingSeparator()
        {
            var input = "//\n1|2|3";
            Assert.Throws<FormatException>(() => _sut.Calculate(input));
        }


        [Test]
        public void TestExceptionInvalidWithNegativeNumbers()
        {

            var input = "//sep\n2sep5sep-100";
            Assert.Throws<NegativeNumbersException>(() => _sut.Calculate(input));
        }
    }
}