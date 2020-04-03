using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static int MAX = 100;

        static void spiralFill(int m, int n, int[,] a)
        {
            int val = 1;

            int k = 0, l = 0;
            while (k < m && l < n)
            {

                for (int i = l; i < n; ++i)
                {
                    a[k, i] = val++;
                }

                k++;

                for (int i = k; i < m; ++i)
                {
                    a[i, n - 1] = val++;
                }
                n--;

                if (k < m)
                {
                    for (int i = n - 1; i >= l; --i)
                    {
                        a[m - 1, i] = val++;
                    }
                    m--;
                }


                if (l < n)
                {
                    for (int i = m - 1; i >= k; --i)
                    {
                        a[i, l] = val++;
                    }
                    l++;
                }
            }
        }

        public static void Main()
        {
            int n = 0;

            Console.WriteLine("Digite um número inteiro para Matriz NxN");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[MAX, MAX];
            spiralFill(n, n, a);
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
