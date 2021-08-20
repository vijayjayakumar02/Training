// 1. Write a calculator program which performs all simple arithmetic operations. 
// The number of inputs for addition and multiplication can be dynamic. 
// All 4 operation addition, subtraction, multiplication and division methods 
// should have the same name. 

using System;
using System.Collections.Generic;

namespace day6
{
    class Calculator
    {
        List<int> List1 = new List<int>();
        List<int> List2 = new List<int>();
        public void getInput()
        {
            Console.WriteLine("Enter the type of calculation:");
            string get_input = Console.ReadLine();
            if (get_input == "add")
            {
                Console.WriteLine("Enter the numbers or type \"quit\" to exit :");
                string input = Console.ReadLine();
                while (input != "qui")
                {
                    int num_out = 0;
                    if (int.TryParse(input, out num_out))
                    {
                        addInList1(num_out);
                    }
                    input = Console.ReadLine();
                }
                Console.WriteLine("Your total is: " + Add());
            }
            else if (get_input == "multiply")
            {
                Console.WriteLine("Enter the numbers or type \"quit\" to exit :");
                string input = Console.ReadLine();
                while (input != "quit")
                {
                    int num_out = 0;
                    if (int.TryParse(input, out num_out))
                    {
                        addInList2(num_out);
                    }
                    input = Console.ReadLine();
                }
                Console.WriteLine("Your product is: " + multiply());
            }
            else if (get_input == "subtract")
            {
                Console.WriteLine("Enter two numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int sub = a - b;
                Console.WriteLine("Your result is:" + Math.Abs(sub));
            }
            else if (get_input == "divide")
            {
                Console.WriteLine("Enter two numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                float div = 0;
                try
                {
                    div = a / b;
                }
                catch
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                Console.WriteLine("your result is:" + div);
            }
        }
        public void addInList1(int num)
        {
            List1.Add(num);
        }
        public void addInList2(int num)
        {
            List2.Add(num);
        }
        public int Add()
        {
            int total = 0;
            foreach (int num in List1)
            {
                total += num;
            }
            return total;
        }
        public int multiply()
        {
            int total = 1;
            foreach (int num in List2)
            {
                total *= num;
            }
            return total;
        }
    }
}