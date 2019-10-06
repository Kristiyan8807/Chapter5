//Напишете програма, която намира най-голямото по стойност число,
//измежду три дадени числа.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Напишете 3 числа: ");
        Console.Write("Напишете числото А: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Напишете числото B: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Напишете числото C: ");
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("Най-голямото число е A: {0}", a);

        }
        else if(b > a && b > c)
        { 
            Console.WriteLine("Най-голямото число е B: {0}", b);
        }
        else
        {
            Console.WriteLine("Най-голямото число е C: {0}", c);
        }
    }
}
