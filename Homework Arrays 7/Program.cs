using System;
using Arrays;
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
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.WriteLine();
            Console.Write("Исходный массив:");
            Console.WriteLine(String.Join(" ", a));
            int oddElementQuant = Arrays.ArraysMethods.SumOfOddElementQuantity(a);
            Console.WriteLine($"Количество нечетных элементов массива: {oddElementQuant}");
        }
    }
}
