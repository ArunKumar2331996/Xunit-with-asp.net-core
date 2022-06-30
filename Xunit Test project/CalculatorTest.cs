using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit_implementation.Controllers;
using Xunit_implementation.Service;

namespace Xunit_Test_project
{
    public class CalculatorTest
    {
        private CalculatorService calculator = null;
        public CalculatorTest()
        {
            if (calculator == null)
            {
                calculator = new CalculatorService();
            }

        }

        [Fact]
        public void Test_add()
        {
            var actualResult = calculator.add(2, 3);
            var expectedResult = 5;
            Assert.Equal(expectedResult,actualResult);
        }

        [Fact]
        public void Test_add_NegativeNumber()
        {
            var actualResult = calculator.add(2, -3);
            var expectedResult = -1;
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory(DisplayName ="This test will run subtract method with multiple values")]
        [InlineData(5,2,3)]
        [InlineData(4,2,2)]
        public void Test_Sub(int v1, int v2,int expectedResult)
        {
            var actualResult = calculator.sub(v1, v2);            
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory(DisplayName = "This test will run Multiplication method with multiple values")]
        [InlineData(5, 2, 10)]
        [InlineData(4, 2, 8)]
        public void Test_Mul(int v1, int v2, int expectedResult)
        {
            var actualResult = calculator.mul(v1, v2);
            Assert.Equal(expectedResult, actualResult);
        }

        /// <summary>
        /// How to use moq in Xunit.
        /// </summary>
        [Fact]
        public void moq_Add()
        {
            var C = new Mock<ICalculatorService>();
            C.Setup(x => x.add(2, 2)).Returns(4);            
            Assert.Equal(4, C.Object.add(2, 2));
        }

    }
}
