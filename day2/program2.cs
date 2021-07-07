using System;

namespace day2
{
    class program1
    {
        //for addition
        public void Add(int x, double y)
        {
            int sum = (int)(x + y);
            Console.WriteLine($"sum of {x} and {y} is : {sum}");
        }
        //for division
        public void div(int x, double y)
        {
            double div = (x / y);
            Console.WriteLine("div of " + x + " " + "and" + " " + y + "is :" + div);
        }
        //multiplication
        public void mul(float x, float y)
        {
            float mul = (x * y);
            Console.WriteLine("mul of {0} and {1} is : {2}", x, y, mul);
        }
    }
}
