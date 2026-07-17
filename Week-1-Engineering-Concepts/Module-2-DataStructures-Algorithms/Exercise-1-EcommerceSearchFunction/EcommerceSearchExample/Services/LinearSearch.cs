using EcommerceSearchExample.Models;

namespace EcommerceSearchExample.Services
{
    public class LinearSearch
    {
        public static Product Search(Product[] products, int id)
        {
            foreach (Product product in products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }

            return null;
        }
    }
}