using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListConsole.LinkedListClasses
{
    public class LinkedList
    {
        private Node Head { get; set; }

        public Node GetFirst()
        {
            return Head;
        }

        public void AddFirst(Node node)
        {
            //No nodes in list. node becomes head;
            if(Head == null)
            {
                Head = node;
            }

            //Add node to beginning of list.
            else
            {
                node.Next = Head;
                Head = node;
            }

        }

        //returns a node witha matching item. If no match return null;
        public Node Contains(Node node)
        {
            //if head is null return null
            if (Head == null)
            {
                return null;
            }

            //loop through list comparing node values
            else
            {
                var currnetNode = Head;

                while(currnetNode != null)
                {
                    //matching node found. return node;
                    if (currnetNode.Value == node.Value)
                    {
                        return currnetNode;
                    }

                    currnetNode = currnetNode.Next;
                }
            }
            //No matching node found. Return null;
            return null;
        }

        //Remove node containing the item. Link adjacent nodes.
        public bool Remove(Node node)
        {   

            //no nodes in list
            if (Head == null)
            {
                return false;
            }
            //remove at head
            else if(Head.Value == node.Value)
            {
                Head = Head.Next;
                return true;
            }

            else
            {
                var walker = Head;
                var runner = Head.Next;

                while (runner != null)
                {
                    //found node to remove
                    if (runner.Value == node.Value)
                    {
                        //match found at end
                       if (runner.Next == null)
                        {
                            walker.Next = null;
                        }
                        else
                        {
                            walker.Next = runner.Next;
                        }

                        return true;
                    }
                    walker = walker.Next;
                    runner = runner.Next;
                }
            }
            return false;
        }

        //Add node to end of list;
        public void Add(Node node)
        {
            //no nodes in list. Add node becomes head;
            if (Head == null)
            {
                Head = node;
            }
            //Add node to end of list
            else
            {
                var currentNode = Head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = node;
            }
        }

        public override string ToString()
        {
            //Linked list has no values.
            if (Head == null)
            {
                return "Linked List is Empty";
            }

            var returnStr = "";
            var currentNode = Head;

            while(currentNode != null)
            {
                returnStr += $"{currentNode.Value} - ";
                currentNode = currentNode.Next;
            }

            returnStr = returnStr.Substring(0, returnStr.LastIndexOf('-') - 1);

            return returnStr;
        }

    }
}
