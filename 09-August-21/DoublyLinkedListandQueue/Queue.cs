using System;

namespace DoublyLinkedList
{
    public class Queue
    {
        Node front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }
        public void enqueue(int data)
        {
            Node node = new Node(data);
            if (this.rear == null)
            {
                this.front = this.rear = node;
            }
            this.rear.next = node;
            this.rear = node;
        }
        public void dequeue()
        {
            if (this.front == null)
            {
                return;
            }
            Node node = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }
        }
        public void display()
        {
            Node cur = this.front;
            while (cur != null)
            {
                System.Console.Write(cur.data + " ");
                cur = cur.next;
            }
        }
    }
}