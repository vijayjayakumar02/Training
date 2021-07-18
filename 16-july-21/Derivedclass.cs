using System;

namespace _16_july_21
{
    class derivedclass : baseclass
    {
        public new void WriteNum()
        {
            Console.WriteLine("derived class string");
        }

        public override void Writestr()//overriding the base class method
        {
            base.Writestr();
        }
    }
}