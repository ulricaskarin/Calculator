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
        [Fact]
        public void SubtractionTest()
        {
            CalculatorClass sut = new CalculatorClass();
            var actualDifference = sut.Difference(10.0, 5.0);
            Assert.Equal(5, actualDifference);
        }

        [Fact]
        public void MultiplicationTest()
        {
            CalculatorClass sut = new CalculatorClass();
            var actualProduct = sut.Product(10.0, 10.0);
            Assert.Equal(100, actualProduct);
        }

        [Fact]
        public void DivisionTest()
        {
            CalculatorClass sut = new CalculatorClass();
            var actualQuotient = sut.Quotient(10.0, 1.0);
            Assert.Equal(10, actualQuotient);
        }
    }
}
