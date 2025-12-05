using System;

class Program
{
    static void Main(string[] args)
    {
        // Using delegate for calculator functions
        Calculate operation = Calculator.AddNumbers;
        Console.WriteLine("Addition Output: " + operation(8, 4));

        operation = Calculator.MinusNumbers;
        Console.WriteLine("Subtraction Output: " + operation(8, 4));

        double originalCost = 1200;

        DiscountStrategy strategy;

        strategy = Discount.FestivalOffer;
        Console.WriteLine("Festival Offer Price: " + strategy(originalCost));

        strategy = Discount.SeasonOffer;
        Console.WriteLine("Seasonal Offer Price: " + strategy(originalCost));

        strategy = Discount.NoOffer;
        Console.WriteLine("No Offer Price: " + strategy(originalCost));

        Console.WriteLine("Computed Final (Festival): " +
            Discount.CalculateFinalPrice(originalCost, Discount.FestivalOffer));

        Console.WriteLine("Computed Final (Seasonal): " +
            Discount.CalculateFinalPrice(originalCost, Discount.SeasonOffer));

        Console.WriteLine("Computed Final (No Offer): " +
            Discount.CalculateFinalPrice(originalCost, Discount.NoOffer));

        // Lambda discount (changed value)
        double lambdaResult = Discount.CalculateFinalPrice(originalCost, amount => amount * 0.70);
        Console.WriteLine("Lambda Final (30% Off): " + lambdaResult);
    }
}
