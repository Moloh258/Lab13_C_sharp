using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace lab13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите размер массива: ");
            int n = ToInt32(ReadLine());
            WriteLine("Введите первый член и знаменатель прогрессии: ");
            int a = ToInt32(ReadLine());
            int d = ToInt32(ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = a * (int)(Math.Pow(d, i));
                WriteLine(" {0} ", A[i]);
            }
        }
    }
}
