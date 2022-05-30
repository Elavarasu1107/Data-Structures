using System;

namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Creating simple LinkedList \n 2 for Adding Value in LinkedList");
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
            }
        }
    }
}
