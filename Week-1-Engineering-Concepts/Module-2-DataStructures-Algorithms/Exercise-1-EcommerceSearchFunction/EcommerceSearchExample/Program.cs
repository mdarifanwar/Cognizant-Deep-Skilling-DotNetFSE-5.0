using EcommerceSearchExample.Models;
using EcommerceSearchExample.Services;

namespace EcommerceSearchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Laptop","Electronics"),
                new Product(102,"Keyboard","Electronics"),
                new Product(103,"Shoes","Fashion"),
                new Product(104,"Watch","Accessories"),
                new Product(105,"Mobile","Electronics")
            };

            Console.WriteLine("===== E-Commerce Search Function =====");
            Console.WriteLine();

            Console.WriteLine("Linear Search");
            Product linear = LinearSearch.Search(products, 104);

            if (linear != null)
                linear.Display();
            else
                Console.WriteLine("Product Not Found");

            Array.Sort(products, (x, y) => x.ProductId.CompareTo(y.ProductId));

            Console.WriteLine("Binary Search");
            Product binary = BinarySearch.Search(products, 104);

            if (binary != null)
                binary.Display();
            else
                Console.WriteLine("Product Not Found");

            Console.WriteLine("Time Complexity");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Linear Search : O(n)");
            Console.WriteLine("Binary Search : O(log n)");
            Console.WriteLine();
            Console.WriteLine("Binary Search is faster because it repeatedly divides the search space into halves.");
        }
    }
}