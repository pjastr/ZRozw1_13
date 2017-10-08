using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int suma = 0;
            while (i<=n)
            {
                suma += i;
                i++;
            }
            Console.WriteLine("Suma = {0}", suma);
            Console.ReadKey();
        }
    }
}
