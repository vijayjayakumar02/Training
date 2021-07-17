using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}
