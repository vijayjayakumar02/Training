using System;
using System.Text.RegularExpressions;

namespace _16_july_21
{
    class Insurance
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime PremiumDueDate { get; set; }
        public string AadharNum { get; set; }

        public DateTime payPremium()//setting the days to pay for premium
        {
            PremiumDueDate = DateTime.Today.AddDays(15);
            return PremiumDueDate;
        }
    }

    //validation class
    class Validate : Insurance
    {
        public string valid_name;
        public string valid_email;
        public string valid_aadharNum;
        public void validation()
        {
            //Name validation using regular expression
            Console.WriteLine("Enter the Name:");
            Name = Console.ReadLine();
            Regex regName = new Regex(@"^[A-Za-z]\w{3,20}$");
            this.valid_name = regName.IsMatch(Name) ? "valid name" : "not a valid name";

            //Email validation using regular expression
            Console.WriteLine("Enter the Email ID:");
            Email = Console.ReadLine();
            Regex regEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            this.valid_email = regEmail.IsMatch(Email) ? "valid mail" : "not a valid Email";

            //Aadhar number validation using regular expression
            Console.WriteLine("Enter Your Aadhar number:");
            AadharNum = Console.ReadLine();
            Regex regAadharNUm = new Regex(@"^[2-9]{1}[0-9]{3}\\s[0-9]{4}\\s[0-9]{4}$");
            this.valid_aadharNum = regAadharNUm.IsMatch(AadharNum) ? "a valid number" : "not a valid num";
        }
        public void print_validation()//printing the details
        {
            Insurance insurance = new Insurance();
            int _date = Convert.ToInt32(insurance.GetDueDays());
            Console.WriteLine($"Name: {Name} is a {valid_name}\nEmail: {Email} is a {valid_email}\nyour Aadhar number: {AadharNum} is {valid_aadharNum}\nDue Date for premium: {_date} days left...");
        }
    }
}