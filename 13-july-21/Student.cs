// 3.  Write a program which has a class of Student with Id, Name and Date of Birth. 
//You can set the Date of birth at the time of Admission (object creation),  
//and have a property which calculates the age.  (use property  get accessors ) and 
//can be accessed from the client / main program. Also ensure user can not enter 
//the Dob or Age at a later point of time in the program
// Hint - Make use of Date time , time span we learnt on Day 5.  

using System;

namespace day7
{
    class Student
    {
        public int YYYY, MM, DD;
        public int Id;
        public string Name;
        public DateTime BirthDate { get; set; }//birthdate props

        public void giveDetails()
        {
            //getting inputs
            Console.WriteLine("Enter the Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter DOB:");
            this.YYYY = Convert.ToInt32(Console.ReadLine());
            this.MM = Convert.ToInt32(Console.ReadLine());
            this.DD = Convert.ToInt32(Console.ReadLine());
        }
        //printing the details that is given as input
        public void Get_details()
        {
            Console.WriteLine("Name:{0}\nId:{1}\nDOB:{2}\nAGE:{3} yrs old", Name, Id, getDob(new DateTime(YYYY, MM, DD)), get_age());
        }

        //assigns to birthdate props
        public string getDob(DateTime birthdate)
        {
            BirthDate = birthdate;
            return (string)BirthDate.ToShortDateString();
        }

        //age calculator
        public int get_age()
        {
            int year = DateTime.Now.Year;
            int age = year - YYYY;
            return age;
        }
    }
}