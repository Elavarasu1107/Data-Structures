using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class StacksAndQueues
    {
        private Node top;
        private Node head = null;
        public StacksAndQueues()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to Stacks", value);
        }
        public void DisplayStacks()
        {
            Node temp = this.top;
            if (this.top == null)
            {
                Console.WriteLine("Stacks is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peak()
        {
            Console.WriteLine();
            if (this.top == null)
            {
                Console.WriteLine("The Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is in top of the Stacks", this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("The Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is popped from Stacks", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peak();
                Pop();
            }
        }
        public void EnQueue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        public void DisplayQueues()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void DeQueue()
        {
            Console.WriteLine();
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while (this.head != null)
            {
                Console.WriteLine("{0} is removed from Queue", head.data);
                head = head.next;
            }
        }
    }
}
