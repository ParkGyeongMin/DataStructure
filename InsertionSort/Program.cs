using System;
using System.Data;

namespace InsertionSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {10, 2, 3, 100, 89, 22, 32, 19, 24};

            int temp,j;

            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                for ( j = i - 1; j>=0 && arr[j] > temp; j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[j + 1] = temp;
            }

            foreach (var s in arr)
            {
                Console.WriteLine(s);
                
            }
        }
        
        
    }
}