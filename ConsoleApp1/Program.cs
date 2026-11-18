using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            long n = long.Parse(Console.ReadLine());
            Console.Write("Введите a: ");
            long a = long.Parse(Console.ReadLine());

            bool result = MathHelper.IsPower(n, a);
            Console.WriteLine(result
                ? "N является степенью числа a (показатель 0..4)"
                : "N не является степенью числа a (показатель 0..4)");
            Console.ReadKey();
        }
    }
}
