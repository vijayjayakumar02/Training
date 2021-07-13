using System;
using System.Collections;

namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            //programming question 1
            Employee emp = new Employee();
            emp.enterDetails();
            emp.getDetails();
            emp.GetSalary();
            emp.promote(true);

            //programming question 2
            Hashtable table = new Hashtable();

            //creating object with ID as key and name as value
            Employee_table emp1 = new Employee_table(1, "vijay");
            Employee_table emp2 = new Employee_table(2, "ajay");
            Employee_table emp3 = new Employee_table(3, "vinay");

            //Adding to the tables
            table.Add(emp1.ID, emp1);
            table.Add(emp2.ID, emp2);
            table.Add(emp3.ID, emp3);

            // ICollection keys = table.Keys;

            // Employee_table emp = (Employee_table)table[keys];

            //getting keys and values from the table
            foreach (Employee_table element in table.Values)
            {
                Console.WriteLine("ID:{0}", element.ID);
                Console.WriteLine("NAME:{0}", element.Name);
            }

            //programming question 3
            Student stud = new Student();
            stud.giveDetails();
            stud.Get_details();
        }
    }
}
