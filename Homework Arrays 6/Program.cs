using System;
using Arrays;
namespace Homework_Arrays_6
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделать реверс массива (массив в обратном направлении)");
            Console.WriteLine("Введите количество переменных:");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.WriteLine();
            Console.Write("Исходный массив:");
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine();
                       Console.Write("Реверс массива:");
            int[] revers = Arrays.ArraysMethods.ReversArray(a);
            Console.WriteLine(string.Join(" ", revers));
            ;
        }
    }
}
