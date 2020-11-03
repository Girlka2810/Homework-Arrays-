using System;
using Arrays;
namespace Homework_Arrays_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert))");
            Console.WriteLine("Введите количество переменных:");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.WriteLine();
            Console.Write("Исходный массив:");
            Console.WriteLine(String.Join(" ", a));
            Console.Write("Сортированный массив:");
            int[] SortA = Arrays.ArraysMethods.SortAraySelection(a);
            Console.WriteLine(String.Join(" ", SortA));
        }
    }
}

