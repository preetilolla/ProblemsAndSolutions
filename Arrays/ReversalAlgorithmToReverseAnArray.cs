using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class ReversalAlgorithm
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(input, i => int.Parse(i)); // or --> input.Select(int.Parse).ToArray();

            rotateArray(arr, k);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

        // Reversal Algorithm
        static void rotateArray(int[] arr, int k)
        {
            reverseArray(arr, 0, k - 1);
            reverseArray(arr, k, arr.Length - 1);
            reverseArray(arr, 0, arr.Length - 1);
        }

        static void reverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
