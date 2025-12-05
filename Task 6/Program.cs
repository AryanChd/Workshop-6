using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // List of tour bookings with modified data and new names added
        List<TourBooking> tours = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Aryan",   Destination = "Japan",      Price = 30000, DurationInDay = 6, IsInternational = true },
            new TourBooking { CustomerName = "Avay",    Destination = "Pokhara",    Price = 6000,  DurationInDay = 3, IsInternational = false },
            new TourBooking { CustomerName = "Bardan",  Destination = "Malaysia",   Price = 18000, DurationInDay = 5, IsInternational = true },
            new TourBooking { CustomerName = "Sangeet", Destination = "Chitwan",    Price = 4000,  DurationInDay = 2, IsInternational = false },
            new TourBooking { CustomerName = "Dudey",   Destination = "USA",        Price = 45000, DurationInDay = 7, IsInternational = true }
        };

        // LINQ: Filter → Select → OrderBy → ThenBy
        var result = tours
            .Where(t => t.Price >= 15000 && t.DurationInDay >= 5)  // changed filter
            .Select(t => new
            {
                t.CustomerName,
                t.Destination,
                TripType = t.IsInternational ? "International Trip" : "Domestic Trip",
                TotalCost = t.Price
            })
            .OrderByDescending(t => t.TotalCost)  // changed ordering
            .ThenBy(t => t.CustomerName);

        // Display output
        Console.WriteLine("Filtered & Sorted Tour Records:\n");
        foreach (var t in result)
        {
            Console.WriteLine($"{t.CustomerName} | {t.Destination} | {t.TripType} | Rs. {t.TotalCost}");
        }
    }
}

class TourBooking
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }
}
