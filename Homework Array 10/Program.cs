using System;
using Arrays;
namespace Homework_Array_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))");
            Console.WriteLine("Введите количество переменных:");
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = Arrays.ArraysMethods.InputRandomArray(n);
            Console.WriteLine();
            Console.Write("Исходный массив:");
                        Console.WriteLine(String.Join(" ",a));
            Console.Write("Отсортированный массив: ");
            int[] SortA=Arrays.ArraysMethods.SortArrayBubble(a);
            Console.WriteLine(String.Join(" ", SortA));


        }
    }
}
    
