using System;

namespace Methods_ReadingInStringsInts
//credit: Yellow Book C# by Rob Miles
{
    class MainClass
    {
        static string ReadString(string prompt)
        //reads in user input & makes sure it's not an empty string
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result == "");
            return result;
        }

        static int ReadInt(string prompt, int low, int high)
        //reads in user number & makes sure it falls within specified range
        {
            int result;
            do
            {
                string intString = ReadString(prompt);
                result = Convert.ToInt32(intString);
            } while ((result < low) || (result > high));
            return result;
        }

        public static void Main(string[] args)
        {
            string name;
            name = ReadString("Enter your name: ");

            int age;
            age = ReadInt("Enter your age: ", 0, 150);
            
        }
    }
}
