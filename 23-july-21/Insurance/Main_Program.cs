using System;
using System.Collections.Generic;
using System.Linq;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //getting detail from getdetails class
            getDetails getdetails = new getDetails();
            getdetails.getDetail();
        }
    }
}
