using System;
using System.Linq;

namespace HW1_Fizz
{
    class Program
    {
        static void Main(string[] args)
        {

            #if DEBUG
                try
                {
                    Console.WriteLine("Here we go again!");
                    FizzBuzz();
                    Console.WriteLine(ReverseString("abc123"));
            }
            finally
                {
                    Console.WriteLine("Press enter to close...");
                    Console.ReadLine();
                }
            #endif
        }

        /*Напишите консольную программу, которая выводит числа от 1 до 100.
            Если число делится на 3 – вместо числа вывести “Fizz”. 
        Ли число делится на 5 – вместо числа вывести “Buzz”,
        а если делится и на 5 и на 3 – вывести “Fizz - Buzz” */
        public static void FizzBuzz()
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                        Console.WriteLine("Fizz - Buzz");
                    else
                        Console.WriteLine("Fizz");
                }
                else
                {
                    if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(i);

                }
                    
            }

        }

        /*Написать консольную программу на переворачивание входной строчки. 
         * Например, пользователь ввёл строчку «abc123», 
         * на выходе должна получиться строчка «321cba»
        */
        public static string ReverseString(string inputString)
        {
            //string revString = "";
            //for(int i=inputString.Length(); i>=0; i--)
            //{
            //    revString = revString + inputString[i];
            //}
            //return revString;
            //return inputString.ToString().Reverse(); 
            return String.IsNullOrEmpty(inputString) ? string.Empty : new string(inputString.ToCharArray().Reverse().ToArray());
        }
    }
}
