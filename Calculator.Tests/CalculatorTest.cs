using System;
using Calculator.Interfaces;
using Calculator.ClassLibrary;
using NUnit.Framework;
using Moq;

namespace Calculator.Tests
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public void CallOperation_MockOperationWithLooseBehavour_ReturnsThatRealEqualsToExpected()
        {
            //Arrange
            var mockOperation = new Mock<IOperation>(MockBehavior.Loose);
            var expected = It.IsAny<double>();
            mockOperation.Setup(x => x.Execute()).Returns(expected);
            ICalculator calculator = new ClassLibrary.Calculator(mockOperation.Object);

            //Act 
            var result = calculator.CallOperation();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CallOperation_MockOperationWithStrictBehavour_ReturnsThatRealEqualsToExpected()
        {
            //Arrange
            var mockOperation = new Mock<IOperation>(MockBehavior.Strict);
            var expected = It.IsAny<double>();
            mockOperation.Setup(x => x.Execute()).Returns(expected);
            ICalculator calculator = new ClassLibrary.Calculator(mockOperation.Object);

            //Act
            var result = calculator.CallOperation();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
            mockOperation.VerifyAll();
        }
    }
}
