using System;
using Arrays;
namespace Homework_arrays_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.");
            Console.WriteLine("Введите количество переменных:");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.WriteLine();
            Console.Write("Исходный массив:");
            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine();
            Console.Write("Отсортированный массив: ");
            int[] SortA = Arrays.ArraysMethods.SortArrayChangeTheHalfs(a);
            Console.WriteLine(String.Join(" ", SortA));
        }
    }
}
