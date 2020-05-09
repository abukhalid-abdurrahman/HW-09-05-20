using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 20...");

            //Задание 2.1
            int randNumber = new Random().Next(300000, 500000);
            string numbersStr = randNumber.ToString();
            var editedList = from elem in numbersStr
                             select elem;
            editedList = editedList.Reverse();

            Console.Write(randNumber + "\t[");
            foreach (var item in editedList)
                Console.Write($"{item}, ");
            Console.Write("]");

            Console.Read();
        }
    }
}
