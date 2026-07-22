USE EmployeeManagementSystem;
GO

IF OBJECT_ID('dbo.sp_GetEmployeesByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetEmployeesByDepartment;
GO

CREATE PROCEDURE dbo.sp_GetEmployeesByDepartment
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