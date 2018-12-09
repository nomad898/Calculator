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
    class MultiplicationTest
    {
        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(10, -20, ExpectedResult = -200)]
        [TestCase(-1, -6, ExpectedResult = 6)]
        public double Execute_MultiplyNumbers_ReturnsThatRealEqualsToExpected(double first, double second)
        {
            //Arrange
            IOperation multiplication = new Multiplication(first, second);

            //Act 
            var result = multiplication.Execute();

            //Assert
            return result;
        }

    }
}
