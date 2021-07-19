using System;
using System.Text;

namespace Domains
{
    public class Class1:Exception
    {
        public string Readtext(StringBuilder text)
        {
            
            bool Findtext = text.ToString().Contains("Sample text");
            if (Findtext == true)
            {
                return "Sub Text Found";
            }
            else
            {
                throw new CustomException("Sub text not found");//throwing exception
            }
        }
    }
}
