using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static long fibonacci(int n)
        {
            if (n < 2) return n;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Mennyi szám jelenjen meg? ");
            int szam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine(fibonacci(i));
            }

            Console.ReadKey();
        }
    }
}
