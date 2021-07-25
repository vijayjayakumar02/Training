using System;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();

        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    System.Console.WriteLine("method 1");
                    Task.Delay(100).Wait();
                }
            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("method 2");
                Task.Delay(100).Wait();
            }

        }
    }
}
