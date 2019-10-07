//Напишете програма, която по избор на потребителя прочита от кон-
//золата променлива от тип int, double или string. Ако променливата е
//int или double, трябва да се увеличи с 1. Ако променливата е string,
//трябва да се прибави накрая символа "*". Отпечатайте получения
//резултат на конзолата.Използвайте switch конструкция.
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter variable type 0 - int");
        Console.WriteLine("Enter variable type 1 - double");
        Console.WriteLine("Enter variable type 2 - string");
        int type = int.Parse(Console.ReadLine());
        switch (type)
        {
            case 0:
                Console.Write("Enter number:");
                type = int.Parse(Console.ReadLine());
                Console.WriteLine(type + 1);break;
            case 1:
                Console.Write("Enter number:");
                double type1 = double.Parse(Console.ReadLine());
                Console.WriteLine(type1 + 1); break;
            case 2:
                Console.Write("Enter string:");
                string type2 = (Console.ReadLine());
                Console.WriteLine(type2 + " * "); break;

            default: Console.WriteLine("Wrong"); break;
        }

    }


}