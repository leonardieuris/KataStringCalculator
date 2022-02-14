using NUnit.Framework;
using KataStringCalculator.IOC;
using KataStringCalculator;
using KataStringCalculator.Validators;

namespace KataStringCalculatorTest
{
    public class IOCTest
    {
        [SetUp]
        public void SetUp()
        { 
        
        }

        [Test]
        public void TestGetCalculator()
        {
            var calculator = Container.GetService<ICalculator>();
            Assert.IsNotNull(calculator);
        }


        [Test]
        public void TestGetValidator()
        {
            var validator = Container.GetService<IValidator>();
            Assert.IsNotNull(validator);
        }


        [Test]
        public void TestGetValidCalculator()
        {
            var calculator = Container.GetService<ICalculator>();
            var expected = typeof(Sum);
            Assert.AreEqual(expected, calculator.GetType());
        }
    }
}
