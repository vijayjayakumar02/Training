using System;
using System.Collections.Generic;

namespace _03_August_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());//getting the number of element
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int totalSum = 0;
            for (int i = 0; i < size; i++)
            {
                totalSum += arr1[i];//getting total sum of elements
            }
            for (int i = 0; i < size; i++)
            {
                arr2[i] += totalSum - arr1[i];
                System.Console.Write(arr2[i] + " ");
            }
        }
    }
}
