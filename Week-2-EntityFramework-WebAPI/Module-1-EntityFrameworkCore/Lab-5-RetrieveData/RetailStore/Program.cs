using Microsoft.EntityFrameworkCore;
using RetailStore.Data;

using var context = new AppDbContext();

Console.WriteLine("======================================");
Console.WriteLine(" Retail Store");
Console.WriteLine(" EF Core 8.0");
Console.WriteLine(" Lab 5 - Retrieving Data");
Console.WriteLine("======================================");

Console.WriteLine("\nAll Products:");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

Console.WriteLine();

var product = await context.Products.FindAsync(1);

Console.WriteLine($"Found Product: {product?.Name}");

Console.WriteLine();

var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive Product: {expensive?.Name}");