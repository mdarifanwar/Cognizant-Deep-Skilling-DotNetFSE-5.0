USE EmployeeManagementSystem;
GO

IF OBJECT_ID('dbo.fn_CalculateAnnualSalary', 'FN') IS NOT NULL
    DROP FUNCTION dbo.fn_CalculateAnnualSalary;
GO

CREATE FUNCTION dbo.fn_CalculateAnnualSalary
(
    @EmployeeID INT
)
RETURNS DECIMAL(10,2)
AS
BEGIN

    DECLARE @AnnualSalary DECIMAL(10,2);

    SELECT
        @AnnualSalary = Salary * 12
    FROM dbo.Employees
    WHERE EmployeeID = @EmployeeID;

    RETURN @AnnualSalary;

END;
GO