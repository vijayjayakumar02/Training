using System;

namespace _28_july_21
{
    class Binarysearch
    {
        public void search()
        {
            System.Console.WriteLine("Enter number of Element: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            System.Console.WriteLine("Enter the elements in ascending order");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Enter the element to be found: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int position = binarySearchProcess(arr, 0, size - 1, target);
            if (position == -1)
            {
                System.Console.WriteLine("There is no element that you was searching for..");
            }
            else
            {
                System.Console.WriteLine("The element that your searching for is in postion, " + (position + 1));
            }
        }
        public int binarySearchProcess(int[] arr, int start, int end, int target)
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                if (arr[mid] > target)
                {
                    return binarySearchProcess(arr, start, mid - 1, target);
                }
                if (arr[mid] < target)
                {
                    return binarySearchProcess(arr, mid + 1, end, target);
                }
            }
            return -1;
        }
    }
}