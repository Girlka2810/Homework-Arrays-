using System;

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
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-100, 100);
            }
            Console.WriteLine();
            Console.Write("Исходный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Отсортированный массив: ");
            int temp;
            for (int i = 1; i < a.Length; i++)
            {
                temp = a[i];
                int j = i;
                while (j > 0 && temp > a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                    a[j] = temp;
                }
                Console.Write(a[i] + " ");
            }

        }
    }
}
    
