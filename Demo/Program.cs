using System;
using System.Collections.Generic;
using System.Timers;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Indexer indexer = new Indexer();
            indexer[0] = "vijay";
            indexer[1] = "naveen";
            indexer[2] = "Hari";
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine(indexer[i]);
            }
        }
    }
    class Indexer
    {
        private string[] names = new string[10];
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }


    }
}
