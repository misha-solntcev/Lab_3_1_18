using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 18. Вычислить частичную сумму ряда S=1/1^2 +1/3^2 +1/5^2 +⋯
Вычисление прекратить, когда сумма ряда станет больше 2.*/

namespace Lab_3_1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 1;
            double S = n;            
            while (S < 1.23)
            {
                n += 2;
                S += 1 / (n * n);
                Console.WriteLine($"n={n}, S={S}");
            }
            Console.ReadKey();
        }
    }
}
