//3. I have a large text, but have to display only 20 characters of the text and display but ensure you won't break the word appearing in the end. So It can go a little beyond 20 characters ensuring we won't break the word. 
// example:  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard
// Output :   Lorem Ipsum is simply dummy

using System;

namespace day5
{
    class Display
    {
        public void get_string()
        {
            //getting the sentence
            string sentence = Console.ReadLine();
            int get_len = Convert.ToInt32(Console.ReadLine());

            //printing the words before space
            if (sentence[get_len] == ' ')
            {
                get_len--;
                Console.WriteLine(sentence.Substring(0, get_len + 1));
            }
            else
            {
                Console.WriteLine(sentence.Substring(0, get_len));
            }
        }
    }
}
