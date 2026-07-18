# Lab 2 - Setting Up the Database Context

## Objective

Configure Entity Framework Core DbContext and connect to SQL Server.

## Models

- Category
- Product

## DbContext

Created AppDbContext with:

- DbSet<Product>
- DbSet<Category>

Configured SQL Server using UseSqlServer().

## Files

- Models/Category.cs
- Models/Product.cs
- Data/AppDbContext.cs
- Program.cs
- appsettings.json

## Packages

- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design

## Result

Successfully configured DbContext and SQL Server connection.