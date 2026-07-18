# Lab 6 - Updating and Deleting Records

## Objective

Learn how to update and delete records using Entity Framework Core.

---

## Scenario

The retail store updates product prices and removes discontinued products.

---

## Technologies Used

- C#
- .NET 8
- Entity Framework Core 8
- SQL Server LocalDB

---

## EF Core Methods Used

- FirstOrDefaultAsync()
- SaveChangesAsync()
- Remove()

---

## Operations Performed

1. Updated Laptop price from ₹75000 to ₹70000.
2. Deleted Rice Bag from the Products table.
3. Displayed the remaining products.

---

## Commands

```bash
dotnet build
dotnet run
```

---

## Expected Output

```
Product price updated successfully.
Product deleted successfully.

Current Products:

1 - Laptop - ₹70000.00
```

---

## SQL Verification

```sql
SELECT * FROM Products;
```

---

## Result

Successfully updated and deleted records in the RetailStore database using Entity Framework Core.