using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObjectsTasks
{
    class Program1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Задача 13: Минимальное значение ===");
            Task13_Min();
            Console.WriteLine();
        }
        
        //ЗАДАЧА13 МИН ЗНАЧЕНИЕ

        static void Task13_Min()
        {
            int[] numbers = { 3, 7, 2, 9, 1 };

            var min = numbers.Min();

            Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");
            Console.WriteLine($"Минимальное значение: {min}");
        }
    }
}