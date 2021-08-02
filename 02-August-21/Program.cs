using System;

namespace _02_August_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist linkedlist = new Linkedlist();
            linkedlist.Add(1);
            linkedlist.Add(2);
            linkedlist.Add(3);
            linkedlist.Add(4);
            linkedlist.Add(5);
            linkedlist.Add(6);
            linkedlist.delete(6);
            linkedlist.display();
        }
    }
}
