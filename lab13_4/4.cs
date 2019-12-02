using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace lab13_4
{
    class Program
    {
        static void Main(string[] args)
        {  
            WriteLine("Введите размер массива");
            int n = ToInt32(ReadLine());
            WriteLine("Введите элементы массива");
            int[] A = new int[n];
            // объявление всяких переменных
            int c, x = 0, y = n - 1;
            for (int z = 0; z < n; z++)
            {
                A[z] = ToInt32(ReadLine());
            }
            // чет/нечет
            if (n % 2 == 0)
            {
                c = n / 2;
            }
            else
            {
                c = n / 2 + 1;
            }
            //вывод
            for (int i = 0; i < c; i++)
            {
                Write(A[x]);
                x++;
                Write(A[y]);
                y--;
                WriteLine("");
            }
        }
    }
}
