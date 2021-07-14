using System;
using System.Threading;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Console.WriteLine("your stopwatch application opens in 1sec....");
            Thread.Sleep(1000);
            Console.WriteLine("Loading....");
            timer.runProgram();//calling the methods from object timer
        }
    }
}
