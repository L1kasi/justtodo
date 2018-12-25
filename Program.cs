using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {

        static void Main()
        {
            int a, b, c, n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Helloworld(n));

        }
        public static string Helloworld(int n)
        {
            string s, l;
            s = "Привет мир! ";
            l = null;
            for (int i=0; i<n; i++)
             l = l + s;
            return l;
        }
    }
}
