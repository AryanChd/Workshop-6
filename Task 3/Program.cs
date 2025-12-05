using System;

class Program
{
    static void Main(string[] args)
    {
        int[] values = { 4, 9, 14, 2, 18, 11, 6 };

        Console.WriteLine("Filtered: Even Values");
        NumberProcessor.FilterNumbers(values, x => x % 2 == 0);

        Console.WriteLine("Filtered: Values Above 10");
        NumberProcessor.FilterNumbers(values, x => x > 10);
    }
}