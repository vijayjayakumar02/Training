using System;

namespace _15_july_21
{
    class Access_specifiers
    {
        public string new_username;//accessed in all classes
        private string username;//accessed only in same class

        protected string Login//Can be accessed in derived classes
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string sign_up//accessed in all classes
        {
            get
            {
                return new_username;
            }
            set
            {
                new_username = value;
            }
        }
        internal static void userDetails()//Accessed by Same assembly
        {
            System.Console.WriteLine("User details");
        }
        public void print()
        {
            Console.WriteLine("new user:" + this.new_username);
            Console.WriteLine("old user:" + this.username);
        }
    }
}