using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_7
{
    public class Library
    {
        public static void Swap(int[] arr, int a, int b)
        {
            int temp;
            temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        
        public static void PrintArray(int[] arr)
        {
            System.Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
        }

        public static void WriteArray(int[] arr, int a, int b)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(a, b);
            }
        }

        public static void WriteArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 1000);
            }
        }

        public static void WriteArray(int[] arr, int order)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }
    }
}