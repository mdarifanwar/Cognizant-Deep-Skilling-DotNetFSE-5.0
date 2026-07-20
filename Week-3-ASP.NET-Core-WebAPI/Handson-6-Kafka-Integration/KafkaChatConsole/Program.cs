using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("====== Kafka Chat ======");
            Console.WriteLine("1. Producer");
            Console.WriteLine("2. Consumer");
            Console.WriteLine("3. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Producer.Start();
                    break;

                case "2":
                    Consumer.Start();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}