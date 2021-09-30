using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListConsole.UI
{
    public static class UI
    {

        public static string ReturnUI()
        {
            return $"1. Show Head\n" +
                $"2. Add Item\n" +
                $"3. Remove Item\n" +
                $"4. Search For Item\n" +
                $"5. Print\n" +
                $"6. Exit\n";
        }

    }
}
