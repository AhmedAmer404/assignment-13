

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Category { get; set; }
//    public decimal Price { get; set; }
//    public int Stock { get; set; }
//}

//class Program
//{
//    static List<Product> products = new List<Product>
//    {
//        new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
//        new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
//        new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
//        new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
//        new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
//        new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
//        new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
//        new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
//        new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
//        new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
//    };


//    static void PrintReport(List<Product> products, Action<Product> action)
//    {
//        foreach (Product p in products)
//            action(p);
//    }


//    static List<T> TransformProducts<T>(
//        List<Product> products, Func<Product, T> transform)
//    {
//        return products.Select(transform).ToList();
//    }


//    static List<Product> FilterProducts(
//        List<Product> products, Predicate<Product> predicate)
//    {
//        return products.FindAll(predicate);
//    }

//    static void Main()
//    {
//        PrintReport(products, p =>
//            Console.WriteLine($"{p.Name} - ${p.Price}"));

//        Console.WriteLine("\n--- Detailed Report ---");

//        PrintReport(products.Where(p => p.Id <= 7).ToList(), p =>
//            Console.WriteLine(
//                $"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));

//        Console.WriteLine("\n--- Summary List ---");

//        List<string> summary = TransformProducts(
//            products.Where(p => p.Id <= 7).ToList(),
//            p => $"{p.Name} (${p.Price})");

//        summary.ForEach(Console.WriteLine);

//        Console.WriteLine("\n--- Price Labels ---");

//        PrintReport(products.Where(p =>
//            p.Name == "Laptop" ||
//            p.Name == "Phone" ||
//            p.Name == "T-Shirt" ||
//            p.Name == "Novel" ||
//            p.Name == "Headphones" ||
//            p.Name == "Jacket").ToList(), p =>
//            {
//                string label = p.Price > 100 ? "Expensive!" : "Affordable";
//                Console.WriteLine($"{p.Name}: {label}");
//            });

//        Console.WriteLine("\n--- Low Stock Alert ---");

//        List<Product> lowStock = FilterProducts(
//            products, p => p.Stock < 20);

//        PrintReport(lowStock, p =>
//            Console.WriteLine(
//                $"[LOW STOCK] {p.Name}: only {p.Stock} left!"));
//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> grades = new List<int>
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

        Console.WriteLine("Grades:");
        grades.ForEach(g => Console.Write(g + " "));

        Console.WriteLine("\nCount: " + grades.Count);
        Console.WriteLine("First Grade: " + grades.First());
        Console.WriteLine("Last Grade: " + grades.Last());

        grades.Sort();

        Console.WriteLine("\nSorted Grades:");
        grades.ForEach(g => Console.Write(g + " "));

        int firstAbove90 = grades.First(g => g > 90);
        Console.WriteLine("\n\nFirst Grade Above 90: " + firstAbove90);

        List<int> failingGrades = grades.Where(g => g < 75).ToList();

        Console.WriteLine("Failing Grades:");
        failingGrades.ForEach(g => Console.Write(g + " "));

        grades.RemoveAll(g => g < 75);

        Console.WriteLine("\n\nAfter Removing Failing Grades:");
        grades.ForEach(g => Console.Write(g + " "));

        Console.WriteLine("\n\nAny Grade Equals 100: " + grades.Any(g => g == 100));

        List<string> gradeStrings = grades
            .Select(g => $"Grade: {g}")
            .ToList();

        Console.WriteLine("\nGrade Strings:");
        gradeStrings.ForEach(Console.WriteLine);
    }
}
