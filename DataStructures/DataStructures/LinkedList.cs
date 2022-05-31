using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedList
    {
        public Node head;
        public void Add1(int data)
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
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }
        public void Add2(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
               node.next = this.head;
                head = node;
            }
            Console.WriteLine("{0} inserted into LinkedList", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public Node Insert(int position, int data)
        {
            if(position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if(position == 1)
            {
                Node node = new Node(data);
                node.next = this.head;
                head = node;
            }
            else
            {
                while(position != 0)
                {
                    position--;
                    if(position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if(position != 1)
                {
                    Console.WriteLine("Position is out of Range");
                }
            }
           return head;
        }
        public Node DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return null;
            }
            head = head.next;
            return head;
        }
        public Node DeleteLast()
        {
            Node node = head;
            if(head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return null;
            }
            if(head.next == null)
            {
                this.head = null;
            }
            while(node.next.next != null)
            {
                node = node.next;
            }
            node.next = null;
            return head;
        }
    }
}
