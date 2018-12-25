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
            Helloworld(n);
            Console.WriteLine(n);


        }
        public void Helloworld(int n)
        {
            string s;
            s = "Привет мир! ";
             for (int i=0; i<n; i++)
                Console.WriteLine(s);
        }
    }
}
