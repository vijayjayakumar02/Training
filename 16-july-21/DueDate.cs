using System;

namespace _16_july_21
{
    static class dueDate
    {
        public static double GetDueDays(this Insurance IObj)
        {
            DateTime dueDate = IObj.payPremium();//Extended method to find the days left
            double daysLeft = (dueDate - DateTime.Now).TotalDays;
            return daysLeft;
        }
    }
}