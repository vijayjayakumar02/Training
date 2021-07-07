using System;

namespace day2
{
    class program2
    {
        public void sal_details()
        {
            string Id, Name, Salary;
            //get id
            Console.WriteLine("Enter your id: ");
            Id = Console.ReadLine();
            //get name
            Console.WriteLine("Enter your Name: ");
            Name = Console.ReadLine();
            //get salary
            Console.WriteLine("Enter your Salary: ");
            Salary = Console.ReadLine();
            //print details
            Console.WriteLine("your details:");
            Console.WriteLine(Convert.ToInt32(Id));
            Console.WriteLine(Name);
            Console.WriteLine(Convert.ToInt64(Salary));
        }
    }
}