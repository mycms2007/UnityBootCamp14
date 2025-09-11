using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Class3
    {
        static void Main()
        {
            int[] a = { 15, 3, 9, 27, -5, 8, 99 };
            int max = a[0];
            int min = a[0];

            for(int i =1; i<a.Length;i++)
            {
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
            }
            
            //최대값 초소값 찾기

            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
