using Calculator.ClassLibrary;
using Calculator.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    class RadicalTest
    {
        [TestCase(4, 2, ExpectedResult = 2)]
        [TestCase(64, 6, ExpectedResult = 2)]
        [TestCase(-64, -6, ExpectedResult = Double.NaN)]
        public double Execute_CalculateNumbersRadical_ReturnsThatRealEqualsToExpected(double first, double second)
        {
            //Arrange
            IOperation operation = new Radical(first, second);

            //Act 
            var result = operation.Execute();

            //Assert
            return result;
        }
    }
}
