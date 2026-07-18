using RetailStore.Data;
using RetailStore.Models;

Console.WriteLine("Starting application...");

try
{
    using var context = new AppDbContext();

    Console.WriteLine("DbContext created.");

    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    Console.WriteLine("Categories created.");

    await context.Categories.AddRangeAsync(electronics, groceries);

    Console.WriteLine("Categories added.");

    var product1 = new Product
    {
        Name = "Laptop",
        Price = 75000,
        Category = electronics
    };

    var product2 = new Product
    {
        Name = "Rice Bag",
        Price = 1200,
        Category = groceries
    };

    Console.WriteLine("Products created.");

    await context.Products.AddRangeAsync(product1, product2);

    Console.WriteLine("Products added.");

    Console.WriteLine("Calling SaveChangesAsync...");

    await context.SaveChangesAsync();

    Console.WriteLine("SaveChangesAsync completed.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException?.Message);
}