//1. .Write a program which asks the user to enter multiple names until you press the enter button  (a blank name). Store them in a List.
//  If the number of names are more than 2 then display a formatted string like name[0] , name[1] and others < name.count-2>  people  like your post! ,
//  If the number of names are two then display like name[0] and name[1] likes your post! , if there is only one name display name[0] likes your post  else  display blank line.

using System;
using System.Collections;

namespace day5
{
    class Program
    {
        //Getting the names until the user prints enter
        public void get_input()
        {
            ArrayList names = new ArrayList();
            Console.WriteLine("Enter names or click Enter to exit:");
            do
            {
                names.Add(Console.ReadLine());
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

            //Printing when number of names are more than two.
            if (names.Count > 2)
            {
                Console.WriteLine(string.Format("{0}, {1} and {2} others liked your post.", names[0], names[1], names.Count - 2));
            }

            //Printing when number of number are exactly two.
            else if (names.Count == 2)
            {
                Console.WriteLine(string.Format("{0} and {1}liked your post.", names[0], names[1]));
            }

            //printing when there is only one element.
            else if (names.Count == 1)
            {
                Console.WriteLine(string.Format("{0} liked your post.", names[0]));
            }
        }
    }
}
