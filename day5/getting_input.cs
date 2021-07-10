using System;
using System.Collections;

namespace day5
{
    class Program
    {
        public void get_input()
        {
            ArrayList names = new ArrayList();
            Console.WriteLine("Enter names or Enter to exit:");
            do
            {
                names.Add(Console.ReadLine());
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            if (names.Count >= 2)
            {
                Console.WriteLine(string.Format("{0}, {1} and {2} others liked your post.", names[0], names[1], names.Count - 2));
            }
            else if (names.Count == 2)
            {
                Console.WriteLine(string.Format("{0} and {1}liked your post.", names[0], names[1]));
            }
            else if (names.Count == 1)
            {
                Console.WriteLine(string.Format("{0} liked your post.", names[0]));
            }
        }
    }
}
