namespace Main.Main.Entities;

public abstract class Calculator
{
    public static decimal Sum(decimal first, decimal second)
    {
        var result = first + second;
        return result;
    }
}