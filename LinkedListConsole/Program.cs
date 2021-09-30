using System;

namespace LinkedListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedListClasses.LinkedList();
            var userInput = 0;

            while (userInput != 6)
            {
                Console.WriteLine(UI.UI.ReturnUI());
                userInput = int.Parse(System.Console.ReadKey().ToString());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine(linkedList.GetFirst());
                        break;

                    case 2:
                        Console.WriteLine("Enter Node Value");
                        linkedList.Add(new LinkedListClasses.Node(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine("Enter Value to Remove");
                        linkedList.Remove(new LinkedListClasses.Node(Console.ReadLine()));
                        break;

                    case 4:
                        Console.WriteLine("Enter Value to Search For");
                        linkedList.Contains(new LinkedListClasses.Node(Console.ReadLine()));
                        break;

                    default:
                        break;
                }
            }

        }
    }
}
