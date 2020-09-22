using System;

namespace SumFunction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please give me the first number to sum.");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give me the second number to sum.");
            int secondNum = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"The sum of the two numbers is {Sum(firstNum, secondNum)}");

        }
        public static int Sum(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }
    }
}




