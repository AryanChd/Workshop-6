
public class NumberProcessor
{
    public static void FilterNumbers(int[] nums, Func<int, bool> rule)
    {
        foreach (int item in nums)
        {
            if (rule(item))
            {
                Console.WriteLine(item);
            }
        }
    }
}