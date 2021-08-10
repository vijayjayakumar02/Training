using System;

namespace DoublyLinkedList
{
    public class DLL
    {
        public Node head;
        public void push(int data)
        {
            Node node = new Node(data);
            node.next = head;
            node.previous = null;
            if (head != null)
            {
                head.previous = node;
            }
            head = node;
        }
        public void InsertAfter(Node previous_node, int data)
        {
            if (previous_node == null)
            {
                System.Console.WriteLine("previous node can't be null");
            }
            Node node = new Node(data);
            node.next = previous_node.next;
            previous_node.next = node;
            node.previous = node;

            if (node.next != null)
            {
                node.next.previous = node;
            }
        }
        public void append(int data)
        {
            Node node = new Node(data);
            Node last = head;
            node.next = null;

            if (head == null)
            {
                node.previous = null;
                head = node;
            }
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = node;
            node.previous = last;
        }
        public void Display(Node node)
        {
            while (node != null)
            {
                System.Console.Write(node.data + " ");
                node = node.next;
            }
        }
    }
}