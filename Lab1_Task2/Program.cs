using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n=");
            var n = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                res += i;
            }
            Console.WriteLine(res);

        }
    }
}
