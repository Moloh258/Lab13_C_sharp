using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace lan13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите размер массива (>2)");
            int n = ToInt32(ReadLine());
            WriteLine("Введите первый элемент массива");
            int a = ToInt32(ReadLine());
            WriteLine("Введите второй элемент массива");
            int b = ToInt32(ReadLine());
            int[] A = new int[n];
            A[0] = a;
            A[1] = b;
            WriteLine("");
            for (int i = 2; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    A[i] += A[j];
                }
                WriteLine("{0}й элемент равен {1}", i, A[i]);
            }
        }
    }
}
