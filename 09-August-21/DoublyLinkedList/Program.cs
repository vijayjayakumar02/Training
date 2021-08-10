using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL linkedList = new DLL();
            System.Console.WriteLine("Doubly Linked List elements:");
            linkedList.push(5);
            linkedList.push(20);
            linkedList.push(25);
            linkedList.Display(linkedList.head);

            System.Console.WriteLine();
            System.Console.WriteLine("Queue using Linkedlist:");

            Queue queue = new Queue();
            queue.enqueue(10);
            queue.enqueue(20);
            queue.display();
        }
    }
}
