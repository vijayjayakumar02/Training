using System;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //finding duplicate of array elements
            Arrays arr = new Arrays();
            arr.play_arrays();

            //checking conditions of state and country name using if-else statement
            stateNames checkConditon = new stateNames();
            Console.WriteLine(checkConditon.countryName());

            //Finding whether the oriention is landscape or portrait
            orientation display = new orientation();
            display.get_orientation();

            //Creating a customer_details
            void get_customer(string customerName, int customerId)
            {
                Console.WriteLine(placeOrder(customerName, customerId));
                Console.WriteLine(getTimeZone());

            }
            Console.WriteLine("Enter your details:");
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            get_customer(name, 798956);
        }
        public static string placeOrder(string customerName, int customerId)
        {
            return $"{customerName} your order is placed and your ID is {customerId}";
        }
        public static string getTimeZone()
        {
            return "your time zone is 7/8/2021 11.45.00 am";
        }
    }
}
