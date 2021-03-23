//3. Перерозташувати елементи у масиві(відємні, невідємні) у порядку їх слідування.
//Для масиву : 1  2 -4  -55  -7 10 100
//Повинні отримати змінений масив: -4  -55  -7  1 2 10 100
//Використати FindAll(), CopyTo().
using System;
using System.Linq;

namespace S2_HW28._03._21._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Fill(arr, -100, 100);
            Print(arr);
            Print(MinusPlus(arr));
            
        }

        private static int[] MinusPlus(int[] arr)
        {
            int[] arr1 = Array.FindAll(arr, x => x < 0);
            int[] arr2 = Array.FindAll(arr, x => x >= 0);
            Array.Resize(ref arr1, arr1.Length + arr2.Length);
            arr2.CopyTo(arr1, arr1.Length - arr2.Length);
            return arr1;
        }

        private static void Fill(int[] arr, int start, int end)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(start, end);
            }
        }
        private static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n=============================\n");
        }
    }
}