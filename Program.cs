using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");
            int[] array;
            array = new int[5];
            int i = 0;
            int sum = 0;
            Random random = new Random();
            while (i < array.Length)
            {
                array[i] = random.Next(100, 999);
                Console.WriteLine(array[i]);
                i++;

            }

            for (i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) 
                sum = sum + array[i];
            }
            Console.WriteLine(" сумма нечётных =" + sum);
            Console.ReadKey();
        }
    }
}
