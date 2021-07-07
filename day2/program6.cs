using System;

namespace day2
{
    class program5
    {
        public void compare()
        {
            string firstName, lastName;
            int num1, num2;
            //get first name
            Console.WriteLine("enter your first name: ");
            firstName = Console.ReadLine();
            //get last name
            Console.WriteLine("enter your last name: ");
            lastName = Console.ReadLine();
            //get first num
            Console.WriteLine("enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //get last num
            Console.WriteLine("enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            //compare string
            if (firstName == lastName)
            {
                Console.WriteLine("They are same...");
            }
            else
            {
                Console.WriteLine("They are not same..");
            }
            //compare numbers
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are same...");
            }
            else
            {
                Console.WriteLine("They numbers are not same..");
            }
            //compare both
            if (firstName == lastName && num1 == num2)
            {
                Console.WriteLine("Both numbers and names are same");
            }
            else
            {
                Console.WriteLine("They are not same");
            }
        }
    }
}