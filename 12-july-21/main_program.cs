using System;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            //programming question 2
            Graph coordinates1 = new Graph(1, 2, 3);
            coordinates1.printGraph();
            coordinates1.move(4, 5, 6);
            coordinates1.printGraph();
            Graph coordinates2 = new Graph(7, 8, 9);
            coordinates1.move(coordinates2);
            coordinates1.printGraph();

            //programming question 1
            Calculator calculate = new Calculator();
            calculate.getInput();

            //programming question 2
            Dms dms = new Dms();
            dms.get_input();
        }
    }
}
