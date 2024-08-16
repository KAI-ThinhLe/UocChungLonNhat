using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine());

        a = Math.Abs(a);
        b = Math.Abs(b);

        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }

            else
            {
                b = b - a;
            }
        }

        Console.WriteLine("The greatest common divisor is: " + a);
    }
}
