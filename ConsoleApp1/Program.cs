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
            Console.WriteLine("Введите первую цифру");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью цифру");
            c = int.Parse(Console.ReadLine());
            n = a + b + c;
            Helloworld(n);
            Console.WriteLine("количество написанных фраз,  а также сумма трех чисел");
             Console.WriteLine(n);
             Console.ReadKey();
        }
        public static void Helloworld(int n)
        {
                string s= "Привет мир! ";
                for (int i = 0; i < n; i++)
                    Console.WriteLine(s);
        }
     }
}
