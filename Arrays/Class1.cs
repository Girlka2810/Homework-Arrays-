using System;

namespace Arrays
{
    public class ArraysMethods
    {
        public static int[] InputRandomArray(int n)
        {
            int[] array = new int[n];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 100);
            }
            return array;
        }
     
        public static int FindMinElemOfArr(int []a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
                if (min >= a[i])
                {
                    min = a[i];
                }
            return min;
        }
        public static int FindMaxElemOfArr(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (max <= a[i])
                {
                    max = a[i];
                }
            return max;
        }
        public static int FindIndexOfMinElem (int[] a)
        {
           int min = a[0];
            int index=0;
            for (int i = 0; i < a.Length; i++)
                if (min >= a[i])
                {
                    min = a[i];
                    index = i;
                }
            return index;
        }
        public static int FindIndexOfMaxElem(int []a)
        {
            int max = a[0];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
                if (max <= a[i])
                {
                    max = a[i];
                    index = i;
                }
            return index;
        }
        public static int FindSummOfOddIndexElem (int[]a)
        {
            int oddIndexSum = 0;
            for (int i = 0; i < a.Length; i++)
                if (i % 2 != 0)
                {
                    oddIndexSum += a[i];
                }
            return oddIndexSum;
        }
        public static int[] ReversArray(int []ar)
        {
            int t;
            int lenght=ar.Length;
            for (int i = 0; i < lenght/2; i++)
            {
                t = ar[i];
                ar[i] = ar[lenght - i - 1];
                ar[lenght - i - 1] = t;
            }
            return ar;
        }
        public static int SumOfOddElementQuantity(int[] a)
        {
            int oddElementQuant = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = i;
                if (temp % 2 != 0)
                {
                    oddElementQuant++;
                }
            }
                return oddElementQuant;
        }
        public static int[] SortArrayChangeTheHalfs (int[] arr)
        {
            int[] a = new int[arr.Length];
            Array.Copy(arr, a, arr.Length);
            int half = arr.Length / 2;
            for (int i = 0; i < half; i++)
            {
                int t=a[i] ;
                if (a.Length% 2 == 0)
                {
                    a[i] = a[half + i];
                    a[half + i] = t;
                }
                else
                {
                    a[i] = a[half + i+1 ];
                    a[half + i+1 ] = t;
                }
                            }
            return a;
        }
        public static int[] SortAraySelection (int []arr)
        {
            int[] a = new int[arr.Length];
            Array.Copy(arr, a, arr.Length);
            int temp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
        public static int [] SortArrayBubble (int[]arr)
        {
            int[] a = new int[arr.Length];
            Array.Copy(arr, a, arr.Length);
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

            }
            return a;
        }
    }
    }
        
