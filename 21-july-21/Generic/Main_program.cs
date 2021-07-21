using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int, string> genericlist = new GenericList<int, string>();
            genericlist.Add(10, "vijay");
            genericlist.Add(20, "saravana");
            genericlist.Add(15, "Hari");
            genericlist.Remove(20);
            genericlist.sort();
            genericlist.print();
            GenericList<string, int> genericlist1 = new GenericList<string, int>();
            genericlist1.Add("vijay", 10);
            genericlist1.Add("Hari", 25);
            genericlist1.Add("Saravana", 30);
            genericlist.Remove(25);
            genericlist1.sort();
            genericlist1.print();
        }
    }
}
