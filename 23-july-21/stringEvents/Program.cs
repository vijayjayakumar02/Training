using System;
using System.Collections.Generic;
using System.Linq;

namespace stringEvents
{
    public delegate void StringDelegate(List<string> sentences);
    class Program
    {
        public static event StringDelegate StringEvent;
        static void Main(string[] args)
        {
            StringEvent += Program.RemoveWhiteSpaces;
            StringEvent += Program.StringConcatenation;
            StringEvent += Program.StringReverse;
            StringEvent += Program.CharacterOccurrence;
            Program.onEvent();
        }
        //using Events
        public static void onEvent()
        {
            List<string> sentence = new List<string>();
            sentence.Add("Remember_that failure is an event, not a_person.");
            sentence.Add("All journeys have secret_destinations of which the traveler is_unaware.");
            sentence.Add("How_we spend our days is, of_course, how_we spend our lives.");
            Program.StringEvent?.Invoke(sentence);
        }

        //Removing white spaces from the string
        static void RemoveWhiteSpaces(List<string> sentence)
        {
            Console.WriteLine("Removing white spaces from the string.....");
            string[] stringArray = sentence.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < stringArray.Length; i++)
            {
                string trim = stringArray[i].Replace("_", " ");
                System.Console.WriteLine(trim);
            }
            System.Console.WriteLine();
        }

        //Reversing all the string in the list
        static void StringReverse(List<string> sentence)
        {
            Console.WriteLine("Reversing all the string in the list");
            for (int i = 0; i < sentence.Count; i++)
            {
                char[] chars = sentence[i].ToCharArray();
                char[] result = new char[chars.Length];
                for (int j = 0, k = sentence[i].Length - 1; j < sentence[i].Length; j++, k--)
                {
                    result[j] = chars[k];
                }
                for (int l = 0; l < result.Length; l++)
                {
                    System.Console.Write(result[l]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        //Concatinating all the strings.....
        static void StringConcatenation(List<string> sentences)
        {
            System.Console.WriteLine("Concatinating all the strings.....");
            string concat = "";
            string[] stringArray = sentences.Select(x => x.ToString()).ToArray();
            for (int j = 0; j < stringArray.Length; j++)
            {
                concat += stringArray[j];
            }
            System.Console.WriteLine(concat);
            System.Console.WriteLine();
        }

        //Character 'a' in first sentence in list
        static void CharacterOccurrence(List<string> sentences)
        {
            System.Console.WriteLine("Getting the count of occurrence of character 'a' of the 1st sentence.....");
            string input = sentences[0];
            int Count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                    Count++;
            }
            Console.Write("The occurrence of character 'a' in first string of list: " + Count);
            System.Console.WriteLine();
        }

    }
}
