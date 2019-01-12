using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Logger
    {
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());
        private Logger()
        {
            Console.WriteLine("Singleton instance created!");
        }

        public static Logger Instance
        {
            get
            {
                Console.WriteLine("Get singleton instance");
                return instance.Value;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Task id: {Task.CurrentId}, " +
                $"Thread id: {Thread.CurrentThread.ManagedThreadId}; " +
                $"Message: {message}");
        }
    }
}
