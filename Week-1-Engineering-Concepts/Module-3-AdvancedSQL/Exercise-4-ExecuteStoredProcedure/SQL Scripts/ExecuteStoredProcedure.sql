USE EmployeeManagementSystem;
GO

EXEC dbo.sp_GetEmployeesByDepartment
     @DepartmentID = 1;
GO