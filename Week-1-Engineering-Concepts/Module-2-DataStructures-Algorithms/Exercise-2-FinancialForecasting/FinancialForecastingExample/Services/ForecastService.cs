namespace FinancialForecastingExample.Services
{
    public class ForecastService
    {
        // Recursive Method
        public double Forecast(double currentRevenue, double growthRate, int years)
        {
            if (years == 0)
                return currentRevenue;

            return Forecast(
                currentRevenue * (1 + growthRate),
                growthRate,
                years - 1);
        }
    }
}