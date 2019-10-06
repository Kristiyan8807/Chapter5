//Напишете програма, която намира най-голямото по стойност число
//измежду дадени 5 числа.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Напишете 5 числа: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > f)
        {
            Console.WriteLine("Най голямото число е: {0}", a);
        }
        else if (b > a && b > c && b > d && b > f)
        {
            Console.WriteLine("Най голямото число е: {0}", b);
        }
        else if (c > a && c > b && c > d && c > f)
        {
            Console.WriteLine("Най голямото число е: {0}", c);
        }
        else if (d > a && d > b && d > c && d > f)
        {
            Console.WriteLine("Най голямото число е: {0}", d);
        }
        else
        {
            Console.WriteLine("Най голямото число е: {0}", f);
        }
    }
}
