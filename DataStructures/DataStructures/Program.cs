using System;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Creating simple LinkedList \n 2 for Adding value in LinkedList\n 3 for Appending a value in LinkedList\n 4 for Inserting Value in LinkedList\n" +
                " 5 for Deleting First Element\n 6 for Deleting Last Element\n 7 for creating Stacks\n 8 for Peak and Pop\n 9 for EnQueue");
            Console.WriteLine("Enter a Number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            LinkedList list = new LinkedList();
            StacksAndQueues stacks = new StacksAndQueues();
            switch (userInput)
            {
                case 1:
                    {
                        list.Add1(56);
                        list.Add1(30);
                        list.Add1(70);
                        list.Display();
                        break;
                    }
                case 2:
                    {
                        list.Add2(70);
                        list.Add2(30);
                        list.Add2(56);
                        list.Display();
                        break;
                    }
                case 3:
                    {
                        list.Add1(56);
                        list.Add1(30);
                        list.Add1(70);
                        list.Display();
                        break;
                    }
                case 4:
                    {
                        list.Add1(56);
                        list.Add1(70);
                        list.Display();
                        list.Insert(2, 30);
                        Console.WriteLine("Ater inserting data:");
                        list.Display();
                        break;
                    }
                case 5:
                    {
                        list.Add1(56);
                        list.Add1(30);
                        list.Add1(70);
                        list.Display();
                        list.DeleteFirst();
                        Console.WriteLine("Ater Deleting First element:");
                        list.Display();
                        break;
                    }
                case 6:
                    {
                        list.Add1(56);
                        list.Add1(30);
                        list.Add1(70);
                        list.Display();
                        list.DeleteLast();
                        Console.WriteLine("Ater Deleting Last element:");
                        list.Display();
                        break;
                    }
                case 7:
                    {
                        stacks.Push(70);
                        stacks.Push(30);
                        stacks.Push(56);
                        stacks.DisplayStacks();
                        break;
                    }
                case 8:
                    {
                        stacks.Push(70);
                        stacks.Push(30);
                        stacks.Push(56);
                        stacks.DisplayStacks();
                        stacks.Peak();
                        stacks.Pop();
                        stacks.IsEmpty();
                        stacks.DisplayStacks();
                        break;
                    }
                case 9:
                    {
                        stacks.EnQueue(56);
                        stacks.EnQueue(30);
                        stacks.EnQueue(70);
                        stacks.DisplayQueues();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the Valid Number");
                        break;
                    }
            }
        }
    }
}
