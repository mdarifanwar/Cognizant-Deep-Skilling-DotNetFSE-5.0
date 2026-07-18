\# Exercise 2 - Create Stored Procedure



\## Objective



Implement SQL Server Stored Procedures for retrieving and inserting employee records.



\## Database



EmployeeManagementSystem



\## Tables



\- Departments

\- Employees



\## Stored Procedures



\### 1. sp\_GetEmployeesByDepartment



Retrieves employees belonging to a specified department.



Example:



```sql

EXEC sp\_GetEmployeesByDepartment 3;

```



\### 2. sp\_InsertEmployee



Inserts a new employee into the Employees table.



Example:



```sql

EXEC sp\_InsertEmployee

'David',

'Wilson',

2,

6500,

'2024-01-10';

```



\## Output



\- Employee details retrieved successfully by Department ID.

\- New employee inserted successfully using Stored Procedure.

