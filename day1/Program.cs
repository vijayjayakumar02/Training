using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting first and last name
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            Console.WriteLine("{0} {1}", firstname, lastname);

            //sum of two numbers
            String n1 = Console.ReadLine();
            String n2 = Console.ReadLine();
            int sum = Convert.ToInt32(n1) + Convert.ToInt32(n2);
            Console.WriteLine("The sum is:" + sum);

            //Divide two numbers
            String num1 = Console.ReadLine();
            String num2 = Console.ReadLine();
            try
            {
                int n3 = Convert.ToInt32(num1);
                int n4 = Convert.ToInt32(num2);
                Console.WriteLine(n3 / n4);
            }
            catch
            {
                Console.WriteLine("Can't divide the num by zero");
            }

            //Console-write concatenation
            Console.WriteLine(firstname + lastname);

            //Console-write paramerized
            Console.WriteLine("{0} {1}", firstname, lastname);
        }
    }
}
