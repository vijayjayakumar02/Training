using System;
using System.Collections.Generic;
using System.Linq;

namespace Insurance
{
    class getDetails
    {
        public void getDetail()
        {
            var listCustomer = AddCustomers();
            var listInsurance = AddInsurance();
            List<MedicalInsurance> medicalInsurances = new List<MedicalInsurance>
            {
                new MedicalInsurance {Name = "vijay", premiumAmount = 100000.00, ListOfAppointmentCompleted = 3},
                new MedicalInsurance {Name = "HariHaran", premiumAmount = 150000.00, ListOfAppointmentCompleted = 1},
                new MedicalInsurance {Name = "saravana", premiumAmount = 20000.00, ListOfAppointmentCompleted = 2},
                new MedicalInsurance {Name = "yukesh", premiumAmount = 185000.00, ListOfAppointmentCompleted = 1}
            };
            List<LifeInsurance> lifeInsurances = new List<LifeInsurance>{
                new LifeInsurance{Name = "vijay", premiumAmount = 150000.00, Nominee = "melvin", MaturityDate = new DateTime(2007,07,11)},
                new LifeInsurance{Name = "HariHaran", premiumAmount = 185000.00, Nominee = "Thaseen", MaturityDate = new DateTime(2008,06,16)},
                new LifeInsurance{Name = "saravana", premiumAmount = 198000.00, Nominee = "vasundhara", MaturityDate = new DateTime(2011,08,25)},
                new LifeInsurance{Name = "yukesh", premiumAmount = 250000.00, Nominee = "vidhya", MaturityDate = new DateTime(2012,12,12)},
            };
            var customerId = listCustomer.Join(listInsurance, c => c.CustomerId, i => i.CustomerId, (c, i) =>
            new
            {
                CustomerName = c.Name,
                BloodGroup = c.BloodGroup,
                MedicalInsuranceStatus = i.MedicalInsurance,
                age = c.Age
            }).Where(bloodgroup => bloodgroup.BloodGroup == "O+ve").Where(A => A.age <= 60);
            var finalist = customerId.Join(medicalInsurances, cid => cid.CustomerName, m => m.Name, (cid, m) =>
            new
            {
                medicalInsurance = cid.MedicalInsuranceStatus,
                AppointCompleted = m.ListOfAppointmentCompleted,
                cidName = cid.CustomerName,
            }).Where(check => check.medicalInsurance == true && check.AppointCompleted < 3);

            foreach (var item in finalist)
            {
                System.Console.WriteLine(item.cidName + " is eligible");
            }
            List<string> customerNameMedicalInsurance = new List<string>();
            foreach (string name in customerNameMedicalInsurance)
            {
                System.Console.WriteLine(name + " ");
            }
        }
        public static List<Customer> AddCustomers()
        {
            List<Customer> customerList = new List<Customer>
                {
                new Customer { Name="vijay", CustomerId="I7GH012", Age = 21, BloodGroup = "O+ve"},
                new Customer { Name="HariHaran", CustomerId="I7GH013", Age = 20, BloodGroup = "A+ve"},
                new Customer { Name="saravana", CustomerId="I7GH014", Age = 23, BloodGroup = "B+ve"},
                new Customer { Name="yukesh", CustomerId="I7GH015", Age = 25, BloodGroup = "O+ve"}
                };
            return customerList;
        }
        public static List<InsuranceDetails> AddInsurance()
        {
            List<InsuranceDetails> insuranceDetailsList = new List<InsuranceDetails>{
                new InsuranceDetails{InsuranceId = "GH0123654FG", Age= 21, validity=2, CustomerId="I7GH012", MedicalInsurance=false, LifeInsurance=true},
                new InsuranceDetails{InsuranceId = "GH0145658FB", Age= 20, validity=2, CustomerId="I7GH013", MedicalInsurance=true, LifeInsurance=true},
                new InsuranceDetails{InsuranceId = "GH0253662MN", Age= 23, validity=2, CustomerId="I7GH014", MedicalInsurance=true, LifeInsurance=false},
                new InsuranceDetails{InsuranceId = "GH0987487KL", Age= 25, validity=2, CustomerId="I7GH015", MedicalInsurance=true , LifeInsurance=false}
            };
            return insuranceDetailsList;
        }
    }
}