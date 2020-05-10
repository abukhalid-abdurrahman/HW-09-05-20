using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 20...");

            //Задание 2.1
            Task21();

            //Задание 2.2
            Task22();

            //Задание 2.3
            Task23();

            //Задание 2.4
            Task23();

            Console.Read();
        }

        static void Task21()
        {
            Console.WriteLine("Task 2.1");
            Console.WriteLine(new string('*', 25));

            int randNumber = new Random().Next(300000, 500000);
            string numbersStr = randNumber.ToString();
            var editedList = from elem in numbersStr
                             select elem;
            editedList = editedList.Reverse();
            Console.Write(randNumber + $"\t[{string.Join(", ", editedList)}]\n");

            Console.WriteLine(new string('*', 25));
        }

        static void Task22()
        {
            Console.WriteLine("Task 2.2");
            Console.WriteLine(new string('*', 25));

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            var positiveNumbersList = numbers.TakeWhile(x => x > 0);
            var negativeNumbersList = numbers.Skip(positiveNumbersList.Count()).TakeWhile(x => x < 0);
            int positiveCount = positiveNumbersList.Count(), negativeSum = 0;
            foreach (int i in negativeNumbersList)
                negativeSum += i;

            int[] results = { positiveCount, negativeSum };
            Console.WriteLine($"[{string.Join(", ", numbers)}]\t[{string.Join(", ", results)}]");

            Console.WriteLine(new string('*', 25));
        }

        static void Task23()
        {
            Console.WriteLine("Task 2.3");
            Console.WriteLine(new string('*', 25));

            string[] objects = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            var editedList = from elem in objects
                             orderby elem.Length
                             select elem;
            Console.WriteLine($"[{string.Join(", ", objects)}]\t[{string.Join(", ", editedList)}]");
            Console.WriteLine(new string('*', 25));
        }

        static void Task24()
        {
            Console.WriteLine("Task 2.4");
            Console.WriteLine(new string('*', 25));

            string[] objects = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            var editedList = from elem in objects
                             orderby elem.Length
                             select elem;
            Console.WriteLine($"[{string.Join(", ", objects)}]\t[{string.Join(", ", editedList)}]");
            Console.WriteLine(new string('*', 25));
        }
    }
}
