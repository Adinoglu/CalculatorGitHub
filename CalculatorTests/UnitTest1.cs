using AdinCalc;

namespace CalculatorTests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_ShouldReturnSumOfTwoNumbers()
    {
        // Arrange
        double a = 5;
        double b = 3;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_ShouldHandleNegativeNumbers()
    {
        // Arrange
        double a = -5;
        double b = 3;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(-2, result);
    }

    [Fact]
    public void Add_ShouldHandleDecimalNumbers()
    {
        // Arrange
        double a = 5.5;
        double b = 2.3;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(7.8, result, 1); // Allow small precision difference
    }

    [Fact]
    public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
    {
        // Arrange
        double a = 10;
        double b = 4;

        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Subtract_ShouldHandleNegativeResult()
    {
        // Arrange
        double a = 4;
        double b = 10;

        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Subtract_ShouldHandleDecimalNumbers()
    {
        // Arrange
        double a = 10.5;
        double b = 3.2;

        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(7.3, result, 1);
    }

    [Fact]
    public void Multiply_ShouldReturnProductOfTwoNumbers()
    {
        // Arrange
        double a = 6;
        double b = 7;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void Multiply_ShouldHandleZero()
    {
        // Arrange
        double a = 5;
        double b = 0;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_ShouldHandleNegativeNumbers()
    {
        // Arrange
        double a = -4;
        double b = 3;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(-12, result);
    }

    [Fact]
    public void Multiply_ShouldHandleDecimalNumbers()
    {
        // Arrange
        double a = 2.5;
        double b = 4.0;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(10.0, result);
    }

    [Fact]
    public void Divide_ShouldReturnQuotientOfTwoNumbers()
    {
        // Arrange
        double a = 15;
        double b = 3;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ShouldHandleDecimalResult()
    {
        // Arrange
        double a = 7;
        double b = 2;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(3.5, result);
    }

    [Fact]
    public void Divide_ShouldThrowDivideByZeroException()
    {
        // Arrange
        double a = 10;
        double b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
    }

    [Fact]
    public void Divide_ShouldHandleNegativeNumbers()
    {
        // Arrange
        double a = -10;
        double b = 2;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(-5, result);
    }

    [Fact]
    public void Divide_ShouldHandleBothNegativeNumbers()
    {
        // Arrange
        double a = -15;
        double b = -3;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(5, result);
    }
}
