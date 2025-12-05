using System.Drawing;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rec = new Rectangle();
            rec.Length = 40;
            rec.Breadth = 30;

            Console.WriteLine("Details of Rectangle");
            Console.WriteLine(rec.showDetails());
            Console.WriteLine($"Area: {rec.GetArea()}");
            Console.WriteLine($"Perimeter: {rec.GetPerimeter()}");
        }
    }
}