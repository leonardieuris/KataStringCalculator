using System.Collections.Generic;
using KataStringCalculator;
using NUnit.Framework;
using KataStringCalculator.Exceptions;

namespace KataStringCalculatorTest
{
    public class SplitterExtensionTest
    {
        [SetUp]
        public void SetUp()
        { 
        }

        [Test]
        public void TestReturnException()
        {
            var input = "1\n2,4,";
            Assert.Throws<SeparatorAtTheEndOfStringException>(() => input.Splitter());
        }



      
        public void TestOutputString()
        {
            var input = "1,2";
            var expected = new List<int> { 1, 2 };

            Assert.AreEqual(expected, input.Splitter());
        }



        public void TestOutputStringWithOtherSeperator()
        {
            var input = "//sep\n2sep5000";
            var expected = new List<int> { 2, 5000 };
            Assert.AreEqual(expected, input.Splitter());
        }
    }
}
