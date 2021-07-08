using System;

namespace sample.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            string myValues = "testing";
            int outputValue = 10;
            if (int.TryParse(myValues, out outputValue))
            {
                Console.WriteLine($"{myValues} is an integer  and returns {outputValue}");
            }
            else
            {
                Console.WriteLine($"{myValues} is not an integer");
            }
        }
    }
}
