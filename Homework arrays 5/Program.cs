using System;

namespace Homework_arrays_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посчитать сумму элементов массива с нечетными индексами");
            Console.WriteLine("Введите количество переменных массива");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.Write("Исходный массив: ");
            Console.WriteLine(string.Join(" ", a));
            int oddIndexSum = Arrays.ArraysMethods.FindSummOfOddIndexElem(a);
            Console.WriteLine();                                                                                                                                                                                                                                                                                                                                                                                                             
            Console.WriteLine($"Сумма элементов с нечетными индексами равна: {oddIndexSum} ");


        }
    }
}
