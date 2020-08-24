using System;
using System.Collections.Generic;
using calculator.Models;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int random = rand.Next(0, 30) + 1;
            System.Console.WriteLine(random);



            Calculator calc = new Calculator("Cool Calc");








        }

        //     static void Main(string[] args)
        //     {
        //         short shortNumber = 10000;
        //         int regularNumber = 1000000000;
        //         long longNumber = 1000000000000000000;
        //         double temperature = 82.3;
        //         float velocity = 10.4f;
        //         decimal money = 10.00000001m;



        //         string greeting = "hello";
        //         char letter = 'h';
        //         string singleLetter = "h";

        //         Console.WriteLine("Hello World!");

        //         for (int index = 0; index < 10; index++)
        //         {
        //             // System.Console.WriteLine($"{index}  {index} {singleLetter}");
        //         }

        //         int count = 0;
        //         while (count < 10)
        //         {
        //             // System.Console.WriteLine(count);
        //             count++;
        //         }

        //         // int[] numbers = new int[] { 3, 5, 12, 3 };
        //         // int[] temp = new int[numbers.Length + 1];

        //         // for (int i = 0; i < numbers.Length; i++)
        //         // {
        //         //     temp[i] = numbers[i];
        //         // }

        //         // temp[temp.Length - 1] = 27;
        //         // numbers = temp;

        //         List<int> numbers = new List<int>();
        //         numbers.Add(3);
        //         numbers.Add(5);
        //         numbers.Add(12);
        //         numbers.Add(3);
        //         numbers.Add(27);

        //         foreach (int num in numbers)
        //         {
        //             System.Console.WriteLine(num);
        //         }

        //         numbers.ForEach(num => System.Console.WriteLine(num));


        //         System.Console.WriteLine();

        //     }
        // }


    }

}