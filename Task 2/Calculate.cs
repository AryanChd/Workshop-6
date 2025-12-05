// Delegate for calculator
public delegate int Calculate(int x, int y);

public class Calculator
{
    public static int AddNumbers(int x, int y) => x + y;
    public static int MinusNumbers(int x, int y) => x - y;
}