using System;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Creating simple LinkedList \n 2 for Adding value in LinkedList\n 3 for Appending a value in LinkedList\n 4 for Inserting Value in LinkedList\n" +
                " 5 for Deleting First Element");
            Console.WriteLine("Enter a Number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            LinkedList list = new LinkedList();
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
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
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
                        list.Delete();
                        Console.WriteLine("Ater Deleting first element:");
                        list.Display();
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
