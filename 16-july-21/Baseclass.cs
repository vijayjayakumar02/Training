using System;

namespace _16_july_21
{
    class baseclass
    {
        public void WriteNum()
        {
            System.Console.WriteLine("base class integer: " + 10);
        }
        public virtual void Writestr()
        {
            System.Console.WriteLine("base class string");
        }
    }
}