//Сортирайте 3 реални числа в намаляващ ред.Използвайте вложени
//if оператори.
using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Напишете 3 числа: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double[] arr = new double[] { a, b, c };
        Array.Sort(arr);
        Array.Reverse(arr);
        foreach (double value in arr)
        {
            Console.WriteLine(value + " ");
        }

    }
    }
