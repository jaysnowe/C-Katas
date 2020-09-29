using System;

namespace Sorting_Bubble
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ////practice taking in two unrelated ints and switching the values
            //int firstNum = 5;
            //int secondNum = 6;
            //int placeholder = 0;

            //placeholder = secondNum;
            //secondNum = firstNum;
            //firstNum = placeholder;

            //Console.WriteLine($"First number now = {firstNum}");
            //Console.WriteLine($"Second number now = {secondNum}");


            //declares an array   
            int[] arr = new int[3] { 8, 7, 0 };
            //outside integer to act as temporary placeholder as values sort
            int temp = 0;
            //starts @ arr[0] & iterates through
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                //compares arr[i]+1 (same as arr[j]) to arr[i] & iterates through
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }

                //print out array values in final order
                Console.WriteLine(arr[i]);
            }
            ////alternate way to print out array values
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
        }

    }
}




