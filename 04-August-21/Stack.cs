using System;

namespace _04_August_21
{
    //stack using linked list
    public class Stack
    {
        //creating Node class for reference
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)//passing data 
            {
                this.data = data;
                this.next = null;
            }
        }
        public Node top;
        public int size;

        public void push(int data)
        {
            Node tempNode = new Node(data);//Instantiating Node class to give a ref
            tempNode.next = top;
            top = tempNode;
            size++;//incrementing the size of the stack
        }
        public int Length()//Returning the length of the stack
        {
            return size;
        }
        public bool isEmpty()
        {
            return size == 0;
        }
        public void pop()//removes the element from the stack
        {
            if (isEmpty())
            {
                System.Console.WriteLine("stack is empty");
            }
            int result = top.data;
            top = top.next;//skips the current node
            size--;//decrementing the size of the stack
        }
        public int peek()
        {
            if (isEmpty())
            {
                System.Console.WriteLine("stack is empty");
            }
            return top.data;
        }
        public void display()//display all the data in the stack as FILO(First In Last Out)
        {
            Node cur = top;
            while (cur != null)
            {
                System.Console.Write(cur.data + " ");
                cur = cur.next;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Length of the stack is : " + Length());
        }
    }
}