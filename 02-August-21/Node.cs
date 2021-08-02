using System;

namespace _02_August_21
{
    //Nodes of linked list consit of data and address
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}