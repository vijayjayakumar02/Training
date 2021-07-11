using System;
using System.Collections;
using System.Collections.Generic;

namespace day5
{
    class unique_elements
    {
        List<int> number = new List<int>();
        public void getElements()
        {
            Console.WriteLine("Enter the names or type \"quit\" to exit :");
            string input = Console.ReadLine();
            while (input != "quit")
            {
                int num_out = 0;
                if (int.TryParse(input, out num_out))
                {
                    addInList(num_out);
                }
                input = Console.ReadLine();
            }
        }
        public void addInList(int num)
        {
            number.Add(num);
        }
        public void print()
        {
            for (int i = 0; i < number.Count; i++)
            {
                int j = 0;
                for (j = 0; j < number.Count; j++)
                {
                    if (number[i] == number[j] && i != j)
                    {
                        break;
                    }
                }
                if (j == number.Count)
                {
                    Console.Write(number[i] + " ");
                }
            }
        }
    }
}