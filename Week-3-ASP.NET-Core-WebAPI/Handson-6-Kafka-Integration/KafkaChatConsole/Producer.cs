using Confluent.Kafka;
using System;

public class Producer
{
    public static void Start()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer =
            new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Type message.");
        Console.WriteLine("Type exit to stop.");

        while (true)
        {
            Console.Write("Message : ");

            string message = Console.ReadLine();

            if (message.ToLower() == "exit")
                break;

            producer.Produce(
                "chat-message",
                new Message<Null, string>
                {
                    Value = message
                });

            producer.Flush(TimeSpan.FromSeconds(2));

            Console.WriteLine("Sent.");
        }
    }
}