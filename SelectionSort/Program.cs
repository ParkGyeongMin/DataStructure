using System;
using System.Collections.ObjectModel;

namespace SelectionSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 5, 3, 2, 10, 7};
            int temp, min; //임시 저장 , 최소값 

            for (int i = 0; i < arr.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }

            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }


        }
    }
}