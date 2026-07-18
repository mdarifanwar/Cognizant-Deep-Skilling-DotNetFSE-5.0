using RetailStore.Data;

Console.WriteLine("===================================");
Console.WriteLine(" Retail Store");
Console.WriteLine(" EF Core 8.0");
Console.WriteLine(" Lab 2 - Database Context");
Console.WriteLine("===================================");

using AppDbContext db = new();

Console.WriteLine();
Console.WriteLine("DbContext created successfully.");
Console.WriteLine("Connection configured successfully.");
Console.WriteLine("Lab 2 completed successfully.");