using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Xunit;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void SumTest()
        {
            // Arrange
            CalculatorClass sut = new CalculatorClass();

            // Act
            var actualSum = sut.Sum(2.5, 2.5);

            // Assert
            Assert.Equal(5, actualSum);
        }
    }
}
