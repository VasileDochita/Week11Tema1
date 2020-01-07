using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProblem;

using Xunit;
using Xunit.Extensions;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        private calculatorClass calcClass;
        [TestMethod]
        internal void CalculatorTest()
        {
            calcClass = new calculatorClass();
        }
        [Theory]
        [InlineData(1, 3, 15)]
        [InlineData(2, 6.3, 11.1)]
        [InlineData(1.01, 7.7, 20.7)]
        [InlineData(5, 6, 8)]
        [InlineData(7, 0, 1)]
        [InlineData(-9, 9, 0)]   
        [Trait("Operation", "Add")]
        public void AddTesting(decimal a, decimal b, decimal c)
        {
            Xunit.Assert.Equal(c, calcClass.Add(a, b));

        }

        [Theory]
        [InlineData(1, 3, 15)]
        [InlineData(2, 6.3, 11.1)]
        [InlineData(1.01, 7.7, 20.7)]
        [InlineData(5, 6, 8)]
        [InlineData(7, 0, 1)]
        [InlineData(-9, 9, 0)]
        [Trait("Operation", "Substraction")]

        public void substractionTesting(decimal a, decimal b, decimal c)
        {
            Xunit.Assert.Equal(c, calcClass.Substraction(a, b));
        }

        [Theory]
        [InlineData(1, 3, 15)]
        [InlineData(2, 6.3, 11.1)]
        [InlineData(1.01, 7.7, 20.7)]
        [InlineData(5, 6, 8)]
        [InlineData(7, 0, 1)]
        [InlineData(-9, 9, 0)]
        [Trait("Operation", "Multiply")]
        public void TmultiplyTesting(decimal a, decimal b, decimal c)
        {
            Xunit.Assert.Equal(c, calcClass.Multiply(a, b));

        }

        [Theory]
        [InlineData(1, 3, 15)]
        [InlineData(2, 6.3, 11.1)]
        [InlineData(1.01, 7.7, 20.7)]
        [InlineData(5, 6, 8)]
        //[InlineData(7, 0, 1)]
        [InlineData(-9, 9, 0)]
        [Trait("Operation", "Divide")]
        public void divideTesting(decimal a, decimal b, decimal c)
        {
            Xunit.Assert.Equal(c, calcClass.Divide(a, b));

        }
        [Theory]
        [InlineData (5, 0)]
        [Trait("Operation", "Divide")]
        public void zeroDividing(decimal a, decimal b)
        {
            Xunit.Assert.Throws<DivideByZeroException>(() => calcClass.Divide(a, b));
        }
    }
}
