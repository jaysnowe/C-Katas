using System;

namespace Function_TwoFunctions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double quotient = 0;
            Console.WriteLine("Please give me the dividend.");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please give me the divisor.");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            quotient = CalcQuotient(firstNum, secondNum);
            PrintQuotient(quotient);
        }
        public static double CalcQuotient(double firstNum, double secondNum)
        {
            double quotient = firstNum / secondNum;
            return quotient;
        }
        public static void PrintQuotient(double quotient)
        {
            Console.WriteLine($"Your quotient is {quotient}");
        }
    }
}




