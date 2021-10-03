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
                try
                {
                    userInput = Int32.Parse(Console.ReadKey().KeyChar.ToString());

                }
                catch (Exception)
                {

                    userInput = 0;
                }
                Console.WriteLine("\n");

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
                        if (linkedList.Remove(new LinkedListClasses.Node(Console.ReadLine())))
                        {
                            Console.WriteLine("Node Removed");
                        }
                        else
                        {
                            Console.WriteLine("Node Not Found");
                        }
                        ;
                        break;

                    case 4:
                        Console.WriteLine("Enter Value to Search For");
                        if (linkedList.Contains(new LinkedListClasses.Node(Console.ReadLine())) != null)
                        {
                            Console.WriteLine("Node Found");
                        }
                        else
                        {
                            Console.WriteLine("Node Not Found");
                        }
                        
                        break;

                    case 5:
                        Console.WriteLine(linkedList);
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\nPress any key to continue\n");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
