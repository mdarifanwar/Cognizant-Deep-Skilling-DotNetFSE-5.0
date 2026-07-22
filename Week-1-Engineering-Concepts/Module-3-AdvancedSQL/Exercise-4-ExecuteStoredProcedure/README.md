# Advanced SQL - Exercise 4: Execute a Stored Procedure

## Exercise Name

**Exercise 4: Execute a Stored Procedure**

---

# Objective

The objective of this exercise is to understand how to execute a Stored Procedure in SQL Server. This exercise demonstrates passing parameters to a stored procedure and retrieving employee details for a specific department from the Employee Management System database.

---

# Learning Outcomes

After completing this exercise, you will be able to:

- Understand Stored Procedures in SQL Server.
- Create and execute Stored Procedures.
- Pass parameters to a Stored Procedure.
- Retrieve filtered records from database tables.
- Improve query reusability using Stored Procedures.

---

# Prerequisites

Before performing this exercise, ensure the following software is installed:

- Microsoft SQL Server
- SQL Server Management Studio (SSMS) / Visual Studio SQL
- Employee Management System Database
- Basic SQL Knowledge

---

# Technologies Used

- SQL
- SQL Server
- Stored Procedures
- SQL Queries

---

# Project Structure

```
Exercise-4-ExecuteStoredProcedure/
│
├── SQL Scripts/
│   ├── DatabaseSchema.sql
│   ├── SampleData.sql
│   ├── CreateStoredProcedure.sql
│   └── ExecuteStoredProcedure.sql
│
├── Screenshots/
│   ├── DatabaseSchema.sql.png
│   ├── SampleData.sql.png
│   ├── CreateStoredProcedure.sql.png
│   ├── ExecuteStoredProcedure.sql.png
│   └── Output.png
│
└── README.md
```

---

# Exercise Description

This exercise demonstrates how to execute a Stored Procedure that retrieves employee details based on the Department ID.

The Stored Procedure:

- Accepts **DepartmentID** as an input parameter.
- Searches the Employees table.
- Retrieves employees belonging to the specified department.
- Displays employee information as the result.

---

# SQL Concepts Used

- CREATE PROCEDURE
- EXEC
- Parameters
- SELECT Statement
- WHERE Clause
- Stored Procedures

---

# Features

- User Defined Stored Procedure
- Parameterized Query
- Employee Search
- Department-wise Employee Retrieval
- Reusable SQL Logic

---

# Execution Workflow

1. Create the Employee Management System database.
2. Create the Departments and Employees tables.
3. Insert sample records.
4. Create the Stored Procedure.
5. Execute the Stored Procedure by passing a DepartmentID.
6. Verify the retrieved employee details.

---

# Screenshots

## 1. DatabaseSchema.sql

This screenshot shows the SQL script used to create the **Departments** and **Employees** tables. These tables form the Employee Management System database used throughout the exercise.

---

## 2. SampleData.sql

This screenshot displays the SQL statements used to insert sample department and employee records into the database. These records are used to test the stored procedure.

---

## 3. CreateStoredProcedure.sql

This screenshot shows the implementation of the Stored Procedure.

The procedure:

- Accepts **DepartmentID** as an input parameter.
- Retrieves employee details from the Employees table.
- Filters the records using the DepartmentID.
- Returns the matching employee information.

---

## 4. ExecuteStoredProcedure.sql

This screenshot shows the SQL command used to execute the stored procedure.

Example:

```sql
EXEC dbo.sp_GetEmployeesByDepartment
     @DepartmentID = 1;
```

The procedure is executed by passing **DepartmentID = 1**, and the corresponding employee details are returned.

---

## 5. Output

This screenshot displays the successful execution of the Stored Procedure.

The output includes:

- Employee ID
- First Name
- Last Name
- Department ID
- Salary
- Join Date

The result confirms that the stored procedure correctly retrieved employee information for the specified department.

---

# Expected Output

Executing:

```sql
EXEC dbo.sp_GetEmployeesByDepartment
     @DepartmentID = 1;
```

returns employee details belonging to **Department ID = 1**.

Example:

| EmployeeID | FirstName | LastName | DepartmentID | Salary | JoinDate |
|------------|-----------|----------|--------------|---------|------------|
| 1 | John | Doe | 1 | 5000.00 | 2020-01-15 |

---

# Advantages of Stored Procedures

- Improves code reusability.
- Enhances database security.
- Reduces network traffic.
- Simplifies SQL query execution.
- Improves maintainability.
- Provides better performance for repeated operations.

---

# Conclusion

This exercise demonstrates how to execute a parameterized Stored Procedure in SQL Server. By passing a Department ID as input, the procedure retrieves the corresponding employee records from the Employee Management System database. This hands-on provides practical experience with Stored Procedures, parameter handling, and efficient data retrieval techniques used in real-world database applications.

---

# Author

**Md Arif Ansari**

B.Tech – Computer Science and Engineering

Vignan University

Cognizant Digital Nurture 5.0