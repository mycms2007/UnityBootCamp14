using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Class2
    {
        static void Main()
        {
            int x = 10;
            int y = 20;
            Swap(ref x, ref y);

            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static void Swap(ref int a, ref int b)
        {
          int temp = a;
            a = b;
            b = temp;
               
        }
    }
}
