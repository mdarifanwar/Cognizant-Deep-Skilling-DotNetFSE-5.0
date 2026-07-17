using EcommerceSearchExample.Models;

namespace EcommerceSearchExample.Services
{
    public class BinarySearch
    {
        public static Product Search(Product[] products, int id)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (products[mid].ProductId == id)
                    return products[mid];

                if (products[mid].ProductId < id)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}