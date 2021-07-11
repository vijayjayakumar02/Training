//2. Write a program which continuously takes input numbers from user. If user types “Quit” then exit.  Separate the duplicates and make a new list for unique numbers.
// Example:  3,2,3,1,10,1 .  2 and 10 are unique 


using System;
using System.Collections;
using System.Collections.Generic;

namespace day5
{
    class unique_elements
    {
        List<int> number = new List<int>();
        //getting the integer elements until the user enters "quit
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
        //Adding or inserting the elements to the list
        public void addInList(int num)
        {
            number.Add(num);
        }
        //printing the unique elements that was not repeated
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