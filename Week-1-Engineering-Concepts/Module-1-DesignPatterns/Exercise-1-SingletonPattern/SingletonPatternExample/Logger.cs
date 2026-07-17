using System;

namespace SingletonPatternExample
{
    public sealed class Logger
    {
        // Step 1: Create a private static instance
        private static Logger instance;

        // Step 2: Lock object for thread safety
        private static readonly object lockObject = new object();

        // Step 3: Private constructor
        private Logger()
        {
            Console.WriteLine("Logger Instance Created");
        }

        // Step 4: Public method to get the single instance
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }

            return instance;
        }

        // Logging method
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}