﻿using System;

namespace Homework_Arrays_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать количество нечетных элементов массива");
            Console.WriteLine("Введите количество переменных:");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-100, 100);
            }
            Console.WriteLine();
            Console.Write("Исходный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int oddElementQuant = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int t = a[i];
                //t = a[i];
                if (t % 2 != 0)
                {
                    oddElementQuant++;
                }

            }
            Console.WriteLine($"Количество нечетных элементов массива: {oddElementQuant}");
        }
    }
}
