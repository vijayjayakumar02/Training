using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {

            //programming question 1
            program_1 prog_1 = new program_1();
            prog_1.print();

            //programming question 2
            program1 prog = new program1();
            prog.Add(2, 3.5);
            prog.div(2, 3);
            prog.mul(2.5f, 2.5f);

            //programming question 3
            program2 prog1 = new program2();
            prog1.sal_details();

            //programming  question 4
            program3 prog2 = new program3();
            prog2.getLetter();

            //programmin question 5
            program4 prog3 = new program4();
            prog3.calci();

            //programming question 6
            program5 prog6 = new program5();
            prog6.compare();
        }
    }
}
