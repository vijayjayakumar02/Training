using System;

namespace day5
{
    class day5
    {
        public static void Main(string[] args)
        {
            //programming question 1
            Program get_input = new Program();
            get_input.get_input();

            //programming question 2
            unique_elements unique = new unique_elements();
            unique.getElements();
            unique.print();

            //programming question 4
            time_input get_time = new time_input();
            get_time.checkTimeInput();

            //programming question 3
            Display disp = new Display();
            disp.get_string();
        }
    }
}