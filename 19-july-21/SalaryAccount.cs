using System;
using System.Threading;

namespace _19_july_21
{
    class Salaryacc : Ibenefits
    {
        private string Accountnum;
        private string Name;
        private double Balance;

        //constructor to get and store the salary account details.
        public Salaryacc(string Accountnum, string Name, double Balance)
        {
            this.Accountnum = Accountnum;
            this.Name = Name;
            this.Balance = Balance;
        }

        public void getSalary()//checking the length of the account number
        {
            if (Accountnum.Length < 16)
            {
                Console.WriteLine("Your account number is invalid");
            }
            else
            {
                Console.WriteLine($"your salary account detail...\nAcc No: {Accountnum}\nName:{Name}\nBalance:{Balance}");
            }
        }
        public void AvailFreeLocker()
        {
            System.Console.WriteLine("checking for free locker...");
            Thread.Sleep(2000);
            System.Console.WriteLine("sorry no free locker is available");
        }
        public void AvailFreeDemandDraft()
        {
            System.Console.WriteLine("checking for free DemandDraft...");
            Thread.Sleep(2000);
            System.Console.WriteLine("sorry no free DemandDraft is available.");
        }
    }
}
