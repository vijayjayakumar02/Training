//2. A program should have a class of Employees with property Id and Name .  
//Make use of indexers to create a collection semantics.  
//Make use  of HashTable  to store the list of items in a key value pairs.

using System;
using System.Collections;
using System.Collections.Generic;

namespace day7
{
    class Employee_table
    {
        //ID props
        public int ID { get; set; }
        //name props
        public string Name { get; set; }

        //assigning to both props
        public Employee_table(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}