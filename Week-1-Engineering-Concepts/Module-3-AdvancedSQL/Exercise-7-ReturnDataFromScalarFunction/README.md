\# Advanced SQL - Exercise 7: Return Data from a Scalar Function



\## Exercise Name



\*\*Exercise 7: Return Data from a Scalar Function\*\*



\---



\# Objective



The objective of this exercise is to understand how Scalar Functions work in SQL Server. This exercise demonstrates creating a user-defined scalar function that calculates the annual salary of an employee based on the monthly salary stored in the database.



\---



\# Learning Outcomes



After completing this exercise, you will be able to:



\- Understand Scalar Functions in SQL Server.

\- Create User-Defined Functions (UDFs).

\- Pass parameters to a function.

\- Return a single calculated value.

\- Execute scalar functions using SQL queries.

\- Perform calculations inside SQL functions.



\---



\# Prerequisites



Before performing this exercise, ensure the following software is installed:



\- Microsoft SQL Server

\- SQL Server Management Studio (SSMS) / Visual Studio SQL

\- Sample Employee Database

\- Basic SQL Knowledge



\---



\# Technologies Used



\- SQL

\- SQL Server

\- User Defined Functions (UDF)

\- Scalar Functions



\---



\# Project Structure



```

Exercise-7-ReturnDataFromScalarFunction/

│

├── SQL Scripts/

│   ├── DatabaseSchema.sql

│   ├── SampleData.sql

│   ├── CreateScalarFunction.sql

│   └── ExecuteScalarFunction.sql

│

├── Screenshots/

│   ├── Folder.png

│   ├── DatabaseSchema.png

│   ├── SampleData.png

│   ├── CreateScalarFunction.png

│   ├── ExecuteScalarFunction.png

│   └── Output.png

│

└── README.md

```



\---



\# Exercise Description



This exercise demonstrates the creation and execution of a Scalar Function named \*\*fn\_CalculateAnnualSalary\*\*.



The function:



\- Accepts EmployeeID as input.

\- Retrieves the employee's monthly salary.

\- Calculates Annual Salary by multiplying the monthly salary by 12.

\- Returns the calculated annual salary.



\---



\# SQL Concepts Used



\- CREATE FUNCTION

\- RETURNS

\- DECLARE

\- SELECT Statement

\- Parameters

\- RETURN Statement

\- Scalar Functions



\---



\# Features



\- User Defined Scalar Function

\- Parameterized Function

\- Salary Calculation

\- Annual Salary Generation

\- SQL Function Execution



\---



\# Execution Workflow



1\. Create the Employee Management System database.

2\. Create Departments and Employees tables.

3\. Insert sample data.

4\. Create the scalar function \*\*fn\_CalculateAnnualSalary\*\*.

5\. Execute the function by passing an EmployeeID.

6\. Verify the returned annual salary.



\---



\# Screenshots



\## 1. Folder Structure



This screenshot shows the complete project folder containing SQL scripts, screenshots, and the README file. It demonstrates the organized structure of the exercise.



\---



\## 2. DatabaseSchema.sql



This screenshot displays the SQL script used to create the \*\*Departments\*\* and \*\*Employees\*\* tables required for the Employee Management System database.



\---



\## 3. SampleData.sql



This screenshot shows the SQL statements used to insert sample records into the \*\*Departments\*\* and \*\*Employees\*\* tables for testing the scalar function.



\---



\## 4. CreateScalarFunction.sql



This screenshot displays the implementation of the \*\*fn\_CalculateAnnualSalary\*\* scalar function. The function accepts an EmployeeID, retrieves the monthly salary from the Employees table, calculates the annual salary by multiplying it by 12, and returns the calculated value.



\---



\## 5. ExecuteScalarFunction.sql



This screenshot shows the SQL statement used to execute the scalar function.



```sql

USE EmployeeManagementSystem;

GO



SELECT dbo.fn\_CalculateAnnualSalary(1) AS AnnualSalary;

GO

```



The query calls the scalar function by passing \*\*EmployeeID = 1\*\* and returns the employee's annual salary.



\---



\## 6. Output



This screenshot displays the successful execution of the scalar function.



Output:



| AnnualSalary |

|--------------|

| 60000.00 |



The result confirms that the employee's monthly salary (\*\*5000.00\*\*) has been correctly converted into an annual salary.



Calculation:



```

Annual Salary = Monthly Salary × 12



5000 × 12 = 60000

```



\---



\# Expected Output



Executing the following query:



```sql

SELECT dbo.fn\_CalculateAnnualSalary(1) AS AnnualSalary;

```



returns:



| AnnualSalary |

|--------------|

| 60000.00 |



\---



\# Advantages of Scalar Functions



\- Encapsulates reusable business logic.

\- Improves code readability.

\- Reduces repetitive calculations.

\- Returns a single value efficiently.

\- Simplifies SQL queries.



\---



\# Conclusion



This exercise demonstrates the implementation of a User-Defined Scalar Function in SQL Server. The function calculates the annual salary of an employee using the monthly salary stored in the Employees table. It provides practical experience in creating reusable SQL functions, parameter handling, and returning calculated values, which are essential concepts in database programming.



\---



\# Author



\*\*Md Arif Ansari\*\*



B.Tech – Computer Science and Engineering



Vignan University



Cognizant Digital Nurture 5.0

