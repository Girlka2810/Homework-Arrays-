using System;
using Arrays;
namespace Homework_Arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс минимального элемента массива");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.Write("Исходный массив: ");
            Console.WriteLine(string.Join(" ", a));
            int index = Arrays.ArraysMethods.FindIndexOfMinElem(a);
            Console.WriteLine();
            Console.WriteLine($"Индекс наименьшего элемента массива: {index}");
        }
    }
}
