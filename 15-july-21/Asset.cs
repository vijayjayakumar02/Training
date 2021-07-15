using System;

namespace _15_july_21
{
    public abstract class Asset
    {

        public abstract void configuration();

        public void warranty()
        {
            System.Console.WriteLine("warranty available");
        }
    }
    class Computer : Asset
    {
        public override void configuration()
        {
            System.Console.WriteLine("computer configuration");
        }
    }
    public class Laptop : Asset
    {
        override public void configuration()
        {
            System.Console.WriteLine("Laptop configuration");
        }
    }
    public class Headphone : Asset
    {
        override public void configuration()
        {
            System.Console.WriteLine("Headphone configuration");
        }
    }
    public class Dockstation : Asset
    {
        override public void configuration()
        {
            System.Console.WriteLine("Dockstation configuration");
        }
    }

}