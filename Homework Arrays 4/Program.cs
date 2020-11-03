using System;
using Arrays;
namespace Homework_Arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс наибольшего элемента массива");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.Write("Исходный массив: ");
            Console.WriteLine(string.Join(" ", a));
            int index = Arrays.ArraysMethods.FindIndexOfMaxElem(a);
            Console.WriteLine();
            Console.WriteLine($"Индекс наибольшего элемента массива: {index}");
        }
    }
}
