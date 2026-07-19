using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeWebAPI.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var message = context.Exception.ToString();

        File.AppendAllText(
            "ExceptionLog.txt",
            $"[{DateTime.Now}] {message}{Environment.NewLine}{Environment.NewLine}");

        context.Result = new ObjectResult("Internal Server Error")
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };

        context.ExceptionHandled = true;
    }
}