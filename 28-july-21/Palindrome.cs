using System;

namespace _28_july_21
{
    class Palindrome
    {
        public void palindromeCheck()
        {
            System.Console.WriteLine("Enter the word :");
            string word = Console.ReadLine().ToLower();
            char[] pal_check = word.ToCharArray();
            bool flag = false;
            for (int i = 0, j = word.Length - 1; i < pal_check.Length; i++, j--)
            {
                if (pal_check[i] == word[j])
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