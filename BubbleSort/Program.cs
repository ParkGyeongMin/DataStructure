/*
 * 인접한 값을 계속 바꾸면서 위치를 바꾸며 최대, 최소값을 구하는 정렬 방식 
 */
using System;

namespace BubbleSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {99, 11, 3, 4, 2, 1, 87};
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}