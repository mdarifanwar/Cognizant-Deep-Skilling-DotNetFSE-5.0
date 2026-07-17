namespace FinancialForecastingExample.Models
{
    public class FinancialData
    {
        public int Year { get; set; }

        public double Revenue { get; set; }

        public FinancialData(int year, double revenue)
        {
            Year = year;
            Revenue = revenue;
        }
    }
}