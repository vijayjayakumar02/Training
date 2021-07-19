using System;

namespace _19_july_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("your type:\n1.Salary Account Alone\n2.Salary Account with Demat Account");
            int usertype = Convert.ToInt32(Console.ReadLine());
            string account_number;
            string name;
            double balance;
            switch (usertype)
            {
                case 1:
                    Console.WriteLine("Enter Acc No: ");
                    account_number = Console.ReadLine();
                    Console.WriteLine("Your Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Your balance:");
                    balance = Convert.ToDouble(Console.ReadLine());
                    Salaryacc salaryacc = new Salaryacc(account_number, name, balance);
                    salaryacc.getSalary();
                    salaryacc.AvailFreeLocker();
                    salaryacc.AvailFreeDemandDraft();
                    break;
                case 2:
                    Console.WriteLine("Enter Acc No: ");
                    account_number = Console.ReadLine();
                    Console.WriteLine("Your Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Your balance:");
                    balance = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Your PAN ID:");
                    string panCardNum = Console.ReadLine();
                    DematAccount dematAccount = new DematAccount(account_number, name, balance, panCardNum);
                    dematAccount.getSalaryWithDemat();
                    dematAccount.AvailFreeLocker();
                    dematAccount.AvailFreeDemandDraft();
                    dematAccount.AvailFreeCreditScoreCheck();
                    dematAccount.GetDailyStockUpdates();
                    break;
                default:
                    Console.WriteLine("Sorry its an Invalid input");
                    break;
            }
        }
    }
}