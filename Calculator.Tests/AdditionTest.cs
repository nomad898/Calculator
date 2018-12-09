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
    class AdditionTest
    {
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(10.5, 20, ExpectedResult = 30.5)]
        [TestCase(-1, -6, ExpectedResult = -7)]
        public double Execute_SumNumbers_ReturnsThatRealEqualsToExpected(double first, double second)
        {
            //Arrange
            IOperation operation = new Addition(first, second);

            //Act 
            var result = operation.Execute();

            //Assert
            return result;
        }
    }
}
