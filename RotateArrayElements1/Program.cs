using System;

namespace RotateArrayElements1
{
    class Program
    {
        public int[] RotateArray(int[] arr, int d)
        {
            int len = arr.Length;
            int[] tempArray = new int[len];
            int j = 0;

            for (int i = d; i < len; i++) 
            {
                tempArray[j] = arr[i];
                j++;
            }

            for (int i = 0; i < d; i++)
            {
                tempArray[j] = arr[i];
                j++;
            }

            return tempArray;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int d = 4;

            Program rotateArray = new Program();

            arr = rotateArray.RotateArray(arr, d);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
