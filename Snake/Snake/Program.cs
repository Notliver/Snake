using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 3;
            char symb1 = '*';
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb1);
            Console.ReadKey();
        }
    }
}
