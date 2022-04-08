using System;
//Write a function that takes in a non-empty array of integers that are sorted in ascending order and returnas a new array of the same length with the squares of the original
//integers also sorted in ascending order.
namespace _03.SortedSquaredArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3 };
            var retorno = SortedSquaredArray(array);
            foreach (var item in retorno) Console.WriteLine(item);

            var retorno2 = SortedSquaredArray2(array);
            foreach (var item in retorno2) Console.WriteLine(item);

        }

        // O(nlogn) time | O(n) space
        public static int[] SortedSquaredArray(int[] array)
        {
            int[] sortedSquares = new int[array.Length];

            for(int idx = 0; idx < array.Length; idx++)
            {
                int value = array[idx];
                sortedSquares[idx] = value * value;
            }
            Array.Sort(sortedSquares);
            return sortedSquares;
        }

        // O (n) time | O (n) space
        public static int[] SortedSquaredArray2(int[] array)
        {
            int[] sortedSquares = new int[array.Length];
            int smallerValueIdx = 0;
            int largerValueIdx = array.Length - 1;

            for(int idx = array.Length - 1; idx >= 0; idx--)
            {
                int smallerValue = array[smallerValueIdx];
                int largerValue = array[largerValueIdx];

                if (Math.Abs(smallerValue) > Math.Abs(largerValue))
                {
                    sortedSquares[idx] = smallerValue * smallerValue;
                    smallerValueIdx++;
                }

                else
                {
                    sortedSquares[idx] = largerValue * largerValue;
                    largerValueIdx--;
                }
            }

            return sortedSquares;
        }



       

    }
}
