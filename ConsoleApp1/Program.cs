using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main()
        {
            int a, b, c, n;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            n = a + b + c;
            Itsme.Helloworld(n);
            Console.WriteLine(n);
        }
        public static void Helloworld(int n)
        {
                string s;
                s = "Привет мир! ";
                for (int i = 0; i < n; i++)
                    Console.WriteLine(s);
        }
     }
}
