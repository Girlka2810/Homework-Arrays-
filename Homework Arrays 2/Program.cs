using System;
using Arrays;
namespace Homework_Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти максимальный элемент массива");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = Arrays.ArraysMethods.InputRandomArray(a);
            Console.Write("Исходный массив: ");
            Console.WriteLine(string.Join(" ", a));
            int max = Arrays.ArraysMethods.FindMaxElemOfArr(arr);
            Console.WriteLine();
            Console.WriteLine($"Наибольший элемент массива: {max}");
        }
    }
}
