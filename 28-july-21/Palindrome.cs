using System;

namespace _28_july_21
{
    class Palindrome
    {
        public void palindromeCheck()
        {
            System.Console.WriteLine("Enter the word :");
            string word = Console.ReadLine().ToLower();
            bool flag = false;
            for (int i = 0, j = word.Length - 1; i < word.Length; i++, j--)
            {
                if (word[i] == word[j])
                {
                    flag = true;
                }
                else
                    flag = false;
            }
            System.Console.WriteLine(flag);
        }
    }
}