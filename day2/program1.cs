using System;

namespace day2
{
    class program_1
    {
        public void print()
        {
            //referenced datatype
            string name = Console.ReadLine();

            // Value data types
            int num1 = 258;
            char character = 'c';
            short num2 = 25;
            float num3 = 8.5698f;
            double num4 = 856.5666646d;

            //printing all the datatypes
            Console.WriteLine("Referenced datatype");
            Console.WriteLine("String: " + name);
            Console.WriteLine("value data type");
            Console.WriteLine("int: " + num1);
            Console.WriteLine("character: " + character);
            Console.WriteLine("short: " + num2);
            Console.WriteLine("float: " + num3);
            Console.WriteLine("double: " + num4);

        }
    }
}