using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex 4: Scrieti un program care va determina daca un numar este sau nu palindrom.
            */

            Console.WriteLine("Introduceti numarul: ");
            int number = int.Parse(Console.ReadLine());
            int rest = 0;
            int sum = 0;
            int temp = number;

            while (number > 0)
            {
                rest = number % 10;
                sum = sum * 10 + rest;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"{temp} este palindrom");
            }
            else
            {
                Console.WriteLine($"{temp} nu este palindrom");
            }

        }
    }
}
