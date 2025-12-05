using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Working with numbers list
        List<int> values = new List<int> { 2, 5, 7, 10, 12 };

        // Square each number using LINQ Select
        var squaredValues = values.Select(x => x * x);

        Console.WriteLine("Squared Values:");
        foreach (var item in squaredValues)
        {
            Console.WriteLine(item);
        }


        // Example 2: Working with Book list
        List<Book> library = new List<Book>
        {
            new Book { Title = "Intro to C#", Price = 900 },
            new Book { Title = "C# Intermediate", Price = 1400 },
            new Book { Title = "Mastering LINQ", Price = 1600 }
        };

        // Filter books that cost more than 1200
        var expensiveBooks = library.Where(book => book.Price >= 1200);

        Console.WriteLine("\nBooks priced Rs. 1200 or more:");
        foreach (var book in expensiveBooks)
        {
            Console.WriteLine(book.Title + " - Rs. " + book.Price);
        }


        // Example 3: Sorting students alphabetically
        List<Student> studentList = new List<Student>
        {
            new Student { Name = "Aryan" },
            new Student { Name = "Kopal" },
            new Student { Name = "Sajan" },
            new Student { Name = "Nisha" },
            new Student { Name = "Rohan" }
        };

        // Sort students by name using OrderBy
        var arrangedStudents = studentList.OrderBy(s => s.Name);

        Console.WriteLine("\nAlphabetically Sorted Students:");
        foreach (var st in arrangedStudents)
        {
            Console.WriteLine(st.Name);
        }
    }
}


// Model Classes
public class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
}

public class Student
{
    public string Name { get; set; }
}
