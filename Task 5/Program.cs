using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Squaring numbers using LINQ Select
        List<int> nums = new List<int> { 2, 4, 6, 8, 10 };
        var squaredValues = nums.Select(x => x * x);

        Console.WriteLine("Squared Values:");
        foreach (var v in squaredValues)
            Console.WriteLine(v);


        // Example 2: Filtering books based on price
        List<Book> books = new List<Book>
        {
            new Book { Title = "C# Guide", Price = 950 },
            new Book { Title = "Java Pro", Price = 1700 },
            new Book { Title = "LINQ Deep Dive", Price = 1300 }
        };

        var costlyBooks = books.Where(b => b.Price >= 1200);

        Console.WriteLine("\nBooks costing Rs. 1200 or more:");
        foreach (var bk in costlyBooks)
            Console.WriteLine(bk.Title + " - " + bk.Price);


        // Example 3: Sorting students alphabetically
        List<Student> studs = new List<Student>
        {
            new Student { Name = "Kiran" },
            new Student { Name = "Bibek" },
            new Student { Name = "Aryan" }
        };

        var sortedStudents = studs.OrderBy(s => s.Name);

        Console.WriteLine("\nSorted Students:");
        foreach (var st in sortedStudents)
            Console.WriteLine(st.Name);


        // Example 4: Using Sum, Max, Min, Count, Average with cashier sales
        List<CashierSales> salesData = new List<CashierSales>
        {
            new CashierSales { CashierName = "Cashier1", Sales = 4500 },
            new CashierSales { CashierName = "Cashier2", Sales = 8200 },
            new CashierSales { CashierName = "Cashier3", Sales = 2900 },
            new CashierSales { CashierName = "Cashier4", Sales = 7600 }
        };

        Console.WriteLine("\nSales Count: " + salesData.Count());
        Console.WriteLine("Total Sales: " + salesData.Sum(s => s.Sales));
        Console.WriteLine("Highest Sale: " + salesData.Max(s => s.Sales));
        Console.WriteLine("Lowest Sale: " + salesData.Min(s => s.Sales));
        Console.WriteLine("Average Sale: " + salesData.Average(s => s.Sales));


        // Example 5: Any() and All() with applicant list
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Rohit", Age = 17 },
            new Applicant { Name = "Sneha", Age = 20 }
        };

        Console.WriteLine("\nAny applicant below 18? " + applicants.Any(a => a.Age < 18));
        Console.WriteLine("Are all applicants above 16? " + applicants.All(a => a.Age > 16));


        // Example 6: First, Last, FirstOrDefault with songs
        List<Song> songs = new List<Song>
        {
            new Song { Title = "SongX", DurationSec = 200 },
            new Song { Title = "SongY", DurationSec = 360 },
            new Song { Title = "SongZ", DurationSec = 720 }
        };

        Console.WriteLine("\nFirst Song: " + songs.First().Title);
        Console.WriteLine("Last Song: " + songs.Last().Title);
        Console.WriteLine("First Song longer than 3 minutes: " +
                          songs.First(s => s.DurationSec > 180).Title);

        var longTrack = songs.FirstOrDefault(s => s.DurationSec > 600);
        if (longTrack != null)
            Console.WriteLine("Long Track Found: " + longTrack.Title);
    }
}


// Model Classes
class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
}

class Student
{
    public string Name { get; set; }
}

class CashierSales
{
    public string CashierName { get; set; }
    public int Sales { get; set; }
}

class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Song
{
    public string Title { get; set; }
    public int DurationSec { get; set; }
}
