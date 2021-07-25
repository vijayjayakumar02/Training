using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_july_21
{
    class Program
    {
        public delegate void StringDelegate(List<string> Names);
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            StringDelegate StringDel = new StringDelegate(RemoveWhiteSpaces);
            StringDel += StringReverse;
            StringDel += StringConcatenation;
            StringDel += CharacterOccurrence;
            names.Add("vijay_jayakumar");
            names.Add("arun");
            names.Add("melvin");
            StringDel(names);
        }

        //Removing white spaces from the string
        static void RemoveWhiteSpaces(List<string> Names)
        {
            Console.WriteLine("Removing white spaces from the string.....");
            string[] stringArray = Names.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < stringArray.Length; i++)
            {
                string trim = stringArray[i].Replace("_", " ");
                System.Console.WriteLine(trim);
            }
        }

        //Reversing all the string in the list
        static void StringReverse(List<string> Names)
        {
            Console.WriteLine("Reversing all the string in the list");
            for (int i = 0; i < Names.Count; i++)
            {
                char[] chars = Names[i].ToCharArray();
                char[] result = new char[chars.Length];
                for (int j = 0, k = Names[i].Length - 1; j < Names[i].Length; j++, k--)
                {
                    result[j] = chars[k];
                }
                for (int l = 0; l < result.Length; l++)
                {
                    System.Console.Write(result[l]);
                }
                System.Console.WriteLine();
            }

        }

        //Concatinating all the strings.....
        static void StringConcatenation(List<string> Names)
        {
            System.Console.WriteLine("Concatinating all the strings.....");
            string concat = "";
            string[] stringArray = Names.Select(x => x.ToString()).ToArray();
            for (int j = 0; j < stringArray.Length; j++)
            {
                concat += stringArray[j];
            }
            System.Console.WriteLine(concat);
        }

        //Character 'a' in first string in list
        static void CharacterOccurrence(List<string> Names)
        {
            System.Console.WriteLine("Getting the count of occurrence of character 'a' of the 1st string.....");
            string input = Names[0];
            int Count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                    Count++;
            }
            Console.Write("The occurrence of character 'a' in first string of list: " + Count);
        }

    }
}