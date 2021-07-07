using System;

namespace day2
{
    class program3
    {
        public void getLetter()
        {
            char[] charArray = new char[3];
            for (int i = 0; i < 3; i++)
            {
                char c = Convert.ToChar(Console.ReadLine());
                charArray[i] = c;
            }
            Console.WriteLine("Result");
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(charArray[i] + " ");
            }
        }
    }
};