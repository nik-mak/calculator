namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Calculator_AddTwoNumbers_ReturnsResult()
    {
        // Arrange
        string equation = "7 + 5";

        // Act
        double result = Calculate.Run(equation);

        // Assert
        Assert.Equal(12, result);
    }

    [Fact]
    public void Calculator_SubtractTwoNumbers_ReturnsResult()
    {
        // Arrange
        string equation = "10 - 8";

        // Act
        double result = Calculate.Run(equation);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Calculator_MultiplyTwoNumbers_ReturnsResult()
    {
        // Arrange
        string equation = "4 * 3";

        // Act
        double result = Calculate.Run(equation);

        // Assert
        Assert.Equal(12, result);
    }

    [Fact]
    public void Calculator_DivideTwoNumbers_ReturnsResult()
    {
        // Arrange
        string equation = "9 / 3";

        // Act
        double result = Calculate.Run(equation);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Calculator_DivideByZero_ThrowsDivideByZeroError()
    {
        // Arrange
        string equation = "2 / 0";

        // Act
        //double result = Calculate.Run(equation);

        Action act = () => Calculate.Run(equation);

        // Assert
        DivideByZeroException error = Assert.Throws<DivideByZeroException>(act);

        Assert.Equal("Cannot divide by 0", error.Message);
    }
}
