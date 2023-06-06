using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            const int n = 20;
            int[] arr = new int[n];
            //  int[] arr = { -2, 3, 4, 3, 0, -2, 4, 4, 1 }; // пример исходного массива
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-5, 6);
                Console.Write("{0,4}", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Данные массива:");
            Console.WriteLine("\tЧисло  Повторы  Первое вхождение");
            int k, m = 0;
            for (int i = 0; i < n; i++)
            {
                bool flag = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                        flag = false;
                }
                if (flag) m++;
            }
            int[,] arr1 = new int[m, 3];
            int q = 0, p = 0;
            for (int i = 0; i < n; i++)
            {
                k = 0;
                bool flag = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j]) flag = false;
                }
                if (flag)
                {
                    for (int l = i; l < n; l++)
                    {
                        if (arr[i] == arr[l])
                        {
                            k++;
                            p = l;
                        }
                    }
                    if (arr[i] < 0) arr1[q, 2] = i;
                    else if (arr[i] >= 0) arr1[q, 2] = p;
                    arr1[q, 0] = arr[i];
                    arr1[q, 1] = k;
                    q++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,10}", arr1[i, j]);
                }
                Console.WriteLine("\r\n");
            }
            Console.WriteLine("Хотите повторить задачу? Если да, нажмите Enter");
            if (Console.ReadKey().Key == ConsoleKey.Enter) Main();
        }
    }
}
