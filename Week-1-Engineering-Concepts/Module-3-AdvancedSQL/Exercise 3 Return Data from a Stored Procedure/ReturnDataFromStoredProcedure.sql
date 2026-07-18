/*=========================================================
 Employee Management System
 Exercise 5 : Return Data from a Stored Procedure
=========================================================*/

USE EmployeeManagementSystem;
GO

---------------------------------------------------------
-- Drop Procedure if it already exists
---------------------------------------------------------

DROP PROCEDURE IF EXISTS sp_GetEmployeeCountByDepartment;
GO

---------------------------------------------------------
-- Create Stored Procedure
---------------------------------------------------------

CREATE PROCEDURE sp_GetEmployeeCountByDepartment

    @DepartmentID INT

AS
BEGIN

    SELECT
        DepartmentID,
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID
    GROUP BY DepartmentID;

END;
GO

---------------------------------------------------------
-- Execute Stored Procedure
---------------------------------------------------------

EXEC sp_GetEmployeeCountByDepartment 1;
GO

EXEC sp_GetEmployeeCountByDepartment 2;
GO

EXEC sp_GetEmployeeCountByDepartment 3;
GO

EXEC sp_GetEmployeeCountByDepartment 4;
GO