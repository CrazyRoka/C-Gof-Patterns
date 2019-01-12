using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfTaks = 10;
            Task[] tasks = new Task[numberOfTaks];
            for(int i = 0; i < numberOfTaks; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    Logger singleton = Logger.Instance;
                    for (int step = 0; step < 10; step++)
                    {
                        singleton.Log($"Step: {step}");
                    }
                });
            }
            Task.WaitAll(tasks);
        }
    }
}
