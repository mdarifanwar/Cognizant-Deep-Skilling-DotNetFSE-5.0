# Lab 4 - Inserting Initial Data into the Database

## Objective

Learn how to insert initial data into a SQL Server database using Entity Framework Core.

---

## Scenario

The retail store requires initial categories and products to be added to the database.

---

## Technologies Used

- C#
- .NET 8
- Entity Framework Core 8
- SQL Server
- Visual Studio 2022

---

## Tables

### Categories

- Id
- Name

### Products

- Id
- Name
- Price
- CategoryId

---

## EF Core Methods Used

- AddRangeAsync()
- SaveChangesAsync()

---

## Program Flow

1. Create Category objects.
2. Insert categories.
3. Create Product objects.
4. Associate products with categories.
5. Save all changes to SQL Server.

---

## Command Used

```bash
dotnet run
```

---

## Output

```
Categories inserted successfully.
Products inserted successfully.
Database updated successfully.
```

---

## SQL Verification

```sql
SELECT * FROM Categories;

SELECT * FROM Products;
```

---

## Result

Successfully inserted initial categories and products into the RetailStore database using Entity Framework Core.