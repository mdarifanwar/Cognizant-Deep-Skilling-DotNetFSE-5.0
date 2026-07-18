# Lab 7 - Writing Queries with LINQ

## Objective

Learn how to retrieve and filter data using LINQ queries in Entity Framework Core.

---

## Scenario

The retail store wants to filter, sort, and project product data for reporting.

---

## Technologies Used

- C#
- .NET 8
- Entity Framework Core 8
- SQL Server LocalDB

---

## LINQ Methods Used

- Where()
- OrderByDescending()
- Select()
- ToListAsync()

---

## Operations Performed

1. Filtered products with price greater than ₹1000.
2. Sorted products in descending order by price.
3. Projected product data into anonymous DTO objects.

---

## Commands

```bash
dotnet build
dotnet run
```

---

## Expected Output

```
Products with Price > ₹1000 (Descending Order):

Laptop - ₹70000.00

Product DTOs:

Laptop - ₹70000.00
```

---

## SQL Verification

```sql
SELECT * FROM Products;
```

---

## Result

Successfully retrieved, filtered, sorted, and projected product data using LINQ queries with Entity Framework Core.