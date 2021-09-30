using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListConsole.LinkedListClasses
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; } = null;

        public Node(string val)
        {
            this.Value = val;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
