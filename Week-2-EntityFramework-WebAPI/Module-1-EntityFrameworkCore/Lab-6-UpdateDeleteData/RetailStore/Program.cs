using Microsoft.EntityFrameworkCore;
using RetailStore.Data;

using var context = new AppDbContext();

Console.WriteLine("======================================");
Console.WriteLine(" Retail Store");
Console.WriteLine(" EF Core 8.0");
Console.WriteLine(" Lab 6 - Update and Delete Records");
Console.WriteLine("======================================");

// Update Product
var product = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Laptop");

if (product != null)
{
    product.Price = 70000;

    await context.SaveChangesAsync();

    Console.WriteLine("Product price updated successfully.");
}

// Delete Product
var toDelete = await context.Products
    .FirstOrDefaultAsync(p => p.Name == "Rice Bag");

if (toDelete != null)
{
    context.Products.Remove(toDelete);

    await context.SaveChangesAsync();

    Console.WriteLine("Product deleted successfully.");
}

Console.WriteLine("\nCurrent Products:");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Id} - {p.Name} - ₹{p.Price}");
}