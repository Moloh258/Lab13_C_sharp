using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace lab13_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите рамер массива");
            int n = ToInt32(ReadLine());
            int[] A = new int[n];
            WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                A[i] = ToInt32(ReadLine());
            }
            //нечетные
            for (int i = 0; i < n;)
            {
                Write(" {0}", A[i]);
                i += 2;
            }
            WriteLine("");
            //четные 
            for (int i = n - 1; i >= 0 ; i--)
            {
                if (i % 2 != 0)
                {
                    Write(" {0}", A[i]);
                }
            }
        }
    }
}
