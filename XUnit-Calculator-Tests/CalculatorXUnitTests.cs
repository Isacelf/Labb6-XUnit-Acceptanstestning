using Labb6_XUnit_Acceptanstestning.Models;

namespace XUnit_Calculator_Tests
{
    public class CalculatorXUnitTests
    {

        [Fact]
        public void Addition_Should_Return_CorrectSum()
        {
            // Arrange
            decimal x = 4;
            decimal y = 6;
            decimal expected = 10;

            // Act
            var result = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }


        [Theory]
        [InlineData(2.5, 3.5, 6.0)]
        [InlineData(15.0, 10.0, 25.0)]
        [InlineData(-1.2, -2.8, -4.0)]
        [InlineData(150.0, 150.0, 300.0)]
        [InlineData(0.0, 5.0, 5.0)]
        public void Addition_Should_Return_CorrectResult(decimal x, decimal y, decimal expected)
        {
            // Act
            var result = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Theory]
        [InlineData(10.0, 4.0, 6.0)]
        [InlineData(20.5, 5.5, 15.0)]
        [InlineData(-2.0, -3.0, 1.0)]
        [InlineData(200.0, 100.0, 100.0)]
        [InlineData(5.0, 0.0, 5.0)]
        public void Subtraction_Should_Return_CorrectResult(decimal x, decimal y, decimal expected)
        {
            // Act
            var result = Calculator.Subtract(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Theory]
        [InlineData(3.0, 4.0, 12.0)]
        [InlineData(7.5, 2.0, 15.0)]
        [InlineData(-3.0, 3.0, -9.0)]
        [InlineData(50.0, 2.0, 100.0)]
        [InlineData(5.0, 0.0, 0.0)]
        public void Multiplication_Should_Return_CorrectResult(decimal x, decimal y, decimal expected)
        {
            // Act
            var result = Calculator.Multiply(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Theory]
        [InlineData(8.0, 2.0, 4.0)]
        [InlineData(15.0, 3.0, 5.0)]
        [InlineData(-6.0, 2.0, -3.0)]
        [InlineData(100.0, 4.0, 25.0)]
        [InlineData(5.0, 1.0, 5.0)]
        public void Division_Should_Return_CorrectResult(decimal x, decimal y, decimal expected)
        {
            // Act
            var result = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Fact]
        public void Division_DivideByZero_ReturnsZero()
        {
            // Arrange
            decimal x = 55.5m;
            decimal y = 0.0m;

            // Act
            var result = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(0, result.Result);
            Assert.Equal($"{x} / {y} = Cannot divide by zero.", result.Operation);
        }
    }
}