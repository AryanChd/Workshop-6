// Delegate for discount calculation
public delegate double DiscountStrategy(double amount);

public class Discount
{
    public static double FestivalOffer(double amount) => amount * 0.80; // 20% off
    public static double SeasonOffer(double amount) => amount * 0.90;   // 10% off
    public static double NoOffer(double amount) => amount;

    public static double CalculateFinalPrice(double basePrice, DiscountStrategy strategy)
    {
        return strategy(basePrice);
    }
}
