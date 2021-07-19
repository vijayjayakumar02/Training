using Domains;
using System;
using System.Text;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "This is my sample text occurance";
            StringBuilder txt = new StringBuilder(text);
            Class1 class1 = new Class1();
            try
            {
                string findText = class1.Readtext(txt);
                Console.WriteLine(findText);
            }
            catch(Exception e)//catching the exception from class1.cs
            {
                Console.WriteLine(e);
            }
        }
    }
}
