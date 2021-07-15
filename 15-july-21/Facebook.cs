using System;

namespace _15_july_21
{
    class facebook : Access_specifiers
    {
        public void get_userName()
        {
            Console.WriteLine("enter username:");
            Login = Console.ReadLine();
        }
        public void get_newUserName()
        {
            Console.WriteLine("enter new username");
            sign_up = Console.ReadLine();
        }
    }
}