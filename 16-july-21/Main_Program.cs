using System;

namespace _16_july_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a Base Class with a method with the name WriteNum and display an integer.  
            //Create another virtual method WriteStr and display some string.
            //Create a Derived class and create a hidden method by name WriteNum and override the method WriteStr. 
            //Create Objects -
            //-objectA  of type base class 
            //- objectB of type  base class but downcasted to the derived class 
            //- objectC of type derived class 
            //Display the methods from all 3 objects


            baseclass objA = new baseclass();//base class object
            objA.WriteNum();
            objA.Writestr();
            baseclass objB = new derivedclass(); // base class downcasted to derived class
            derivedclass derivedObj = objB as derivedclass;
            derivedObj.WriteNum();
            derivedObj.Writestr();
            derivedclass objc = new derivedclass();//derived class object
            objc.WriteNum();
            objc.Writestr();


            //2.Create a base class SalaryAccount , when creating the account you must pass the fields 
            //like account Id, Name , Balance
            //Create a derived class DematAccount, when creating a demat account you must and should pass the Pan Card number. 
            //Try using the Regular expressions which you learnt in self learning to validate the pan card number  format. 
            //User should be able to create 
            //- SalaryAccount alone
            //-  Salary Account along with the DematAccount

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
                    DematAcc dematAcc = new DematAcc(account_number, name, balance, panCardNum);
                    dematAcc.getSalaryWithDemat();
                    break;
                default:
                    Console.WriteLine("Sorry its an Invalid input");
                    break;
            }

            //3. Extension methodCreate a class called Insurance, Add some methods like Pay premium.  
            //Have few properties like name, email,  Premium Due Date,  aadhar card number.  
            //Before creating an object, validate all inputs using the c# regular expressions.
            //Create an extension method called GetDueDays which accepts the Insurance object  and 
            //returns the number of days pending to pay premium or number of days exceeded.

            Validate validate = new Validate();
            validate.validation();
            validate.print_validation();

            Insurance insurance = new Insurance();
            insurance.payPremium();


        }
    }
}
