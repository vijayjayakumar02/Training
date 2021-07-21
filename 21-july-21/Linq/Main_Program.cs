using System;
using System.Collections.Generic;
using System.Linq;

namespace _21_july_21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankBranches> bankbranchesList = new List<BankBranches>{
                new BankBranches { Name = "Indian Bank", Location = "Chennai", IFSCCode = "IN0001" },
                new BankBranches { Name = "ICICI", Location = "Banglore", IFSCCode = "IN0056" },
                new BankBranches { Name = "Axis Bank", Location = "Hyderabad", IFSCCode = "IN0065" },
                new BankBranches { Name = "KVB", Location = "Cochin", IFSCCode = "IN0095" }
            };

            List<BankManagers> bankmanagersList = new List<BankManagers>{
                new BankManagers { ManagerName = "Charan", BankName = "Indian Bank", Age = 32, maxpoint = 100 },
                new BankManagers { ManagerName = "Yukesh", BankName = "ICICI", Age = 31, maxpoint = 120 },
                new BankManagers { ManagerName = "Saravanan", BankName = "Axis Bank", Age = 29, maxpoint = 110 },
                new BankManagers { ManagerName = "SriVidhya", BankName = "KVB", Age = 27, maxpoint = 105 }
            };

            var result = bankbranchesList.Join(bankmanagersList, s => s.Name, c => c.BankName, (s, c) =>
                 new
                 {
                     BankName = s.Name,
                     ManagerName = c.ManagerName
                 });

            foreach (var item in result)
            {
                Console.WriteLine($"BankName:{item.BankName}\nManagerName:{item.ManagerName}");
                Console.WriteLine();
            }
            var max_point = bankmanagersList.Max(x => x.maxpoint);
            var bankmanagerslambda1 = bankmanagersList.FindAll(x => x.maxpoint == max_point);

            foreach (var maxpoint in bankmanagerslambda1)
            {
                var id = maxpoint.BankName;
                Console.WriteLine("The bank manager who has maximum point:" + maxpoint.ManagerName);
            }
            Console.WriteLine();
            var bankmanagerslambda = bankmanagersList.FindAll(x => x.Age > 30);
            
            foreach (var age in bankmanagerslambda)
            {
                Console.WriteLine("The managers name whose age is about 30: " + age.ManagerName);
            }
            
        }
    }
}
