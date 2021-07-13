using System;

namespace day7
{
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public string Designation;
        private int salary;

        //getting the input from the user
        public void enterDetails()
        {
            Console.WriteLine("Enter Id:");
            this.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            this.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Desingnation:");
            this.Designation = Console.ReadLine();
            Console.WriteLine("Enter Salary:");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        //getting all the details entered by the user
        public void getDetails()
        {
            Console.WriteLine($"Name: {EmployeeName}\nId: {EmployeeId}\nDesignation: {Designation}");
        }

        //salary props to assign and get the salary details
        public int Salary
        {
            get => salary;
            set => salary = value;
        }

        //Getting the salary that is assigned by the user(current salary)
        public void GetSalary()
        {
            Console.WriteLine("salary: " + salary);
        }

        //checking for promotion if it is true then there will be an increament in salary
        public void promote(bool condition)
        {
            if (condition == true)
            {
                Console.WriteLine("New Salary : " + IncreasePay());
            }
        }

        // Increament method(10% increase in salary)
        public int IncreasePay()
        {
            int new_salary = salary + salary / 10;
            return new_salary;
        }
    }
}