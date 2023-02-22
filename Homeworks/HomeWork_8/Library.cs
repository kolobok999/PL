using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_8
{
    public class Library
    {
        public static void Swap(int[] arr, int a, int b)  // Меняет местами элеминты массива
        {
            int temp;
            temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public static void PrintArray(int[] arr) //Печатает массив
        {
            System.Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
        }

        public static void WriteArray(int[] arr, int a, int b) // Заполняет массив случайными числами в промежутке [a, b)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(a, b);
            }
        }

        public static void WriteArray(int[] arr) // Заполняет массив случайными числами в промежутке [1, 1000)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 1000);
            }
        }

        public static void WriteArray(int[] arr, int order) // Заполняет массив числами от 1 до n, где n - длина массива
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }

        public static int ReadNumber()
        {
            int num;
            while (true)
            {
                try
                {

                    System.Console.WriteLine("Введите число");
                    num = int.Parse(Console.ReadLine());
                    return num;
                }
                catch
                {
                    System.Console.WriteLine("Это не число!!! \n");
                }
            }
        }
    }
}