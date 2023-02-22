using System;
using static System.Console;

namespace arraysExam
{
    //public static int CalcSum(int[] nums)
    //{
    //    int sum = 0;
    //    for (int x = 0; x < nums.length; x++)
    //    {
    //        sum += nums[x];
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("Hello World!");

            int[] three = { 3, 4, 5 };
            int[] five = { 33, 44, 55, 66, 77 };
            int[] seven = { 333, 444, 555, 666, 777, 888, 999 };


            int sumThree = 0;
            for (int x = 0; x < three.Length; ++x)
            {
                Write(three[x] + " ");
                sumThree += three[x];
            }

            WriteLine("\nTotal is " + sumThree);
            WriteLine("----------------------- \n");


            int sum = 0;
            for (int x = 0; x < five.Length; ++x)
            {
                Write(five[x] + " ");
                sum += five[x];
            }

            WriteLine("\nTotal is " + sum);
            WriteLine("-----------------------\n ");




            int sumSeven = 0;
            for (int x = 0; x < seven.Length; ++x)
            {
                Write(seven[x] + " ");
                sumSeven += seven[x];
            }

            WriteLine("\nTotal is " + sumSeven);
            WriteLine("-----------------------\n ");

            ReadKey();
        }
    }

    
}

