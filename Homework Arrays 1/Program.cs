using System;
using Arrays;
namespace Homework_Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти минимальный элемент массива");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.Write("Исходный массив: ");
            Console.WriteLine(string.Join(" ", a));
            int min = Arrays.ArraysMethods.FindMinElemOfArr(a);            
            Console.WriteLine();
            Console.WriteLine($"Наименьший элемент массива: {min}");
            
        }
    }
}
