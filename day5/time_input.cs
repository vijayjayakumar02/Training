using System;

namespace day5
{
    class time_input
    {
        public void checkTimeInput()
        {
            Console.WriteLine("Enter the time input in the format of HH:MM :");
            try
            {
                DateTime time = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Valid Time Input");
            }
            catch
            {
                Console.WriteLine("Invalid Time Input");
            }
        }
    }
}