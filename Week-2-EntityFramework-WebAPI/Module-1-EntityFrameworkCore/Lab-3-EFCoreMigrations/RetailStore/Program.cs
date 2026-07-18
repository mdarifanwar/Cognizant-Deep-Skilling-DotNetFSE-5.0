using RetailStore.Data;

Console.WriteLine("====================================");
Console.WriteLine(" EF Core 8.0 - Lab 3");
Console.WriteLine(" Using EF Core CLI Migrations");
Console.WriteLine("====================================");

using var context = new AppDbContext();

Console.WriteLine();
Console.WriteLine("DbContext Loaded Successfully.");
Console.WriteLine("Now use EF Core CLI commands to create the database.");