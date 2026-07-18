# Lab 1 - Understanding ORM with a Retail Inventory System

## Objective

Understand Object Relational Mapping (ORM) and how Entity Framework Core maps C# classes to SQL Server database tables.

## What is ORM?

ORM (Object Relational Mapping) maps C# objects to relational database tables, allowing developers to work with objects instead of writing SQL queries manually.

## Benefits of ORM

- Reduces SQL code
- Improves productivity
- Easy maintenance
- Better abstraction
- Supports LINQ

## EF Core vs EF Framework

### Entity Framework Core

- Cross-platform
- Lightweight
- High performance
- Supports LINQ
- Supports async queries
- Modern architecture

### Entity Framework 6

- Windows only
- Mature framework
- Less flexible

## EF Core 8.0 Features

- JSON Column Mapping
- Compiled Models
- Better Performance
- Interceptors
- Improved Bulk Operations

## Commands Used

```bash
dotnet new console -n RetailInventory
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet build
dotnet run