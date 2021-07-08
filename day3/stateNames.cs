using System;

namespace day3
{
    class stateNames
    {
        public string countryName()
        {
            //getting country and statename from the user
            string countryName = Console.ReadLine();
            string stateName = Console.ReadLine();
            //comparing the country name
            if (countryName == "INDIA" || countryName == "india")
            {
                //it returns true if the statename is kerala else false using ternary operator
                string condition = stateName == "kerala" ? "true" : "false";
                return condition;
            }
            return "you're statename is not matched";
        }
    }
}