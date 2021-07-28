using System;

namespace _28_july_21
{
    class SecondLargestElement
    {
        public void findSecondLargest()
        {
            System.Console.WriteLine("Enter number of Element: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            System.Console.WriteLine("Enter the elements...");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            System.Console.WriteLine("Your Second Largest Element is : " + arr[arr.Length - 2]);
        }
    }
}