using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get inputs First name and Last name 
            String firstname = Console.ReadLine();
            String lastname = Console.ReadLine();
            Console.WriteLine("The name is {0} {1}", firstname, lastname);

            //Display sum of two numbers 
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine("The result: " + sum);

            //Display the result of dividing two numbers 
            int n1 = 10;
            int n2 = 5;
            int res = n1 / n2;
            Console.WriteLine("The result is:" + res);

            //Console WriteLine - concatenation
            Console.WriteLine(firstname + lastname);

            //Console WriteLine - paramerized
            Console.WriteLine("{0} {1}", firstname, lastname);
        }
    }
}
