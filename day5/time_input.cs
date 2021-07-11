//4.Ask the user to enter the time in 24 hours format (eg: 17:00), If the time is between 00:00  
//and 23:59  then display as valid time else display as invalid time. 

using System;

namespace day5
{
    class time_input
    {
        //Getting the time input in a proper format
        public void checkTimeInput()
        {
            Console.WriteLine("Enter the time input in the format of HH:MM :");

            //Printing whether the time format is valid or not.
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