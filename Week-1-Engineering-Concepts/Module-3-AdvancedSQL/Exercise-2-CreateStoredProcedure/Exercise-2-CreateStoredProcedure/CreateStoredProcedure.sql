/*=========================================================
  Employee Management System
  Exercise 1 : Stored Procedures
=========================================================*/

-- Create Database (Only if it doesn't exist)
IF DB_ID('EmployeeManagementSystem') IS NULL
BEGIN
    CREATE DATABASE EmployeeManagementSystem;
END;
GO

USE EmployeeManagementSystem;
GO

---------------------------------------------------------
-- Drop Procedures if they already exist
---------------------------------------------------------

DROP PROCEDURE IF EXISTS sp_GetEmployeesByDepartment;
DROP PROCEDURE IF EXISTS sp_InsertEmployee;
GO

---------------------------------------------------------
-- Create Tables (Only if they don't exist)
---------------------------------------------------------

IF OBJECT_ID('Departments','U') IS NULL
BEGIN
    CREATE TABLE Departments
    (
        DepartmentID INT PRIMARY KEY,
        DepartmentName VARCHAR(100)
    );
END;
GO

IF OBJECT_ID('Employees','U') IS NULL
BEGIN
    CREATE TABLE Employees
    (
        EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
        FirstName VARCHAR(50),
        LastName VARCHAR(50),
        DepartmentID INT,
        Salary DECIMAL(10,2),
        JoinDate DATE,

        FOREIGN KEY (DepartmentID)
        REFERENCES Departments(DepartmentID)
    );
END;
GO

---------------------------------------------------------
-- Insert Sample Data (Only once)
---------------------------------------------------------

IF NOT EXISTS (SELECT * FROM Departments)
BEGIN
    INSERT INTO Departments
    VALUES
    (1,'HR'),
    (2,'Finance'),
    (3,'IT'),
    (4,'Marketing');
END;
GO

IF NOT EXISTS (SELECT * FROM Employees)
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    ('John','Doe',1,5000,'2020-01-15'),
    ('Jane','Smith',2,6000,'2019-03-22'),
    ('Michael','Johnson',3,7000,'2018-07-30'),
    ('Emily','Davis',4,5500,'2021-11-05');
END;
GO

---------------------------------------------------------
-- Stored Procedure 1
---------------------------------------------------------

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN

    SELECT
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;

END;
GO

---------------------------------------------------------
-- Test Procedure 1
---------------------------------------------------------

EXEC sp_GetEmployeesByDepartment 3;
GO

---------------------------------------------------------
-- Stored Procedure 2
---------------------------------------------------------

CREATE PROCEDURE sp_InsertEmployee

    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE

AS
BEGIN

    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )

    VALUES
    (
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );

END;
GO

---------------------------------------------------------
-- Test Procedure 2
---------------------------------------------------------

EXEC sp_InsertEmployee
    'David',
    'Wilson',
    2,
    6500,
    '2024-01-10';
GO

---------------------------------------------------------
-- Verify Result
---------------------------------------------------------

SELECT *
FROM Employees;
GO