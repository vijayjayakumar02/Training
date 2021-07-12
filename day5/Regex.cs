using System;
using System.Text.RegularExpressions;

namespace day5
{
    class regex
    {
        public void reg_exp()
        {
            string pass = Console.ReadLine();
            Console.WriteLine(CheckPassword(pass));
        }
        public bool CheckPassword(string password)
        {
            //matching the pattern
            string MatchEmailPattern = "^[a-zA-Z0-9]+$";

            if (password != null)
                return Regex.IsMatch(password, MatchEmailPattern);
            else return false;


        }
    }
}