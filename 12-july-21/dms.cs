// 3.A program to convert the decimal to DMS (GPS coordinates). Make use of all datatypes concepts and also use classes and methods as much as possible.
//  Also learn an make use of Math Function,
using System;

namespace day6
{
    class Dms
    {
        public void get_input()
        {
            Console.WriteLine("Enter the input: ");
            double input = Convert.ToDouble(Console.ReadLine());
            int degree = (int)input;
            double minutes = input - degree;
            double min = minutes * 60;
            int min_int = (int)min;
            double seconds = min - min_int;
            int secs = second(seconds);
            Console.WriteLine($"Decimal Degrees {input} converts to {degree} degrees, {min_int} minutes and {secs} seconds or {degree}° {min_int}' {secs}.");
        }
        public int second(double num)
        {
            double secs = Math.Round(60 * num);
            return (int)secs;
        }
    }
}