using FinancialForecastingExample.Models;
using FinancialForecastingExample.Services;

Console.WriteLine("========== Financial Forecasting ==========\n");

FinancialData current = new FinancialData(2026, 1000000);

double growthRate = 0.08;   //8%
int forecastYears = 5;

ForecastService service = new ForecastService();

double predictedRevenue =
    service.Forecast(current.Revenue, growthRate, forecastYears);

Console.WriteLine($"Current Year        : {current.Year}");
Console.WriteLine($"Current Revenue     : ₹{current.Revenue:N2}");
Console.WriteLine($"Annual Growth Rate  : {growthRate * 100}%");
Console.WriteLine($"Forecast Years      : {forecastYears}");

Console.WriteLine();

Console.WriteLine("Forecast Result");
Console.WriteLine("-----------------------------");

Console.WriteLine($"Predicted Revenue : ₹{predictedRevenue:N2}");

Console.WriteLine();

Console.WriteLine("Analysis");
Console.WriteLine("-----------------------------");
Console.WriteLine("Time Complexity  : O(n)");
Console.WriteLine("Space Complexity : O(n)");
Console.WriteLine();
Console.WriteLine("Optimization:");
Console.WriteLine("- Memoization can avoid repeated recursive calculations.");
Console.WriteLine("- Dynamic Programming can further improve efficiency.");