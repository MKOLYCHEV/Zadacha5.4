using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            Console.Write("Сформированный массив: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0) continue;
                if (array[i]>0&&array[i]%2==1)
                    sum+= 1;
            }
            Console.WriteLine("Количество нечетных положительных элементов сформированного массива, стоящих на четных местах, равно {0}.",sum);
            Console.ReadKey();
        }
    }
}
