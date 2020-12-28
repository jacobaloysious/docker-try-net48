using System;
using System.IO;
using System.Threading;

namespace jacapp
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(ThreadWork.PrintToConsole);

            RunOnThread(ThreadWork.PrintToConsole);
            RunOnThread(ThreadWork.WriteToFile);

            Thread.Sleep(20000);
            Environment.Exit(0);
        }

        static void RunOnThread(ThreadStart action)
        {
            var thread = new Thread(action);
            thread.Start();
        }
    }

    public class ThreadWork
    {
        public static void PrintToConsole()
        {
            uint count = 0;
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Count: {count++}");
            }
        }

        public static void WriteToFile()
        {
            uint count = 0;

            //Delete: coz: We are gona run this inside the container; but the drive would be monted
            File.Delete("output.txt");
            Directory.CreateDirectory("out");

            while (true)
            {
                Thread.Sleep(2000);

                using (var file = new StreamWriter(@"out\output.txt", true))
                {
                    file.WriteLine($"Count: {count++}");
                }
            }
        }
    }
}