using System;

namespace DoublyLinkedList
{
    public class Node
    {
        public int data;
        public Node previous;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
}