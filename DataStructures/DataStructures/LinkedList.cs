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
                Node position = head;
                while (position.next != null)
                {
                    position = position.next;
                }
                position.next = node;
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
            Node position = this.head;
            if(position == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while(position != null)
            {
                Console.Write(position.data+" ");
                position = position.next;
            }
        }
    }
}
