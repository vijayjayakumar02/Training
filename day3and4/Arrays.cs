using System;
using System.Collections;

namespace day3
{
    class Arrays
    {
        public void play_arrays()
        {
            Console.WriteLine("Enter the length of the array:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            ArrayList arrlist = new ArrayList();
            for (int i = 0; i < len; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arrlist.Add(arr[i]);
                    }
                }
            }
            foreach (int element in arrlist)
            {
                Console.Write(element + " ");
            }
        }
    }
}