using System;

namespace _02_August_21
{
    public class Linkedlist
    {
        //Head and tail of the list
        public Node head = null;
        public Node tail = null;

        //Adds new Node to the list
        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        //Deletes the list by comparing with data.
        public void delete(int data)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null) return;

            prev.next = temp.next;
        }

        //Displaying all the nodes in the list
        public void display()
        {
            Node current = head;
            if (head == null)
            {
                System.Console.WriteLine("List is empty");
            }
            while (current != null)
            {
                System.Console.Write(current.data + " ");
                current = current.next;
            }
            Console.ReadKey();
        }
    }
}