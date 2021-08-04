using System;

namespace _04_August_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.pop();
            stack.peek();
            stack.display();
        }
    }
}
