using Main.Main.Entities;
using Xunit;

namespace Tests;

public class CalculatorTests
{
    [Fact]
    public void ShouldSumTwoNumbers()
    {
        var result = Calculator.Sum(1, 3);
        Assert.Equal(4, result);
    }

    [Fact]
    public void ShouldFail()
    {
        var result = Calculator.Sum(1, 3);
        Assert.NotEqual(5, result);
    }
}