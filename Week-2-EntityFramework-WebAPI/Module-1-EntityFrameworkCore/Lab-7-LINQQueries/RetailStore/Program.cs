using Microsoft.EntityFrameworkCore;
using RetailStore.Data;

using var context = new AppDbContext();

Console.WriteLine("======================================");
Console.WriteLine(" Retail Store");
Console.WriteLine(" EF Core 8.0");
Console.WriteLine(" Lab 7 - LINQ Queries");
Console.WriteLine("======================================");

// Filter and Sort
Console.WriteLine("\nProducts with Price > ₹1000 (Descending Order):");

var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

foreach (var product in filtered)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

// Projection using Select
Console.WriteLine("\nProduct DTOs:");

var productDTOs = await context.Products
    .Select(p => new
    {
        p.Name,
        p.Price
    })
    .ToListAsync();

foreach (var item in productDTOs)
{
    Console.WriteLine($"{item.Name} - ₹{item.Price}");
}