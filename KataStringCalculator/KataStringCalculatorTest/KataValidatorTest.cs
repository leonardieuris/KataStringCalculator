using System.Collections.Generic;
using NUnit.Framework;
using KataStringCalculator.Validators;
using KataStringCalculator.Exceptions;

namespace KataStringCalculatorTest
{
    public class KataValidatorTest
    {
        IValidator _sut;
        List<int> listNumbers;

        [SetUp]
        public void SetUp()
        {
     
            listNumbers = new List<int>
            {
                10,
                20,
                -1,
                1500
            };
        }

        [Test]
        public void TestExceptionInvalidWithNegativeNumbers()
        {
            _sut = new NotNegativeValidator();
            Assert.Throws<NegativeNumbersException>(() => _sut.Validate(listNumbers));
        }



        [Test]
        public void TestExceptionValidNotNegativeNumbers()
        {
            var input = new List<int>
            {
                10,
                20
            };


            var expected = new List<int>
            {
                10,
                20
            };

            _sut = new NotNegativeValidator();
            Assert.AreEqual(expected, _sut.Validate(input));
        }


        [Test]
        public void TestExceptionFilterdNumbers()
        {
            var expected = new List<int>
            {
                10,
                20,
                -1
            };

            _sut = new NumberLimitValidator();

            Assert.AreEqual(expected, _sut.Validate(listNumbers));
            
        }


        [Test]
        public void TestExceptionFilterdNumbers_NotFiltered()
        {

            var input = new List<int>
            {
                10,
                20
            };


            var expected = new List<int>
            {
                10,
                20 
            };

            _sut = new NumberLimitValidator();

            Assert.AreEqual(expected, _sut.Validate(input));

        }


    }
}
