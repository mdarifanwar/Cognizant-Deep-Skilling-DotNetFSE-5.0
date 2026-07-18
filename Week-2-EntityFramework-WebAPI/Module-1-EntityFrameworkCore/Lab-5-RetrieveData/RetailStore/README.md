# Lab 5 - Retrieving Data from the Database

## Objective

Learn how to retrieve data from SQL Server using Entity Framework Core.

---

## Scenario

The retail store wants to display product information on its dashboard.

---

## Technologies Used

- C#
- .NET 8
- Entity Framework Core 8
- SQL Server LocalDB

---

## EF Core Methods Used

- ToListAsync()
- FindAsync()
- FirstOrDefaultAsync()

---

## Operations Performed

1. Retrieved all products.
2. Retrieved a product by ID.
3. Retrieved the first product with price greater than ₹50,000.

---

## Commands

```bash
dotnet build
dotnet run
```

---

## Expected Output

```
All Products:
Laptop - ₹75000.00
Rice Bag - ₹1200.00

Found Product: Laptop

Expensive Product: Laptop
```

---

## Result

Successfully retrieved product data from SQL Server using Entity Framework Core methods `ToListAsync()`, `FindAsync()`, and `FirstOrDefaultAsync()`.