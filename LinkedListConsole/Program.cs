using System;

namespace LinkedListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedListClasses.LinkedList();
            var stringArr = new string[] { "one", "two", "three", "four" };

            foreach (var item in stringArr)
            {
                linkedList.Add(new LinkedListClasses.Node(item));
            }

            linkedList.AddFirst(new LinkedListClasses.Node("five"));

            Console.WriteLine(linkedList.Contains(new LinkedListClasses.Node("tyt")));
        }
    }
}
